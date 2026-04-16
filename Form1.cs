
using FontAwesome.Sharp;
using MenuProgramas;
using Pago_empleado2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//using System.Windows.Documents;
using System.Windows.Forms;
using MySqlConnector;
using System.Web.Caching;
using PensiónEstudiantes;
using System.Net;



namespace Menu_completo
{
    public partial class MenuPrin : Form
    {
        private Label lblEstadoBD;
        public MenuPrin()
        {
            InitializeComponent();

            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es-ES");

            //Para iniciar con el menú contraído
            panelMenu.Width = 60;
            menuExpandido = false;
            OcultarTextoBotones();

            //Borde izquierdo del botón activo
            leftBorderButton = new Panel();
            leftBorderButton.Size = new Size(7, 60);
            leftBorderButton.Visible = false;
            panelMenu.Controls.Add(leftBorderButton);
            leftBorderButton.BringToFront();

            BtnMenu.Click += BtnMenu_Click;
            InicializarTimer();

            //Panel panelSuperior = new Panel();

            BtnHogar.Click += BtnHogar_Click;

            submenu.Visible = false;
            submenu.BackColor = System.Drawing.Color.FromArgb(50, 0, 70);

            BtnPagoProg.Click += BtnPagoProg_Click;

            BtnPensionPriv.Click += BtnPensionPriv_Click;

            submenuAyuda.Visible = false;

            BtnAcercaDe.Click += BtnAcercaDe_Click;

            BtnConsultas.Click += BtnConsultas_Click;

            CargarBienvenida("Admin");

            // Barra de estado
            StatusStrip status = new StatusStrip();
            lblEstadoBD = new Label();

            ToolStripControlHost host = new ToolStripControlHost(lblEstadoBD);
            status.Items.Add(host);

            this.Controls.Add(status);



            relojTimer = new System.Windows.Forms.Timer();

        }

        private IconButton currentButton;
        private Panel leftBorderButton;
        private bool menuExpandido = true;
        private System.Windows.Forms.Timer relojTimer;
        

        //Codigo para activar los botones del menu

        private void ActivarBoton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DesactivarBoton();
                //Botón
                currentButton = (IconButton)senderBtn;
                currentButton.BackColor = System.Drawing.Color.FromArgb(31, 30, 68);
                currentButton.ForeColor = color;
                currentButton.TextAlign = ContentAlignment.MiddleCenter;
                currentButton.IconColor = color;
                currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentButton.ImageAlign = ContentAlignment.MiddleRight;

                //Panel izquierdo
                leftBorderButton.BackColor = color;
                leftBorderButton.Location = new Point(0, currentButton.Location.Y);
                leftBorderButton.Visible = true;
                leftBorderButton.BringToFront();

