using Menu_completo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuProgramas
{
 
    public partial class FormLogin : Form
    { 
        public FormLogin()
        {
            InitializeComponent();
        }
        private int intentos = 0;

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            this.AutoScaleMode = AutoScaleMode.Dpi;
            string user = txtUser.Text.Trim();
            string pass = txtPassword.Text;
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                lblError.Text = "Ingresa usuario y contraseña.";
                return;
            }
            if (user == "admin" && pass == "1234")
            {
                intentos = 0;
                lblError.Text = "";
                btnIngresar.Enabled = false;
                btnCancelar.Enabled = false;
                progressBar1.Value = 0;
                timer1.Start();

            }
            else
            {
                intentos++;
                lblError.Text = $"Credenciales incorrectas. Intento {intentos}/3";
                txtPassword.Clear();
                if (intentos >= 3) BloquearBoton();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 5;
            lblPorcentaje.Text = progressBar1.Value + "%";

            if (progressBar1.Value >= 100)
            {
                timer1.Stop();

                MenuPrin menu = new MenuPrin();
                menu.FormClosed += (s, args) =>
                {
                    this.Show();
                    ResetLogin(); 
                };
                menu.Show();
                this.Hide();
            }
        }
        private async void BloquearBoton()
        {
            btnIngresar.Enabled = false;

            for (int i = 10; i > 0; i--)
            {
                lblError.Text = $"Bloqueado {i}s...";
                await Task.Delay(1000);
            }

            intentos = 0;
            btnIngresar.Enabled = true;
            lblError.Text = "";
        }

        private void chkMostrar_CheckedChanged(object sender, EventArgs e)
        {
              if (chkMostrar.Checked)
    {
                txtPassword.PasswordChar = '\0'; // mostrar
    }
    else
    {
                txtPassword.PasswordChar = '*'; // ocultar
    }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show(
        "¿Desea salir?",
        "Confirmar",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    );

            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void progressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ResetLogin()
        {
            txtUser.Clear();
            txtPassword.Clear();
            lblError.Text = "";
            lblPorcentaje.Text = "";
            progressBar1.Value = 0;

            btnIngresar.Enabled = true;
            btnCancelar.Enabled = true;

            txtUser.Focus();
        }
    }
}
