namespace Sistema_de__inventarioGP2
{
    partial class CUgestion_empleados
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.llbdatos_empleados = new System.Windows.Forms.LinkLabel();
            this.llbsueldos = new System.Windows.Forms.LinkLabel();
            this.cuDatosempleado2 = new Sistema_de__inventarioGP2.CUDatosempleado();
            this.cUsueldos_e_ingresos1 = new Sistema_de__inventarioGP2.CUsueldos_e_ingresos();
            this.SuspendLayout();
            // 
            // llbdatos_empleados
            // 
            this.llbdatos_empleados.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(33)))));
            this.llbdatos_empleados.AutoSize = true;
            this.llbdatos_empleados.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbdatos_empleados.ForeColor = System.Drawing.Color.Purple;
            this.llbdatos_empleados.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(20)))), ((int)(((byte)(235)))));
            this.llbdatos_empleados.Location = new System.Drawing.Point(42, 9);
            this.llbdatos_empleados.Name = "llbdatos_empleados";
            this.llbdatos_empleados.Size = new System.Drawing.Size(142, 19);
            this.llbdatos_empleados.TabIndex = 21;
            this.llbdatos_empleados.TabStop = true;
            this.llbdatos_empleados.Text = "Datos Empleados";
            this.llbdatos_empleados.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(33)))));
            this.llbdatos_empleados.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbdatos_empleados_LinkClicked);
            // 
            // llbsueldos
            // 
            this.llbsueldos.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(33)))));
            this.llbsueldos.AutoSize = true;
            this.llbsueldos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbsueldos.ForeColor = System.Drawing.Color.Purple;
            this.llbsueldos.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(20)))), ((int)(((byte)(235)))));
            this.llbsueldos.Location = new System.Drawing.Point(432, 9);
            this.llbsueldos.Name = "llbsueldos";
            this.llbsueldos.Size = new System.Drawing.Size(148, 19);
            this.llbsueldos.TabIndex = 22;
            this.llbsueldos.TabStop = true;
            this.llbsueldos.Text = "Sueldos e Ingresos";
            this.llbsueldos.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(33)))));
            this.llbsueldos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbsueldos_LinkClicked);
            // 
            // cuDatosempleado2
            // 
            this.cuDatosempleado2.BackColor = System.Drawing.Color.Snow;
            this.cuDatosempleado2.Location = new System.Drawing.Point(0, 31);
            this.cuDatosempleado2.Name = "cuDatosempleado2";
            this.cuDatosempleado2.Size = new System.Drawing.Size(1003, 507);
            this.cuDatosempleado2.TabIndex = 23;
            // 
            // cUsueldos_e_ingresos1
            // 
            this.cUsueldos_e_ingresos1.BackColor = System.Drawing.Color.Snow;
            this.cUsueldos_e_ingresos1.Location = new System.Drawing.Point(0, 36);
            this.cUsueldos_e_ingresos1.Name = "cUsueldos_e_ingresos1";
            this.cUsueldos_e_ingresos1.Size = new System.Drawing.Size(1003, 507);
            this.cUsueldos_e_ingresos1.TabIndex = 24;
            // 
            // CUgestion_empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cUsueldos_e_ingresos1);
            this.Controls.Add(this.cuDatosempleado2);
            this.Controls.Add(this.llbsueldos);
            this.Controls.Add(this.llbdatos_empleados);
            this.Name = "CUgestion_empleados";
            this.Size = new System.Drawing.Size(1003, 543);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel llbdatos_empleados;
        private System.Windows.Forms.LinkLabel llbsueldos;
        private CUDatosempleado cuDatosempleado1;
        private CUDatosempleado cuDatosempleado2;
        private CUsueldos_e_ingresos cUsueldos_e_ingresos1;
    }
}
