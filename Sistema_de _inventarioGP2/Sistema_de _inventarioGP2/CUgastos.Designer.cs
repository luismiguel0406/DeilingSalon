namespace Sistema_de__inventarioGP2
{
    partial class CUgastos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtpfechagasto = new System.Windows.Forms.DateTimePicker();
            this.bcancelar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bnuevogasto = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.bguardar = new System.Windows.Forms.Button();
            this.cbconcepto = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtgasto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtnotas = new System.Windows.Forms.TextBox();
            this.beliminar = new System.Windows.Forms.Button();
            this.beditar = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvgastos = new System.Windows.Forms.DataGridView();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgastos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.dtpfechagasto);
            this.panel4.Controls.Add(this.bcancelar);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.txtid);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.bnuevogasto);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.bguardar);
            this.panel4.Controls.Add(this.cbconcepto);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.txtgasto);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.txtnotas);
            this.panel4.Location = new System.Drawing.Point(12, 23);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(342, 473);
            this.panel4.TabIndex = 44;
            // 
            // dtpfechagasto
            // 
            this.dtpfechagasto.CustomFormat = "dd-MMM-yyy";
            this.dtpfechagasto.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpfechagasto.Location = new System.Drawing.Point(123, 334);
            this.dtpfechagasto.Name = "dtpfechagasto";
            this.dtpfechagasto.Size = new System.Drawing.Size(184, 20);
            this.dtpfechagasto.TabIndex = 37;
            // 
            // bcancelar
            // 
            this.bcancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(20)))), ((int)(((byte)(235)))));
            this.bcancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bcancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcancelar.ForeColor = System.Drawing.Color.White;
            this.bcancelar.Location = new System.Drawing.Point(192, 418);
            this.bcancelar.Name = "bcancelar";
            this.bcancelar.Size = new System.Drawing.Size(133, 44);
            this.bcancelar.TabIndex = 36;
            this.bcancelar.Text = "Cancelar";
            this.bcancelar.UseVisualStyleBackColor = false;
            this.bcancelar.Click += new System.EventHandler(this.bcancelar_Click);
            this.bcancelar.MouseLeave += new System.EventHandler(this.bcancelar_MouseLeave);
            this.bcancelar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bcancelar_MouseMove);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(20)))), ((int)(((byte)(235)))));
            this.label6.Location = new System.Drawing.Point(9, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 21);
            this.label6.TabIndex = 30;
            this.label6.Text = "ID";
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(123, 70);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(75, 23);
            this.txtid.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(20)))), ((int)(((byte)(235)))));
            this.label3.Location = new System.Drawing.Point(9, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 21);
            this.label3.TabIndex = 35;
            this.label3.Text = "Fecha";
            // 
            // bnuevogasto
            // 
            this.bnuevogasto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(20)))), ((int)(((byte)(235)))));
            this.bnuevogasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnuevogasto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnuevogasto.ForeColor = System.Drawing.Color.White;
            this.bnuevogasto.Location = new System.Drawing.Point(9, 6);
            this.bnuevogasto.Name = "bnuevogasto";
            this.bnuevogasto.Size = new System.Drawing.Size(127, 43);
            this.bnuevogasto.TabIndex = 23;
            this.bnuevogasto.Text = "Nuevo Gasto";
            this.bnuevogasto.UseVisualStyleBackColor = false;
            this.bnuevogasto.Click += new System.EventHandler(this.bnuevogasto_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(20)))), ((int)(((byte)(235)))));
            this.label11.Location = new System.Drawing.Point(9, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 21);
            this.label11.TabIndex = 33;
            this.label11.Text = "Concepto";
            // 
            // bguardar
            // 
            this.bguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(20)))), ((int)(((byte)(235)))));
            this.bguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bguardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bguardar.ForeColor = System.Drawing.Color.White;
            this.bguardar.Location = new System.Drawing.Point(9, 418);
            this.bguardar.Name = "bguardar";
            this.bguardar.Size = new System.Drawing.Size(133, 44);
            this.bguardar.TabIndex = 6;
            this.bguardar.Text = "Guardar";
            this.bguardar.UseVisualStyleBackColor = false;
            this.bguardar.Click += new System.EventHandler(this.bguardar_Click);
            this.bguardar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bguardar_MouseDown);
            this.bguardar.MouseLeave += new System.EventHandler(this.bguardar_MouseLeave);
            this.bguardar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bguardar_MouseMove);
            // 
            // cbconcepto
            // 
            this.cbconcepto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbconcepto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbconcepto.FormattingEnabled = true;
            this.cbconcepto.Items.AddRange(new object[] {
            "Seleccione un Concepto -  ->>",
            "Factura Electrica",
            "Alquiler Local",
            "Servicio de Agua",
            "Internet",
            "Factura Proveedores",
            "Transporte",
            "Publicidad",
            "Seguros",
            "Gastos Bancarios",
            "Limpieza e higiene",
            "Dieta",
            "Emergencia",
            "Material Gastable",
            "Combustible",
            "Mantenimiento",
            "Otros"});
            this.cbconcepto.Location = new System.Drawing.Point(123, 158);
            this.cbconcepto.Name = "cbconcepto";
            this.cbconcepto.Size = new System.Drawing.Size(184, 25);
            this.cbconcepto.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(20)))), ((int)(((byte)(235)))));
            this.label7.Location = new System.Drawing.Point(9, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 21);
            this.label7.TabIndex = 31;
            this.label7.Text = "Gasto RD$";
            // 
            // txtgasto
            // 
            this.txtgasto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgasto.Location = new System.Drawing.Point(123, 114);
            this.txtgasto.Name = "txtgasto";
            this.txtgasto.Size = new System.Drawing.Size(184, 23);
            this.txtgasto.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(20)))), ((int)(((byte)(235)))));
            this.label9.Location = new System.Drawing.Point(9, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 21);
            this.label9.TabIndex = 32;
            this.label9.Text = "Notas";
            // 
            // txtnotas
            // 
            this.txtnotas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnotas.Location = new System.Drawing.Point(123, 214);
            this.txtnotas.Multiline = true;
            this.txtnotas.Name = "txtnotas";
            this.txtnotas.Size = new System.Drawing.Size(184, 98);
            this.txtnotas.TabIndex = 2;
            // 
            // beliminar
            // 
            this.beliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(20)))), ((int)(((byte)(235)))));
            this.beliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.beliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beliminar.ForeColor = System.Drawing.Color.Snow;
            this.beliminar.Location = new System.Drawing.Point(878, 312);
            this.beliminar.Name = "beliminar";
            this.beliminar.Size = new System.Drawing.Size(102, 43);
            this.beliminar.TabIndex = 50;
            this.beliminar.Text = "Eliminar";
            this.beliminar.UseVisualStyleBackColor = false;
            this.beliminar.Click += new System.EventHandler(this.beliminar_Click);
            // 
            // beditar
            // 
            this.beditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(20)))), ((int)(((byte)(235)))));
            this.beditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.beditar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beditar.ForeColor = System.Drawing.Color.Snow;
            this.beditar.Location = new System.Drawing.Point(742, 312);
            this.beditar.Name = "beditar";
            this.beditar.Size = new System.Drawing.Size(102, 43);
            this.beditar.TabIndex = 47;
            this.beditar.Text = "Editar";
            this.beditar.UseVisualStyleBackColor = false;
            this.beditar.Click += new System.EventHandler(this.beditar_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.Location = new System.Drawing.Point(463, 335);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(216, 23);
            this.txtbuscar.TabIndex = 49;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(20)))), ((int)(((byte)(235)))));
            this.label12.Location = new System.Drawing.Point(396, 334);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 21);
            this.label12.TabIndex = 48;
            this.label12.Text = "Buscar";
            // 
            // dgvgastos
            // 
            this.dgvgastos.AllowUserToAddRows = false;
            this.dgvgastos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvgastos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvgastos.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvgastos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvgastos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvgastos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvgastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvgastos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvgastos.EnableHeadersVisualStyles = false;
            this.dgvgastos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(33)))));
            this.dgvgastos.Location = new System.Drawing.Point(400, 23);
            this.dgvgastos.Name = "dgvgastos";
            this.dgvgastos.RowHeadersVisible = false;
            this.dgvgastos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvgastos.Size = new System.Drawing.Size(580, 276);
            this.dgvgastos.TabIndex = 51;
            this.dgvgastos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvgastos_CellClick);
            // 
            // CUgastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.Controls.Add(this.dgvgastos);
            this.Controls.Add(this.beliminar);
            this.Controls.Add(this.beditar);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel4);
            this.Name = "CUgastos";
            this.Size = new System.Drawing.Size(1003, 543);
            this.Load += new System.EventHandler(this.CUgastos_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgastos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button bcancelar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bnuevogasto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbconcepto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtgasto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtnotas;
        private System.Windows.Forms.Button beliminar;
        private System.Windows.Forms.Button beditar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvgastos;
        private System.Windows.Forms.DateTimePicker dtpfechagasto;
        private System.Windows.Forms.Button bguardar;
    }
}