                //Boton Hogar
                BtnHogar.IconChar = currentButton.IconChar;
                BtnHogar.IconColor = color;
            }
        }

        //Método para desactivar el botón activo
        private void DesactivarBoton()
        {
            foreach (Control control in panelMenu.Controls)
            {
                if (control is IconButton btn)
                {
                    btn.BackColor = System.Drawing.Color.FromArgb(26, 25, 62);
                    btn.ForeColor = System.Drawing.Color.White;
                    btn.IconColor = System.Drawing.Color.White;
                    btn.TextAlign = ContentAlignment.MiddleLeft;
                    btn.TextImageRelation = TextImageRelation.ImageBeforeText;
                    btn.ImageAlign = ContentAlignment.MiddleLeft;
                }
            }
        }

        //Eventos de los botones del menú individuales
        private void BtnProgramas_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, Color.Pink);

            if (formularioActivo != null)
            {
                formularioActivo.Close();
                formularioActivo = null;
            }

            MostrarSubMenu(submenu);
        }

        private void BtnConsultas_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, Color.Gray);
            AbrirFormularioEnPanel(new FormConsultas());
        }

        private void BtnAyuda_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, Color.Gold);

            if (formularioActivo != null)
            {
                formularioActivo.Close();
                formularioActivo = null;
            }

            MostrarSubMenu(submenuAyuda);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, System.Drawing.Color.Coral);
            DialogResult resultado = MessageBox.Show(
        "¿Estás seguro de que deseas salir?",
        "Confirmar salida",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
        
        //Para el boton del menu interactivo. Permite contraer y expandir el menú
        //al hacer clic en el botón del menú
        private void BtnMenu_Click(object sender, EventArgs e)
        {
            if (panelMenu.Width == 220)
            {
                panelMenu.Width = 60;
                OcultarTextoBotones();
            }
            else
            {
                panelMenu.Width = 220;
                MostrarTextoBotones();
            }
            if (currentButton != null)
            {
                ActivarBoton(currentButton, currentButton.IconColor);
            }
        }

        private void OcultarTextoBotones()
        {
            foreach (Control control in panelMenu.Controls)
            {
                if (control is IconButton btn)
                {
                    btn.Text = "";
                    btn.ImageAlign = ContentAlignment.MiddleCenter;
                }
            }
        }

        private void MostrarTextoBotones()
        {
            BtnProgramas.Text = "Programas";
            BtnConsultas.Text = "Consultas";
            BtnAyuda.Text = "Ayuda";
            BtnSalir.Text = "Salir";

            foreach (Control control in panelMenu.Controls)
            {
                if (control is IconButton btn)
                {
                    btn.ImageAlign = ContentAlignment.MiddleLeft;
                    btn.TextImageRelation = TextImageRelation.ImageBeforeText;
                }
            }
        }

        //Timer para boton menu
        private System.Windows.Forms.Timer menuTimer = new System.Windows.Forms.Timer();

        private void InicializarTimer()
        {
            menuTimer.Interval = 10;
            menuTimer.Tick += MenuTimer_Tick;
        }
        private void MenuTimer_Tick(object sender, EventArgs e)
        {//Reloj para animar el menú al expandirlo o contraerlo

            if (menuExpandido)
            {
                panelMenu.Width -= 10;
                if (panelMenu.Width <= 60)
                {
                    menuTimer.Stop();
                    menuExpandido = false;
                    OcultarTextoBotones();
                }
            }
            else
            {
                panelMenu.Width += 10;
                if (panelMenu.Width >= 220)
                {
                    menuTimer.Stop();
                    menuExpandido = true;
                    MostrarTextoBotones();
                }
            }
        }

        private void BtnHogar_Click(object sender, EventArgs e)
        {//Icono de casa, vuelve al inicio, cierra el formulario activo y muestra el mensaje de bienvenida
            DesactivarBoton();
            leftBorderButton.Visible = false;

            BtnHogar.IconChar = IconChar.Home;
            BtnHogar.IconColor = Color.Red;

            if (formularioActivo != null)
            {
                formularioActivo.Close();
                formularioActivo.Dispose();
                formularioActivo = null;
            }

            CargarBienvenida("Admin");
            OcultarSubMenus();
        }

        //Submenu de programas
        private void MostrarSubMenu(Panel submenu)
        {
            OcultarSubMenus();
            submenu.Visible = true;
            submenu.BringToFront();
        }

        private void OcultarSubMenus()
        {
            submenu.Visible = false;
            submenuAyuda.Visible = false;
        }

        //Submenu botones de los Programas
        //Programa C# para el pago de empleados
        private void BtnPagoProg_Click(object sender, EventArgs e)//Boton para abrir el programa de pago de empleados
        {
            AbrirFormularioEnPanel(new FormPago());   //Redirecciona al formulario de pago de empleados (FormPago.cs)
            OcultarSubMenus();  //Oculta el submenu después de abrir el formulario
        }
        //Programa Java para la pension privada
        private void BtnPensionPriv_Click(object sender, EventArgs e) //Boton para abrir el programa de pension privada
        {
            //Proceso para abrir un programa Java desde C#
                ProcessStartInfo psi = new ProcessStartInfo();  //Información para iniciar el proceso
            psi.FileName = "javaw"; //  evita abrir el CMD
            //Argumentos para ejecutar el programa Java, especificando la ruta del archivo .jar
            psi.Arguments = "-jar \"C:\\Users\\jachr\\Documents\\NetBeansProjects\\pPensionPrivada\\dist\\pPensionPrivada.jar\"";
            psi.UseShellExecute = false;  //Indica que no se debe usar el shell para iniciar el proceso, lo que permite redirigir la salida y evitar la ventana del CMD
            //Inicia el proceso con la información especificada, lo que ejecuta el programa Java
            Process.Start(psi);
            OcultarSubMenus();
        }
        //Programa Java para los formularios
        private void BtnFormularios_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "javaw"; // Evita abrir el CMD
            //Argumentos para ejecutar el programa Java, especificando la ruta del archivo .jar (la dirección del proyecto)
            psi.Arguments = "-jar \"C:\\Users\\jachr\\Downloads\\pFormularios\\pFormularios\\dist\\pFormularios.jar\"";
            psi.UseShellExecute = false;

            Process.Start(psi);
            OcultarSubMenus();
        }

        //Botones para abrir los programas Java (Naiby, Telas) y C#(Pension privada, Alexander)
        private void BtnTelas_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "javaw";

            psi.Arguments = "-cp \"C:\\Users\\jachr\\Documents\\NetBeansProjects\\telasdeotonito\\bumbleSort\\dist\\bumbleSort.jar;C:\\Users\\jachr\\Documents\\NetBeansProjects\\telasdeotonito\\bumbleSort\\dist\\mysql-connector-j-9.5.0.jar\" telasdeOtono.frmTelas";

            psi.UseShellExecute = false;

            Process.Start(psi);
        }
        
        private void BtnPensionC_Click(object sender, EventArgs e)
        {
            PensiónEstudiantes.Form1 frm = new PensiónEstudiantes.Form1();
            frm.Show();

        }

        //Submenu Ayuda - Botón Acerca de
        private void BtnAcercaDe_Click(object sender, EventArgs e)
        {
            FormAcercade frm = new FormAcercade();
            frm.ShowDialog();
        }
        //Variable para almacenar el formulario activo en el panel, hace que aparezca
        //el Formulario dentro del panel en lugar de abrirlo como una ventana separada
        private Form formularioActivo = null;
       
        

        private void AbrirFormularioEnPanel(Form formHijo) //Abre un formulario dentro del panelDesktop,
                                                           //cerrando el formulario activo si existe
        {
            if (formularioActivo != null) //Si ya hay un formulario activo, lo cierra antes de abrir el nuevo
            {
                formularioActivo.Close();
                formularioActivo.Dispose();
            }

            formularioActivo = formHijo; //Asigna el nuevo formulario como el formulario activo

            formHijo.TopLevel = false;  //Indica que el formulario no es un formulario de nivel superior,
                                        //lo que permite que se muestre dentro del panel
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;

            panelDesktop.Controls.Clear();
            panelDesktop.Controls.Add(formHijo);

            //Trae el formulario al frente y lo muestra
            formHijo.BringToFront();
            formHijo.Show();
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {
             //No sirve, pero no lo borres porque deja de funcionar el menu
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)  //Boton para cerrar sesión, vuelve a la pantalla de inicio de sesión (FormLogin.cs)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Deseas cerrar sesión?",
                "Cerrar sesión",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                this.Close(); 
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            //De nuevo, no sirve pero si se borra deja de funcionar
        }

        private void CargarBienvenida(string usuario) //El texto de inicio
        {
            panelDesktop.Controls.Clear();

            lblBienvenida = new Label();
            lblBienvenida.Dock = DockStyle.Fill;
            lblBienvenida.TextAlign = ContentAlignment.MiddleCenter;
            lblBienvenida.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblBienvenida.ForeColor = Color.White;

            panelDesktop.Controls.Add(lblBienvenida);

            if (relojTimer == null)
            {
                relojTimer = new System.Windows.Forms.Timer();
                relojTimer.Interval = 1000;

                relojTimer.Tick += (s, e) =>
                {
                    lblBienvenida.Text = $"Bienvenido/a, {usuario}\n\n" +
                                         $"Fecha: {DateTime.Now.ToLongDateString()}\n" +
                                         $"Hora: {DateTime.Now.ToLongTimeString()}";
                };
            }

            relojTimer.Start();
        }

        private void ActualizarHora(object sender, EventArgs e)
        {
            string usuario = lblBienvenida.Tag?.ToString() ?? "Admin";

            lblBienvenida.Text = $"Bienvenido/a, {usuario}\n" +
                                 $"Fecha: {DateTime.Now.ToLongDateString()}\n" +
                                 $"Hora: {DateTime.Now.ToLongTimeString()}";
        }

      

        private void panelSuperior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnManual_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://drive.google.com/file/d/19e-e8UPrPEttRb6YDxgSKygobo2S1-DM/view");
        }
    }
}
