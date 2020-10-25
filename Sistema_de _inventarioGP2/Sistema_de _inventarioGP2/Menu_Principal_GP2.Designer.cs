namespace Sistema_de__inventarioGP2
{
    partial class Menu_Principal_GP2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Principal_GP2));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.panellateral = new System.Windows.Forms.Panel();
            this.bgastos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sidepanel = new System.Windows.Forms.Panel();
            this.btservicios = new System.Windows.Forms.Button();
            this.lblprivilegios = new System.Windows.Forms.Label();
            this.btpanelajuste = new System.Windows.Forms.Button();
            this.lblnombreusuario = new System.Windows.Forms.Label();
            this.btgestionempleados = new System.Windows.Forms.Button();
            this.lblcargo = new System.Windows.Forms.Label();
            this.Btclientes = new System.Windows.Forms.Button();
            this.Btproveedores = new System.Windows.Forms.Button();
            this.Btinventario = new System.Windows.Forms.Button();
            this.Btventas = new System.Windows.Forms.Button();
            this.Btreportes = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tmaparecermenu = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panel_meniu_principal = new System.Windows.Forms.Panel();
            this.cuPanelDeAjuste1 = new Sistema_de__inventarioGP2.CUPanelDeAjuste();
            this.cUgastos1 = new Sistema_de__inventarioGP2.CUgastos();
            this.cuReportes1 = new Sistema_de__inventarioGP2.CUReportes();
            this.cUgestion_empleados1 = new Sistema_de__inventarioGP2.CUgestion_empleados();
            this.cuServicios1 = new Sistema_de__inventarioGP2.CUServicios();
            this.cUclientes2 = new Sistema_de__inventarioGP2.CUclientes();
            this.cUinventario2 = new Sistema_de__inventarioGP2.CUinventario();
            this.cUfacturacion1 = new Sistema_de__inventarioGP2.CUfacturacion();
            this.cUproveedores2 = new Sistema_de__inventarioGP2.CUproveedores();
            this.lblnotificacion = new System.Windows.Forms.Label();
            this.lblhora = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panellateral.SuspendLayout();
            this.panel_meniu_principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(20)))), ((int)(((byte)(235)))));
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.cerrarSesionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(1193, 29);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(150, 25);
            this.toolStripMenuItem1.Text = "Cerrar ventanas";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrarSesionToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(117, 25);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "En linea";
            // 
            // panellateral
            // 
            this.panellateral.AutoScroll = true;
            this.panellateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(33)))));
            this.panellateral.Controls.Add(this.bgastos);
            this.panellateral.Controls.Add(this.button1);
            this.panellateral.Controls.Add(this.sidepanel);
            this.panellateral.Controls.Add(this.btservicios);
            this.panellateral.Controls.Add(this.lblprivilegios);
            this.panellateral.Controls.Add(this.btpanelajuste);
            this.panellateral.Controls.Add(this.lblnombreusuario);
            this.panellateral.Controls.Add(this.btgestionempleados);
            this.panellateral.Controls.Add(this.lblcargo);
            this.panellateral.Controls.Add(this.Btclientes);
            this.panellateral.Controls.Add(this.Btproveedores);
            this.panellateral.Controls.Add(this.Btinventario);
            this.panellateral.Controls.Add(this.Btventas);
            this.panellateral.Controls.Add(this.Btreportes);
            this.panellateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panellateral.Location = new System.Drawing.Point(0, 29);
            this.panellateral.Name = "panellateral";
            this.panellateral.Size = new System.Drawing.Size(190, 671);
            this.panellateral.TabIndex = 16;
            // 
            // bgastos
            // 
            this.bgastos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bgastos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(33)))));
            this.bgastos.FlatAppearance.BorderSize = 0;
            this.bgastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bgastos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bgastos.ForeColor = System.Drawing.Color.White;
            this.bgastos.Image = global::Sistema_de__inventarioGP2.Properties.Resources.pagos;
            this.bgastos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bgastos.Location = new System.Drawing.Point(2, 481);
            this.bgastos.Name = "bgastos";
            this.bgastos.Size = new System.Drawing.Size(186, 63);
            this.bgastos.TabIndex = 23;
            this.bgastos.Text = "Gastos";
            this.bgastos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bgastos.UseVisualStyleBackColor = false;
            this.bgastos.Click += new System.EventHandler(this.bgastos_Click);
            this.bgastos.MouseLeave += new System.EventHandler(this.bgastos_MouseLeave);
            this.bgastos.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bgastos_MouseMove);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 637);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.White;
            this.sidepanel.Location = new System.Drawing.Point(3, 3);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(14, 63);
            this.sidepanel.TabIndex = 17;
            this.sidepanel.Visible = false;
            // 
            // btservicios
            // 
            this.btservicios.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btservicios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(33)))));
            this.btservicios.FlatAppearance.BorderSize = 0;
            this.btservicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btservicios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btservicios.ForeColor = System.Drawing.Color.White;
            this.btservicios.Image = global::Sistema_de__inventarioGP2.Properties.Resources.pagos;
            this.btservicios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btservicios.Location = new System.Drawing.Point(2, 343);
            this.btservicios.Name = "btservicios";
            this.btservicios.Size = new System.Drawing.Size(186, 63);
            this.btservicios.TabIndex = 21;
            this.btservicios.Text = "Servicios";
            this.btservicios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btservicios.UseVisualStyleBackColor = false;
            this.btservicios.Click += new System.EventHandler(this.btservicios_Click);
            this.btservicios.MouseLeave += new System.EventHandler(this.btservicios_MouseLeave);
            this.btservicios.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btservicios_MouseMove);
            // 
            // lblprivilegios
            // 
            this.lblprivilegios.AutoSize = true;
            this.lblprivilegios.BackColor = System.Drawing.Color.Transparent;
            this.lblprivilegios.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprivilegios.ForeColor = System.Drawing.Color.Black;
            this.lblprivilegios.Location = new System.Drawing.Point(7, 582);
            this.lblprivilegios.Name = "lblprivilegios";
            this.lblprivilegios.Size = new System.Drawing.Size(54, 18);
            this.lblprivilegios.TabIndex = 7;
            this.lblprivilegios.Text = "label5";
            // 
            // btpanelajuste
            // 
            this.btpanelajuste.FlatAppearance.BorderSize = 0;
            this.btpanelajuste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btpanelajuste.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btpanelajuste.ForeColor = System.Drawing.Color.White;
            this.btpanelajuste.Image = ((System.Drawing.Image)(resources.GetObject("btpanelajuste.Image")));
            this.btpanelajuste.Location = new System.Drawing.Point(124, 616);
            this.btpanelajuste.Name = "btpanelajuste";
            this.btpanelajuste.Size = new System.Drawing.Size(60, 52);
            this.btpanelajuste.TabIndex = 20;
            this.btpanelajuste.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btpanelajuste.UseVisualStyleBackColor = true;
            this.btpanelajuste.Click += new System.EventHandler(this.btpanelajuste_Click);
            // 
            // lblnombreusuario
            // 
            this.lblnombreusuario.AutoSize = true;
            this.lblnombreusuario.BackColor = System.Drawing.Color.Transparent;
            this.lblnombreusuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombreusuario.ForeColor = System.Drawing.Color.Black;
            this.lblnombreusuario.Location = new System.Drawing.Point(7, 549);
            this.lblnombreusuario.Name = "lblnombreusuario";
            this.lblnombreusuario.Size = new System.Drawing.Size(54, 18);
            this.lblnombreusuario.TabIndex = 5;
            this.lblnombreusuario.Text = "label3";
            // 
            // btgestionempleados
            // 
            this.btgestionempleados.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btgestionempleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(33)))));
            this.btgestionempleados.FlatAppearance.BorderSize = 0;
            this.btgestionempleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btgestionempleados.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btgestionempleados.ForeColor = System.Drawing.Color.White;
            this.btgestionempleados.Image = global::Sistema_de__inventarioGP2.Properties.Resources.empleados;
            this.btgestionempleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btgestionempleados.Location = new System.Drawing.Point(2, 411);
            this.btgestionempleados.Name = "btgestionempleados";
            this.btgestionempleados.Size = new System.Drawing.Size(186, 63);
            this.btgestionempleados.TabIndex = 18;
            this.btgestionempleados.Text = "Gestion de Empleados";
            this.btgestionempleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btgestionempleados.UseVisualStyleBackColor = false;
            this.btgestionempleados.Click += new System.EventHandler(this.btgestionempleados_Click);
            this.btgestionempleados.MouseLeave += new System.EventHandler(this.bgestionempleados_MouseLeave);
            this.btgestionempleados.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bgestionempleados_MouseMove);
            // 
            // lblcargo
            // 
            this.lblcargo.AutoSize = true;
            this.lblcargo.BackColor = System.Drawing.Color.Transparent;
            this.lblcargo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcargo.ForeColor = System.Drawing.Color.Black;
            this.lblcargo.Location = new System.Drawing.Point(7, 615);
            this.lblcargo.Name = "lblcargo";
            this.lblcargo.Size = new System.Drawing.Size(54, 18);
            this.lblcargo.TabIndex = 6;
            this.lblcargo.Text = "label4";
            // 
            // Btclientes
            // 
            this.Btclientes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btclientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(33)))));
            this.Btclientes.FlatAppearance.BorderSize = 0;
            this.Btclientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btclientes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btclientes.ForeColor = System.Drawing.Color.White;
            this.Btclientes.Image = global::Sistema_de__inventarioGP2.Properties.Resources.clientes;
            this.Btclientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btclientes.Location = new System.Drawing.Point(2, 71);
            this.Btclientes.Name = "Btclientes";
            this.Btclientes.Size = new System.Drawing.Size(186, 63);
            this.Btclientes.TabIndex = 4;
            this.Btclientes.Text = "Clientes";
            this.Btclientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btclientes.UseVisualStyleBackColor = false;
            this.Btclientes.Click += new System.EventHandler(this.Btclientes_Click);
            this.Btclientes.MouseLeave += new System.EventHandler(this.Btclientes_MouseLeave);
            this.Btclientes.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btclientes_MouseMove);
            // 
            // Btproveedores
            // 
            this.Btproveedores.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btproveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(33)))));
            this.Btproveedores.FlatAppearance.BorderSize = 0;
            this.Btproveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btproveedores.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btproveedores.ForeColor = System.Drawing.Color.White;
            this.Btproveedores.Image = global::Sistema_de__inventarioGP2.Properties.Resources.compras;
            this.Btproveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btproveedores.Location = new System.Drawing.Point(2, 139);
            this.Btproveedores.Name = "Btproveedores";
            this.Btproveedores.Size = new System.Drawing.Size(186, 63);
            this.Btproveedores.TabIndex = 1;
            this.Btproveedores.Text = "Proveedores";
            this.Btproveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btproveedores.UseVisualStyleBackColor = false;
            this.Btproveedores.Click += new System.EventHandler(this.Btproveedores_Click);
            this.Btproveedores.MouseLeave += new System.EventHandler(this.Btproveedores_MouseLeave);
            this.Btproveedores.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btproveedores_MouseMove);
            // 
            // Btinventario
            // 
            this.Btinventario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btinventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(33)))));
            this.Btinventario.FlatAppearance.BorderSize = 0;
            this.Btinventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btinventario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btinventario.ForeColor = System.Drawing.Color.White;
            this.Btinventario.Image = global::Sistema_de__inventarioGP2.Properties.Resources.producto;
            this.Btinventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btinventario.Location = new System.Drawing.Point(2, 207);
            this.Btinventario.Name = "Btinventario";
            this.Btinventario.Size = new System.Drawing.Size(186, 63);
            this.Btinventario.TabIndex = 5;
            this.Btinventario.Text = "Inventario";
            this.Btinventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btinventario.UseVisualStyleBackColor = false;
            this.Btinventario.Click += new System.EventHandler(this.Btinventario_Click);
            this.Btinventario.MouseLeave += new System.EventHandler(this.Btinventario_MouseLeave);
            this.Btinventario.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btinventario_MouseMove);
            // 
            // Btventas
            // 
            this.Btventas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btventas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(33)))));
            this.Btventas.FlatAppearance.BorderSize = 0;
            this.Btventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btventas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btventas.ForeColor = System.Drawing.Color.White;
            this.Btventas.Image = global::Sistema_de__inventarioGP2.Properties.Resources.venta;
            this.Btventas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btventas.Location = new System.Drawing.Point(2, 3);
            this.Btventas.Name = "Btventas";
            this.Btventas.Size = new System.Drawing.Size(186, 63);
            this.Btventas.TabIndex = 0;
            this.Btventas.Text = "Ventas";
            this.Btventas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btventas.UseVisualStyleBackColor = false;
            this.Btventas.Click += new System.EventHandler(this.Btventas_Click);
            this.Btventas.MouseLeave += new System.EventHandler(this.Btfacturacion_MouseLeave);
            this.Btventas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btfacturacion_MouseMove);
            // 
            // Btreportes
            // 
            this.Btreportes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btreportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(33)))));
            this.Btreportes.FlatAppearance.BorderSize = 0;
            this.Btreportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btreportes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btreportes.ForeColor = System.Drawing.Color.White;
            this.Btreportes.Image = global::Sistema_de__inventarioGP2.Properties.Resources.reportes;
            this.Btreportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btreportes.Location = new System.Drawing.Point(2, 275);
            this.Btreportes.Name = "Btreportes";
            this.Btreportes.Size = new System.Drawing.Size(186, 63);
            this.Btreportes.TabIndex = 3;
            this.Btreportes.Text = "Reportes";
            this.Btreportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btreportes.UseVisualStyleBackColor = false;
            this.Btreportes.Click += new System.EventHandler(this.Btreportes_Click);
            this.Btreportes.MouseLeave += new System.EventHandler(this.Btreportes_MouseLeave);
            this.Btreportes.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btreportes_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tmaparecermenu
            // 
            this.tmaparecermenu.Interval = 50;
            this.tmaparecermenu.Tick += new System.EventHandler(this.tmaparecermenu_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(20)))), ((int)(((byte)(235)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 22);
            this.label2.TabIndex = 30;
            this.label2.Text = "DeilingSalon";
            // 
            // panel_meniu_principal
            // 
            this.panel_meniu_principal.BackgroundImage = global::Sistema_de__inventarioGP2.Properties.Resources.WhatsApp_Image_2019_08_28_at_9_561;
            this.panel_meniu_principal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_meniu_principal.Controls.Add(this.cuPanelDeAjuste1);
            this.panel_meniu_principal.Controls.Add(this.cUgastos1);
            this.panel_meniu_principal.Controls.Add(this.cuReportes1);
            this.panel_meniu_principal.Controls.Add(this.cUgestion_empleados1);
            this.panel_meniu_principal.Controls.Add(this.cuServicios1);
            this.panel_meniu_principal.Controls.Add(this.cUclientes2);
            this.panel_meniu_principal.Controls.Add(this.cUinventario2);
            this.panel_meniu_principal.Controls.Add(this.cUfacturacion1);
            this.panel_meniu_principal.Controls.Add(this.cUproveedores2);
            this.panel_meniu_principal.Controls.Add(this.lblnotificacion);
            this.panel_meniu_principal.Controls.Add(this.lblhora);
            this.panel_meniu_principal.Controls.Add(this.lblfecha);
            this.panel_meniu_principal.Controls.Add(this.pictureBox3);
            this.panel_meniu_principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_meniu_principal.ForeColor = System.Drawing.Color.Black;
            this.panel_meniu_principal.Location = new System.Drawing.Point(190, 29);
            this.panel_meniu_principal.Name = "panel_meniu_principal";
            this.panel_meniu_principal.Size = new System.Drawing.Size(1003, 671);
            this.panel_meniu_principal.TabIndex = 17;
            // 
            // cuPanelDeAjuste1
            // 
            this.cuPanelDeAjuste1.BackColor = System.Drawing.Color.Snow;
            this.cuPanelDeAjuste1.Location = new System.Drawing.Point(0, 1);
            this.cuPanelDeAjuste1.Name = "cuPanelDeAjuste1";
            this.cuPanelDeAjuste1.Size = new System.Drawing.Size(1000, 543);
            this.cuPanelDeAjuste1.TabIndex = 31;
            // 
            // cUgastos1
            // 
            this.cUgastos1.BackColor = System.Drawing.Color.Snow;
            this.cUgastos1.Location = new System.Drawing.Point(0, 0);
            this.cUgastos1.Name = "cUgastos1";
            this.cUgastos1.Size = new System.Drawing.Size(1003, 543);
            this.cUgastos1.TabIndex = 30;
            // 
            // cuReportes1
            // 
            this.cuReportes1.BackColor = System.Drawing.Color.Snow;
            this.cuReportes1.Location = new System.Drawing.Point(0, 1);
            this.cuReportes1.Name = "cuReportes1";
            this.cuReportes1.Size = new System.Drawing.Size(1003, 543);
            this.cuReportes1.TabIndex = 29;
            // 
            // cUgestion_empleados1
            // 
            this.cUgestion_empleados1.Location = new System.Drawing.Point(0, 3);
            this.cUgestion_empleados1.Name = "cUgestion_empleados1";
            this.cUgestion_empleados1.Size = new System.Drawing.Size(1003, 543);
            this.cUgestion_empleados1.TabIndex = 27;
            // 
            // cuServicios1
            // 
            this.cuServicios1.BackColor = System.Drawing.Color.Snow;
            this.cuServicios1.Location = new System.Drawing.Point(0, 0);
            this.cuServicios1.Name = "cuServicios1";
            this.cuServicios1.Size = new System.Drawing.Size(1003, 543);
            this.cuServicios1.TabIndex = 25;
            // 
            // cUclientes2
            // 
            this.cUclientes2.BackColor = System.Drawing.Color.Snow;
            this.cUclientes2.Location = new System.Drawing.Point(0, 1);
            this.cUclientes2.Name = "cUclientes2";
            this.cUclientes2.Size = new System.Drawing.Size(1003, 543);
            this.cUclientes2.TabIndex = 24;
            // 
            // cUinventario2
            // 
            this.cUinventario2.BackColor = System.Drawing.Color.Snow;
            this.cUinventario2.Location = new System.Drawing.Point(0, 1);
            this.cUinventario2.Name = "cUinventario2";
            this.cUinventario2.Size = new System.Drawing.Size(1003, 543);
            this.cUinventario2.TabIndex = 23;
            // 
            // cUfacturacion1
            // 
            this.cUfacturacion1.BackColor = System.Drawing.Color.Snow;
            this.cUfacturacion1.Location = new System.Drawing.Point(0, 3);
            this.cUfacturacion1.Name = "cUfacturacion1";
            this.cUfacturacion1.Size = new System.Drawing.Size(1003, 543);
            this.cUfacturacion1.TabIndex = 22;
            // 
            // cUproveedores2
            // 
            this.cUproveedores2.BackColor = System.Drawing.Color.Snow;
            this.cUproveedores2.Location = new System.Drawing.Point(0, 1);
            this.cUproveedores2.Name = "cUproveedores2";
            this.cUproveedores2.Size = new System.Drawing.Size(1003, 543);
            this.cUproveedores2.TabIndex = 21;
            // 
            // lblnotificacion
            // 
            this.lblnotificacion.AutoSize = true;
            this.lblnotificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(71)))), ((int)(((byte)(110)))));
            this.lblnotificacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnotificacion.ForeColor = System.Drawing.Color.White;
            this.lblnotificacion.Location = new System.Drawing.Point(945, 11);
            this.lblnotificacion.Name = "lblnotificacion";
            this.lblnotificacion.Size = new System.Drawing.Size(13, 19);
            this.lblnotificacion.TabIndex = 20;
            this.lblnotificacion.Text = ".";
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(20)))), ((int)(((byte)(235)))));
            this.lblhora.Location = new System.Drawing.Point(787, 570);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(34, 30);
            this.lblhora.TabIndex = 17;
            this.lblhora.Text = "...";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.ForeColor = System.Drawing.Color.DimGray;
            this.lblfecha.Location = new System.Drawing.Point(631, 605);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(25, 22);
            this.lblfecha.TabIndex = 18;
            this.lblfecha.Text = "...";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Sistema_de__inventarioGP2.Properties.Resources.bell;
            this.pictureBox3.Location = new System.Drawing.Point(922, 26);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 41);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // Menu_Principal_GP2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1193, 700);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel_meniu_principal);
            this.Controls.Add(this.panellateral);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Teal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu_Principal_GP2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_Principal_GP2_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Principal_GP2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panellateral.ResumeLayout(false);
            this.panellateral.PerformLayout();
            this.panel_meniu_principal.ResumeLayout(false);
            this.panel_meniu_principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btventas;
        private System.Windows.Forms.Button Btproveedores;
        private System.Windows.Forms.Button Btreportes;
        private System.Windows.Forms.Button Btclientes;
        private System.Windows.Forms.Button Btinventario;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panellateral;
        private System.Windows.Forms.Label lblprivilegios;
        private System.Windows.Forms.Label lblcargo;
        private System.Windows.Forms.Label lblnombreusuario;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer tmaparecermenu;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblnotificacion;
        private System.Windows.Forms.Panel sidepanel;
        private System.Windows.Forms.Button btgestionempleados;
        private System.Windows.Forms.Panel panel_meniu_principal;
        private System.Windows.Forms.Button btpanelajuste;
        private CUinventario cUinventario1;
        private CUajustes cUajustes1;
        private CUclientes cUclientes1;
        private CUproveedores cUproveedores1;
        private CUproveedores cUproveedores2;
        private System.Windows.Forms.Button btservicios;
        private CUfacturacion cUfacturacion1;
        private CUinventario cUinventario2;
        private CUclientes cUclientes2;
        private CUServicios cuServicios1;
        private CUgestion_empleados cUgestion_empleados1;
        private CUReportes cuReportes1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private CUgastos cUgastos1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bgastos;
        private CUPanelDeAjuste cuPanelDeAjuste1;
    }
}