namespace Sistema_de__inventarioGP2
{
    partial class CUServicios
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
            this.dgvServicios = new System.Windows.Forms.DataGridView();
            this.bnuevoservicio = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtideservicio = new System.Windows.Forms.TextBox();
            this.txtservicio = new System.Windows.Forms.TextBox();
            this.txtprecioserv = new System.Windows.Forms.TextBox();
            this.bguardarserv = new System.Windows.Forms.Button();
            this.bcancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbuscarserv = new System.Windows.Forms.TextBox();
            this.beliminar = new System.Windows.Forms.Button();
            this.beditar = new System.Windows.Forms.Button();
            this.txtcomision = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtpreciocomision = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvServicios
            // 
            this.dgvServicios.AllowUserToAddRows = false;
            this.dgvServicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServicios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvServicios.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvServicios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvServicios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvServicios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvServicios.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvServicios.EnableHeadersVisualStyles = false;
            this.dgvServicios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(33)))));
            this.dgvServicios.Location = new System.Drawing.Point(24, 13);
            this.dgvServicios.Name = "dgvServicios";
            this.dgvServicios.RowHeadersVisible = false;
            this.dgvServicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServicios.Size = new System.Drawing.Size(954, 214);
            this.dgvServicios.TabIndex = 56;
            this.dgvServicios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServicios_CellClick);
            // 
            // bnuevoservicio
            // 
            this.bnuevoservicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(20)))), ((int)(((byte)(235)))));
            this.bnuevoservicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnuevoservicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnuevoservicio.ForeColor = System.Drawing.Color.White;
            this.bnuevoservicio.Location = new System.Drawing.Point(24, 233);
            this.bnuevoservicio.Name = "bnuevoservicio";
            this.bnuevoservicio.Size = new System.Drawing.Size(182, 43);
            this.bnuevoservicio.TabIndex = 57;
            this.bnuevoservicio.Text = "Nuevo Servicio";
            this.bnuevoservicio.UseVisualStyleBackColor = false;
            this.bnuevoservicio.Click += new System.EventHandler(this.bnuevoservicio_Click);
            this.bnuevoservicio.MouseLeave += new System.EventHandler(this.bnuevoservicio_MouseLeave);
            this.bnuevoservicio.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bnuevoservicio_MouseMove);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(20)))), ((int)(((byte)(235)))));
            this.label7.Location = new System.Drawing.Point(20, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 21);
            this.label7.TabIndex = 58;
            this.label7.Text = "ID. Servicio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(20)))), ((int)(((byte)(235)))));
            this.label1.Location = new System.Drawing.Point(20, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 59;
            this.label1.Text = "Precio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(20)))), ((int)(((byte)(235)))));
            this.label2.Location = new System.Drawing.Point(20, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 60;
            this.label2.Text = "Servicio";
            // 
            // txtideservicio
            // 
            this.txtideservicio.Enabled = false;
            this.txtideservicio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtideservicio.Location = new System.Drawing.Point(120, 282);
            this.txtideservicio.Name = "txtideservicio";
            this.txtideservicio.Size = new System.Drawing.Size(86, 23);
            this.txtideservicio.TabIndex = 61;
            // 
            // txtservicio
            // 
            this.txtservicio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtservicio.Location = new System.Drawing.Point(120, 322);
            this.txtservicio.Name = "txtservicio";
            this.txtservicio.Size = new System.Drawing.Size(284, 23);
            this.txtservicio.TabIndex = 0;
            // 
            // txtprecioserv
            // 
            this.txtprecioserv.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprecioserv.Location = new System.Drawing.Point(120, 362);
            this.txtprecioserv.Name = "txtprecioserv";
            this.txtprecioserv.Size = new System.Drawing.Size(284, 23);
            this.txtprecioserv.TabIndex = 1;
            // 
            // bguardarserv
            // 
            this.bguardarserv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(20)))), ((int)(((byte)(235)))));
            this.bguardarserv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bguardarserv.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bguardarserv.ForeColor = System.Drawing.Color.White;
            this.bguardarserv.Location = new System.Drawing.Point(24, 488);
            this.bguardarserv.Name = "bguardarserv";
            this.bguardarserv.Size = new System.Drawing.Size(161, 43);
            this.bguardarserv.TabIndex = 4;
            this.bguardarserv.Text = "Guardar";
            this.bguardarserv.UseVisualStyleBackColor = false;
            this.bguardarserv.Click += new System.EventHandler(this.bguardarserv_Click);
            this.bguardarserv.MouseLeave += new System.EventHandler(this.bguardarserv_MouseLeave);
            this.bguardarserv.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bguardarserv_MouseMove);
            // 
            // bcancelar
            // 
            this.bcancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(20)))), ((int)(((byte)(235)))));
            this.bcancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bcancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcancelar.ForeColor = System.Drawing.Color.White;
            this.bcancelar.Location = new System.Drawing.Point(243, 488);
            this.bcancelar.Name = "bcancelar";
            this.bcancelar.Size = new System.Drawing.Size(161, 43);
            this.bcancelar.TabIndex = 5;
            this.bcancelar.Text = "Cancelar";
            this.bcancelar.UseVisualStyleBackColor = false;
            this.bcancelar.Click += new System.EventHandler(this.bcancelar_Click);
            this.bcancelar.MouseLeave += new System.EventHandler(this.bcancelar_MouseLeave);
            this.bcancelar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bcancelar_MouseMove);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(20)))), ((int)(((byte)(235)))));
            this.label3.Location = new System.Drawing.Point(506, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 21);
            this.label3.TabIndex = 66;
            this.label3.Text = "Buscar";
            // 
            // txtbuscarserv
            // 
            this.txtbuscarserv.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscarserv.Location = new System.Drawing.Point(573, 269);
            this.txtbuscarserv.Name = "txtbuscarserv";
            this.txtbuscarserv.Size = new System.Drawing.Size(405, 23);
            this.txtbuscarserv.TabIndex = 67;
            this.txtbuscarserv.TextChanged += new System.EventHandler(this.txtbuscarserv_TextChanged);
            // 
            // beliminar
            // 
            this.beliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(20)))), ((int)(((byte)(235)))));
            this.beliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.beliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beliminar.ForeColor = System.Drawing.Color.White;
            this.beliminar.Location = new System.Drawing.Point(817, 321);
            this.beliminar.Name = "beliminar";
            this.beliminar.Size = new System.Drawing.Size(161, 43);
            this.beliminar.TabIndex = 68;
            this.beliminar.Text = "Eliminar";
            this.beliminar.UseVisualStyleBackColor = false;
            this.beliminar.Click += new System.EventHandler(this.beliminar_Click);
            this.beliminar.MouseLeave += new System.EventHandler(this.beliminar_MouseLeave);
            this.beliminar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.beliminar_MouseMove);
            // 
            // beditar
            // 
            this.beditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(20)))), ((int)(((byte)(235)))));
            this.beditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.beditar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beditar.ForeColor = System.Drawing.Color.White;
            this.beditar.Location = new System.Drawing.Point(573, 321);
            this.beditar.Name = "beditar";
            this.beditar.Size = new System.Drawing.Size(161, 43);
            this.beditar.TabIndex = 69;
            this.beditar.Text = "Editar";
            this.beditar.UseVisualStyleBackColor = false;
            this.beditar.Click += new System.EventHandler(this.beditar_Click);
            this.beditar.MouseLeave += new System.EventHandler(this.beditar_MouseLeave);
            this.beditar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.beditar_MouseMove);
            // 
            // txtcomision
            // 
            this.txtcomision.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcomision.Location = new System.Drawing.Point(191, 442);
            this.txtcomision.Name = "txtcomision";
            this.txtcomision.Size = new System.Drawing.Size(214, 23);
            this.txtcomision.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(20)))), ((int)(((byte)(235)))));
            this.label4.Location = new System.Drawing.Point(21, 444);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 21);
            this.label4.TabIndex = 70;
            this.label4.Text = "Comision Empleado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(20)))), ((int)(((byte)(235)))));
            this.label5.Location = new System.Drawing.Point(21, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 21);
            this.label5.TabIndex = 71;
            this.label5.Text = "Precio Comision";
            // 
            // txtpreciocomision
            // 
            this.txtpreciocomision.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpreciocomision.Location = new System.Drawing.Point(191, 402);
            this.txtpreciocomision.Name = "txtpreciocomision";
            this.txtpreciocomision.Size = new System.Drawing.Size(214, 23);
            this.txtpreciocomision.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(20)))), ((int)(((byte)(235)))));
            this.label6.Location = new System.Drawing.Point(426, 444);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(295, 21);
            this.label6.TabIndex = 72;
            this.label6.Text = "Coloque el valor en decimal ,  el cual";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(20)))), ((int)(((byte)(235)))));
            this.label8.Location = new System.Drawing.Point(426, 465);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(276, 21);
            this.label8.TabIndex = 73;
            this.label8.Text = "calculara la comision al empleado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(20)))), ((int)(((byte)(235)))));
            this.label9.Location = new System.Drawing.Point(426, 488);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(230, 21);
            this.label9.TabIndex = 74;
            this.label9.Text = "Ej: 0.1  es 10% ,  0.25 seria 25%";
            // 
            // CUServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtpreciocomision);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtcomision);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.beditar);
            this.Controls.Add(this.beliminar);
            this.Controls.Add(this.txtbuscarserv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bcancelar);
            this.Controls.Add(this.bguardarserv);
            this.Controls.Add(this.txtprecioserv);
            this.Controls.Add(this.txtservicio);
            this.Controls.Add(this.txtideservicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bnuevoservicio);
            this.Controls.Add(this.dgvServicios);
            this.Name = "CUServicios";
            this.Size = new System.Drawing.Size(1003, 543);
            this.Load += new System.EventHandler(this.CUServicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvServicios;
        private System.Windows.Forms.Button bnuevoservicio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtideservicio;
        private System.Windows.Forms.TextBox txtservicio;
        private System.Windows.Forms.TextBox txtprecioserv;
        private System.Windows.Forms.Button bguardarserv;
        private System.Windows.Forms.Button bcancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbuscarserv;
        private System.Windows.Forms.Button beliminar;
        private System.Windows.Forms.Button beditar;
        private System.Windows.Forms.TextBox txtcomision;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtpreciocomision;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}
