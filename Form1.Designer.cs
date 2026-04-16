namespace Menu_completo
{
    partial class MenuPrin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.BtnProgramas = new FontAwesome.Sharp.IconButton();
            this.submenu = new System.Windows.Forms.Panel();
            this.BtnPensionPriv = new FontAwesome.Sharp.IconButton();
            this.BtnTelas = new FontAwesome.Sharp.IconButton();
            this.BtnFormularios = new FontAwesome.Sharp.IconButton();
            this.BtnPagoProg = new FontAwesome.Sharp.IconButton();
            this.BtnPensionC = new FontAwesome.Sharp.IconButton();
            this.BtnConsultas = new FontAwesome.Sharp.IconButton();
            this.BtnAyuda = new FontAwesome.Sharp.IconButton();
            this.submenuAyuda = new System.Windows.Forms.Panel();
            this.BtnManual = new FontAwesome.Sharp.IconButton();
            this.BtnAcercaDe = new FontAwesome.Sharp.IconButton();
            this.BtnSalir = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.BtnMenu = new FontAwesome.Sharp.IconPictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.BtnCerrar = new FontAwesome.Sharp.IconButton();
            this.BtnHogar = new FontAwesome.Sharp.IconPictureBox();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.panelMenu.SuspendLayout();
            this.submenu.SuspendLayout();
            this.submenuAyuda.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMenu)).BeginInit();
            this.panelDesktop.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnHogar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelMenu.Controls.Add(this.BtnProgramas);
            this.panelMenu.Controls.Add(this.submenu);
            this.panelMenu.Controls.Add(this.BtnConsultas);
            this.panelMenu.Controls.Add(this.BtnAyuda);
            this.panelMenu.Controls.Add(this.submenuAyuda);
            this.panelMenu.Controls.Add(this.BtnSalir);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 71);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(293, 483);
            this.panelMenu.TabIndex = 0;
            // 
            // BtnProgramas
            // 
            this.BtnProgramas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnProgramas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnProgramas.FlatAppearance.BorderSize = 0;
            this.BtnProgramas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProgramas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnProgramas.IconChar = FontAwesome.Sharp.IconChar.Computer;
            this.BtnProgramas.IconColor = System.Drawing.Color.White;
            this.BtnProgramas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnProgramas.IconSize = 32;
            this.BtnProgramas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProgramas.Location = new System.Drawing.Point(0, 514);
            this.BtnProgramas.Margin = new System.Windows.Forms.Padding(4);
            this.BtnProgramas.Name = "BtnProgramas";
            this.BtnProgramas.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.BtnProgramas.Size = new System.Drawing.Size(293, 74);
            this.BtnProgramas.TabIndex = 1;
            this.BtnProgramas.Text = "Programas";
            this.BtnProgramas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProgramas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnProgramas.UseVisualStyleBackColor = true;
            this.BtnProgramas.Click += new System.EventHandler(this.BtnProgramas_Click);
            // 
            // submenu
            // 
            this.submenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.submenu.Controls.Add(this.BtnPensionPriv);
            this.submenu.Controls.Add(this.BtnTelas);
            this.submenu.Controls.Add(this.BtnFormularios);
            this.submenu.Controls.Add(this.BtnPagoProg);
            this.submenu.Controls.Add(this.BtnPensionC);
            this.submenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.submenu.Location = new System.Drawing.Point(0, 268);
            this.submenu.Margin = new System.Windows.Forms.Padding(4);
            this.submenu.Name = "submenu";
            this.submenu.Size = new System.Drawing.Size(293, 246);
            this.submenu.TabIndex = 0;
            this.submenu.Visible = false;
            // 
            // BtnPensionPriv
            // 
            this.BtnPensionPriv.BackColor = System.Drawing.Color.Chartreuse;
            this.BtnPensionPriv.FlatAppearance.BorderSize = 0;
            this.BtnPensionPriv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPensionPriv.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnPensionPriv.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.BtnPensionPriv.IconColor = System.Drawing.Color.Black;
            this.BtnPensionPriv.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnPensionPriv.IconSize = 20;
            this.BtnPensionPriv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPensionPriv.Location = new System.Drawing.Point(35, 63);
            this.BtnPensionPriv.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPensionPriv.Name = "BtnPensionPriv";
            this.BtnPensionPriv.Size = new System.Drawing.Size(192, 37);
            this.BtnPensionPriv.TabIndex = 1;
            this.BtnPensionPriv.Text = "Pension Privada";
            this.BtnPensionPriv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPensionPriv.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnPensionPriv.UseVisualStyleBackColor = false;
            this.BtnPensionPriv.Click += new System.EventHandler(this.BtnPensionPriv_Click);
            // 
            // BtnTelas
            // 
            this.BtnTelas.BackColor = System.Drawing.Color.Chartreuse;
            this.BtnTelas.FlatAppearance.BorderSize = 0;
            this.BtnTelas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTelas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnTelas.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.BtnTelas.IconColor = System.Drawing.Color.Black;
            this.BtnTelas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnTelas.IconSize = 20;
            this.BtnTelas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTelas.Location = new System.Drawing.Point(35, 151);
            this.BtnTelas.Margin = new System.Windows.Forms.Padding(4);
            this.BtnTelas.Name = "BtnTelas";
            this.BtnTelas.Size = new System.Drawing.Size(192, 37);
            this.BtnTelas.TabIndex = 3;
            this.BtnTelas.Text = "Telas Java";
            this.BtnTelas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTelas.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnTelas.UseVisualStyleBackColor = false;
            this.BtnTelas.Click += new System.EventHandler(this.BtnTelas_Click);
            // 
            // BtnFormularios
            // 
            this.BtnFormularios.BackColor = System.Drawing.Color.Chartreuse;
            this.BtnFormularios.FlatAppearance.BorderSize = 0;
            this.BtnFormularios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFormularios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnFormularios.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.BtnFormularios.IconColor = System.Drawing.Color.Black;
            this.BtnFormularios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnFormularios.IconSize = 20;
            this.BtnFormularios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFormularios.Location = new System.Drawing.Point(35, 107);
            this.BtnFormularios.Margin = new System.Windows.Forms.Padding(4);
            this.BtnFormularios.Name = "BtnFormularios";
            this.BtnFormularios.Size = new System.Drawing.Size(192, 37);
            this.BtnFormularios.TabIndex = 2;
            this.BtnFormularios.Text = "Formularios";
            this.BtnFormularios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFormularios.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnFormularios.UseVisualStyleBackColor = false;
            this.BtnFormularios.Click += new System.EventHandler(this.BtnFormularios_Click);
            // 
            // BtnPagoProg
            // 
            this.BtnPagoProg.BackColor = System.Drawing.Color.Chartreuse;
            this.BtnPagoProg.FlatAppearance.BorderSize = 0;
            this.BtnPagoProg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPagoProg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnPagoProg.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.BtnPagoProg.IconColor = System.Drawing.Color.Black;
            this.BtnPagoProg.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnPagoProg.IconSize = 20;
            this.BtnPagoProg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPagoProg.Location = new System.Drawing.Point(35, 18);
            this.BtnPagoProg.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPagoProg.Name = "BtnPagoProg";
            this.BtnPagoProg.Size = new System.Drawing.Size(192, 37);
            this.BtnPagoProg.TabIndex = 0;
            this.BtnPagoProg.Text = "Pago Empleados";
            this.BtnPagoProg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPagoProg.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnPagoProg.UseVisualStyleBackColor = false;
            // 
            // BtnPensionC
            // 
            this.BtnPensionC.BackColor = System.Drawing.Color.Chartreuse;
            this.BtnPensionC.FlatAppearance.BorderSize = 0;
            this.BtnPensionC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPensionC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnPensionC.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.BtnPensionC.IconColor = System.Drawing.Color.Black;
            this.BtnPensionC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnPensionC.IconSize = 20;
            this.BtnPensionC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPensionC.Location = new System.Drawing.Point(35, 196);
            this.BtnPensionC.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPensionC.Name = "BtnPensionC";
            this.BtnPensionC.Size = new System.Drawing.Size(192, 37);
            this.BtnPensionC.TabIndex = 4;
            this.BtnPensionC.Text = "Pension C#";
            this.BtnPensionC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPensionC.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnPensionC.UseVisualStyleBackColor = false;
            this.BtnPensionC.Click += new System.EventHandler(this.BtnPensionC_Click);
            // 
            // BtnConsultas
            // 
            this.BtnConsultas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnConsultas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnConsultas.FlatAppearance.BorderSize = 0;
            this.BtnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnConsultas.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.BtnConsultas.IconColor = System.Drawing.Color.White;
            this.BtnConsultas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnConsultas.IconSize = 32;
            this.BtnConsultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsultas.Location = new System.Drawing.Point(0, 194);
            this.BtnConsultas.Margin = new System.Windows.Forms.Padding(4);
            this.BtnConsultas.Name = "BtnConsultas";
            this.BtnConsultas.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.BtnConsultas.Size = new System.Drawing.Size(293, 74);
            this.BtnConsultas.TabIndex = 3;
            this.BtnConsultas.Text = "Consultas";
            this.BtnConsultas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsultas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConsultas.UseVisualStyleBackColor = true;
            // 
            // BtnAyuda
            // 
            this.BtnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnAyuda.FlatAppearance.BorderSize = 0;
            this.BtnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAyuda.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnAyuda.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.BtnAyuda.IconColor = System.Drawing.Color.White;
            this.BtnAyuda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAyuda.IconSize = 32;
            this.BtnAyuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAyuda.Location = new System.Drawing.Point(0, 223);
            this.BtnAyuda.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAyuda.Name = "BtnAyuda";
            this.BtnAyuda.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.BtnAyuda.Size = new System.Drawing.Size(293, 74);
            this.BtnAyuda.TabIndex = 2;
            this.BtnAyuda.Text = "Ayuda";
            this.BtnAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAyuda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAyuda.UseVisualStyleBackColor = true;
            this.BtnAyuda.Click += new System.EventHandler(this.BtnAyuda_Click);
            // 
            // submenuAyuda
            // 
            this.submenuAyuda.BackColor = System.Drawing.Color.Lime;
            this.submenuAyuda.Controls.Add(this.BtnManual);
            this.submenuAyuda.Controls.Add(this.BtnAcercaDe);
            this.submenuAyuda.Dock = System.Windows.Forms.DockStyle.Top;
            this.submenuAyuda.Location = new System.Drawing.Point(0, 71);
            this.submenuAyuda.Margin = new System.Windows.Forms.Padding(4);
            this.submenuAyuda.Name = "submenuAyuda";
            this.submenuAyuda.Size = new System.Drawing.Size(293, 123);
            this.submenuAyuda.TabIndex = 2;
            // 
            // BtnManual
            // 
            this.BtnManual.BackColor = System.Drawing.Color.Indigo;
            this.BtnManual.FlatAppearance.BorderSize = 0;
            this.BtnManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnManual.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnManual.IconChar = FontAwesome.Sharp.IconChar.Bookmark;
            this.BtnManual.IconColor = System.Drawing.Color.White;
            this.BtnManual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnManual.IconSize = 20;
            this.BtnManual.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnManual.Location = new System.Drawing.Point(27, 68);
            this.BtnManual.Margin = new System.Windows.Forms.Padding(4);
            this.BtnManual.Name = "BtnManual";
            this.BtnManual.Size = new System.Drawing.Size(192, 37);
            this.BtnManual.TabIndex = 2;
            this.BtnManual.Text = "Manual de Usuario";
            this.BtnManual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnManual.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnManual.UseVisualStyleBackColor = false;
            this.BtnManual.Click += new System.EventHandler(this.BtnManual_Click_1);
            // 
            // BtnAcercaDe
            // 
            this.BtnAcercaDe.BackColor = System.Drawing.Color.Indigo;
            this.BtnAcercaDe.FlatAppearance.BorderSize = 0;
            this.BtnAcercaDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAcercaDe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAcercaDe.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.BtnAcercaDe.IconColor = System.Drawing.Color.White;
            this.BtnAcercaDe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAcercaDe.IconSize = 20;
            this.BtnAcercaDe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAcercaDe.Location = new System.Drawing.Point(27, 17);
            this.BtnAcercaDe.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAcercaDe.Name = "BtnAcercaDe";
            this.BtnAcercaDe.Size = new System.Drawing.Size(192, 37);
            this.BtnAcercaDe.TabIndex = 1;
            this.BtnAcercaDe.Text = "Acerca de";
            this.BtnAcercaDe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAcercaDe.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnAcercaDe.UseVisualStyleBackColor = false;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnSalir.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.BtnSalir.IconColor = System.Drawing.Color.White;
            this.BtnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSalir.IconSize = 32;
            this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalir.Location = new System.Drawing.Point(0, 304);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.BtnSalir.Size = new System.Drawing.Size(293, 74);
            this.BtnSalir.TabIndex = 2;
            this.BtnSalir.Text = "Salida";
            this.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.BtnMenu);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(293, 71);
            this.panelLogo.TabIndex = 0;
            // 
            // BtnMenu
            // 
            this.BtnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.BtnMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnMenu.IconChar = FontAwesome.Sharp.IconChar.BarsStaggered;
            this.BtnMenu.IconColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnMenu.IconSize = 39;
            this.BtnMenu.Location = new System.Drawing.Point(16, 15);
            this.BtnMenu.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(43, 39);
            this.BtnMenu.TabIndex = 0;
            this.BtnMenu.TabStop = false;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.DimGray;
            this.panelDesktop.Controls.Add(this.lblBienvenida);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(293, 71);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(4);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(774, 483);
            this.panelDesktop.TabIndex = 1;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.BackColor = System.Drawing.Color.Transparent;
            this.lblBienvenida.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblBienvenida.Location = new System.Drawing.Point(325, 71);
            this.lblBienvenida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(44, 16);
            this.lblBienvenida.TabIndex = 3;
            this.lblBienvenida.Text = "label1";
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelSuperior.Controls.Add(this.BtnCerrar);
            this.panelSuperior.Controls.Add(this.BtnHogar);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Margin = new System.Windows.Forms.Padding(4);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1067, 71);
            this.panelSuperior.TabIndex = 0;
            this.panelSuperior.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSuperior_Paint);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCerrar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnCerrar.IconColor = System.Drawing.Color.Black;
            this.BtnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCerrar.Location = new System.Drawing.Point(924, 16);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(113, 28);
            this.BtnCerrar.TabIndex = 1;
            this.BtnCerrar.Text = "Cerrar sesión";
            this.BtnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnHogar
            // 
            this.BtnHogar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.BtnHogar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnHogar.IconChar = FontAwesome.Sharp.IconChar.House;
            this.BtnHogar.IconColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnHogar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnHogar.IconSize = 39;
            this.BtnHogar.Location = new System.Drawing.Point(8, 15);
            this.BtnHogar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnHogar.Name = "BtnHogar";
            this.BtnHogar.Size = new System.Drawing.Size(43, 39);
            this.BtnHogar.TabIndex = 0;
            this.BtnHogar.TabStop = false;
            // 
            // MenuPrin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelSuperior);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuPrin";
            this.Text = "MenuPrincipal";
            this.panelMenu.ResumeLayout(false);
            this.submenu.ResumeLayout(false);
            this.submenuAyuda.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnMenu)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.panelSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnHogar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton BtnProgramas;
        private FontAwesome.Sharp.IconButton BtnSalir;
        private FontAwesome.Sharp.IconButton BtnAyuda;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconPictureBox BtnMenu;
        private System.Windows.Forms.Panel panelSuperior;
        private FontAwesome.Sharp.IconPictureBox BtnHogar;
        private System.Windows.Forms.Panel submenu;
        private FontAwesome.Sharp.IconButton BtnPensionC;
        private FontAwesome.Sharp.IconButton BtnTelas;
        private FontAwesome.Sharp.IconButton BtnFormularios;
        private FontAwesome.Sharp.IconButton BtnPensionPriv;
        private FontAwesome.Sharp.IconButton BtnPagoProg;
        private System.Windows.Forms.Panel submenuAyuda;
        private FontAwesome.Sharp.IconButton BtnManual;
        private FontAwesome.Sharp.IconButton BtnAcercaDe;
        private FontAwesome.Sharp.IconButton BtnCerrar;
        private System.Windows.Forms.Label lblBienvenida;
        private FontAwesome.Sharp.IconButton BtnConsultas;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
    }
}

