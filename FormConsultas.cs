using MySqlConnector;
using System;
using System.Data;
using System.Windows.Forms;

namespace Menu_completo
{
    public partial class FormConsultas : Form
    {
        public FormConsultas()
          

        {

            InitializeComponent();

            cboPrograma.Items.Add("Pago Empleados");
            cboPrograma.Items.Add("Escuela");
            cboPrograma.Items.Add("Telas");
            cboPrograma.Items.Add("Pensión1");
            cboPrograma.Items.Add("Formularios");

            cboPrograma.SelectedIndexChanged += cboPrograma_SelectedIndexChanged;
            cboPrograma.SelectedIndex = 0; // default

            CargarDatos();
        }

        // ==============================
        // CONFIGURACIÓN DINÁMICA
        // ==============================
        private (string conexion, string tabla) ObtenerConfig()
        {
            string baseDatos = "";
            string tabla = "";

            switch (cboPrograma.SelectedItem.ToString())
            {
                case "Pago Empleados":
                    baseDatos="pagos_nueva";
                    tabla = "empleados";
                    break;

                case "Escuela":
                    baseDatos = "escuela";
                    tabla = "pensiones";
                    break;

                case "Telas":
                    baseDatos = "TelasDeOtono";
                    tabla = "ventas";
                    break;

                case "Pensión1":
                    baseDatos = "EscuelaDB";
                    tabla = "alumnos";
                    break;

                case "Formularios":
                    baseDatos = "jackers";
                    tabla = "tbl_programa1";
                    break;
            }

            string conexion = $"Server=localhost;Database={baseDatos};User ID=miusuario;Password=MiPassword123;";
            return (conexion, tabla);
        }

        // ==============================
        // CARGAR DATOS
        // ==============================
        private void CargarDatos()
        {
            try
            {
                var config = ObtenerConfig();

                using (MySqlConnection conn = new MySqlConnection(config.conexion))
                {
                    conn.Open();

                    string query = $"SELECT * FROM {config.tabla}";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable tabla = new DataTable();
                    adapter.Fill(tabla);

                    dgvDatos.DataSource = tabla;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // ==============================
        // BUSCAR
        // ==============================
        private void Buscar(string texto)
        {
            try
            {
                var config = ObtenerConfig();

                using (MySqlConnection conn = new MySqlConnection(config.conexion))
                {
                    conn.Open();

                    string query = $"SELECT * FROM {config.tabla} WHERE nombre LIKE @texto";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@texto", "%" + texto + "%");

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable tabla = new DataTable();
                    adapter.Fill(tabla);

                    dgvDatos.DataSource = tabla;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ==============================
        // EVENTOS
        // ==============================
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar(txtBuscar.Text);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void cboPrograma_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void panelBackground_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
