//Librerias a usar
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Creacion del namespace, clase y constructor del formulario
namespace Pago_empleado2
{
    public partial class FormPago : Form // Heredamos de Form para crear un formulario de Wind
    {
        public FormPago() // Constructor del formulario
        {
            InitializeComponent(); // Método que inicializa los componentes del formulario
            this.FormBorderStyle = FormBorderStyle.None; // Elimina la barra de título y bordes del formulario

            this.Text = "Sistema de Pago de Empleados";// Título del formulario
            this.BackColor = Color.FromArgb(45, 45, 48); // gris oscuro
            this.FormBorderStyle = FormBorderStyle.FixedSingle;// Evita que el formulario sea redimensionable
            this.MaximizeBox = false;// Deshabilita el botón de maximizar
            this.StartPosition = FormStartPosition.CenterScreen;// Centra el formulario en la pantalla

            txtResultado.BackColor = Color.FromArgb(30, 30, 30);// Fondo del cuadro de texto
            txtResultado.ForeColor = Color.Lime;// Texto en verde brillante
            txtResultado.Font = new Font("Consolas", 11);// Fuente monoespaciada para mejor legibilidad
            txtResultado.BorderStyle = BorderStyle.None;// Sin bordes para un aspecto más limpio

            button1.BackColor = Color.FromArgb(0, 120, 215); // Fondo azul vibrante para el botón de calcular
            button1.ForeColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;

            button2.BackColor = Color.Gray;
            button2.ForeColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;

            button1.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.BorderSize = 0;

            dvgEmpleados.CellClick += dgvEmpleados_CellClick;
            BtnCargar.Click += btnCargar_Click;
            BtnActualizar.Click += btnActualizar_Click;
            BtnEliminar.Click += btnEliminar_Click;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtHoras_TextChanged(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtEmpleado.Text))
                {
                    MessageBox.Show("Ingrese el nombre del empleado");
                    return;
                }

                if (!int.TryParse(txtHoras.Text, out int horas))
                {
                    MessageBox.Show("Horas inválidas");
                    txtHoras.Focus();
                    return;
                }

                if (!double.TryParse(txtTarifa.Text, out double tarifa))
                {
                    MessageBox.Show("Tarifa inválida");
                    txtTarifa.Focus();
                    return;
                }

                if (horas < 0 || tarifa < 0)
                {
                    MessageBox.Show("Los valores no pueden ser negativos");
                    return;
                }

                double basico = horas * tarifa;
                double bonificacion = basico * 0.2;
                double neto = basico + bonificacion;

                txtResultado.Text = "Resumen de Pago a Empleado\n";
                txtResultado.AppendText("\nEmpleado: " + txtEmpleado.Text);
                txtResultado.AppendText("\nEl básico es: $" + basico);
                txtResultado.AppendText("\nBonificación: $" + bonificacion);
                txtResultado.AppendText("\nNeto: $" + neto);

                string conexion = "server=localhost;database=pagos_nueva;user=usuario1;password=1234;";

                using (MySqlConnection con = new MySqlConnection(conexion))
                {
                    con.Open();

                    string query = @"INSERT INTO empleados 
                           (nombre, horas, tarifa, basico, bonificacion, neto) 
                           VALUES (@nombre, @horas, @tarifa, @basico, @bonificacion, @neto)";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@nombre", txtEmpleado.Text);
                        cmd.Parameters.AddWithValue("@horas", horas);
                        cmd.Parameters.AddWithValue("@tarifa", tarifa);
                        cmd.Parameters.AddWithValue("@basico", basico);
                        cmd.Parameters.AddWithValue("@bonificacion", bonificacion);
                        cmd.Parameters.AddWithValue("@neto", neto);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Datos guardados correctamente");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error de MySQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtEmpleado.Text = "";
            txtHoras.Text = "";
            txtTarifa.Text = "";
            txtResultado.Text = "";

            txtEmpleado.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Font = new Font("Arial", 12, FontStyle.Bold);
            label1.ForeColor = Color.DarkBlue;

            txtResultado.Multiline = true;
            txtResultado.BackColor = Color.Black;
            txtResultado.ForeColor = Color.Lime;
            txtResultado.Font = new Font("Consolas", 10);

            button1.BackColor = Color.Green;
            button1.ForeColor = Color.White;

            button2.BackColor = Color.Red;
            button2.ForeColor = Color.White;
        }

        private void FormPago_Load(object sender, EventArgs e)
        {

        }

        private void FormPago_Load_1(object sender, EventArgs e)
        {

        }

        private void txtEmpleado_TextChanged(object sender, EventArgs e)
        {
            if (txtEmpleado.Text.Any(char.IsDigit))
            {
                txtEmpleado.Text = new string(txtEmpleado.Text.Where(c => !char.IsDigit(c)).ToArray());
                txtEmpleado.SelectionStart = txtEmpleado.Text.Length;
            }
        }

        private void txtEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir letras, espacios y teclas de control
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras en el nombre");
            }
        }
        private void CargarDatos()
        {
            string conexion = "server=localhost;database=pagos_nueva;user=usuario1;password=1234;";

            using (MySqlConnection con = new MySqlConnection(conexion))
            {
                con.Open();

                string query = "SELECT * FROM empleados";

                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dvgEmpleados.DataSource = dt;
            }
        }
        private void btnCargar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dvgEmpleados.Rows[e.RowIndex];

                txtEmpleado.Text = fila.Cells["nombre"].Value.ToString();
                txtHoras.Text = fila.Cells["horas"].Value.ToString();
                txtTarifa.Text = fila.Cells["tarifa"].Value.ToString();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dvgEmpleados.CurrentRow == null) return;

            int id = Convert.ToInt32(dvgEmpleados.CurrentRow.Cells["id"].Value);

            string conexion = "server=localhost;database=pagos_nueva;user=usuario1;password=1234;";

            using (MySqlConnection con = new MySqlConnection(conexion))
            {
                con.Open();

                string query = @"UPDATE empleados 
                         SET nombre=@nombre, horas=@horas, tarifa=@tarifa 
                         WHERE id=@id";

                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@nombre", txtEmpleado.Text);
                cmd.Parameters.AddWithValue("@horas", txtHoras.Text);
                cmd.Parameters.AddWithValue("@tarifa", txtTarifa.Text);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Registro actualizado");
            CargarDatos();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dvgEmpleados.CurrentRow == null) return;

            int id = Convert.ToInt32(dvgEmpleados.CurrentRow.Cells["id"].Value);

            DialogResult res = MessageBox.Show(
                "¿Eliminar este registro?",
                "Confirmar",
                MessageBoxButtons.YesNo
            );

            if (res == DialogResult.Yes)
            {
                string conexion = "server=localhost;database=pagos_nueva;user=usuario1;password=1234;";

                using (MySqlConnection con = new MySqlConnection(conexion))
                {
                    con.Open();

                    string query = "DELETE FROM empleados WHERE id=@id";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Registro eliminado");
                CargarDatos();
            }
        }
        private void dvgEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}

