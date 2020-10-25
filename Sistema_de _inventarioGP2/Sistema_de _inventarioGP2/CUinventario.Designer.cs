namespace Sistema_de__inventarioGP2
{
    partial class CUinventario
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
            this.beliminar = new System.Windows.Forms.Button();
            this.btnTotalinv = new System.Windows.Forms.Button();
            this.dgvinventario = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcomision = new System.Windows.Forms.TextBox();
            this.bcancelar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bnuevo = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.bguardar = new System.Windows.Forms.Button();
            this.cbidproveedor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtpreciocosto = new System.Windows.Forms.TextBox();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.txtubicacion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtprecioventa = new System.Windows.Forms.TextBox();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.beditar = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinventario)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // beliminar
            // 
            this.beliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(20)))), ((int)(((byte)(235)))));
            this.beliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.beliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beliminar.ForeColor = System.Drawing.Color.Snow;
            this.beliminar.Location = new System.Drawing.Point(654, 222);
            this.beliminar.Name = "beliminar";
            this.beliminar.Size = new System.Drawing.Size(102, 43);
            this.beliminar.TabIndex = 46;
            this.beliminar.Text = "Eliminar";
            this.beliminar.UseVisualStyleBackColor = false;
            this.beliminar.Click += new System.EventHandler(this.beliminar_Click);
            this.beliminar.MouseLeave += new System.EventHandler(this.beliminar_MouseLeave);
            this.beliminar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.beliminar_MouseMove);
            // 
            // btnTotalinv
            // 
            this.btnTotalinv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(20)))), ((int)(((byte)(235)))));
            this.btnTotalinv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotalinv.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalinv.ForeColor = System.Drawing.Color.Snow;
            this.btnTotalinv.Location = new System.Drawing.Point(839, 222);
            this.btnTotalinv.Name = "btnTotalinv";
            this.btnTotalinv.Size = new System.Drawing.Size(147, 43);
            this.btnTotalinv.TabIndex = 45;
            this.btnTotalinv.Text = "Total Inventario";
            this.btnTotalinv.UseVisualStyleBackColor = false;
            this.btnTotalinv.Click += new System.EventHandler(this.btnTotalinv_Click);
            this.btnTotalinv.MouseLeave += new System.EventHandler(this.btnTotalinv_MouseLeave);
            this.btnTotalinv.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnTotalinv_MouseMove);
            // 
            // dgvinventario
            // 
            this.dgvinventario.AllowUserToAddRows = false;
            this.dgvinventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvinventario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvinventario.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvinventario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvinventario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvinventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvinventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvinventario.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvinventario.EnableHeadersVisualStyles = false;
            this.dgvinventario.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(33)))));
            this.dgvinventario.Location = new System.Drawing.Point(24, 13);
            this.dgvinventario.Name = "dgvinventario";
            this.dgvinventario.RowHeadersVisible = false;
            this.dgvinventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvinventario.Size = new System.Drawing.Size(962, 203);
            this.dgvinventario.TabIndex = 44;
            this.dgvinventario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvinventario_CellClick);
            this.dgvinventario.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvinventario_CellFormatting);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtcomision);
            this.panel4.Controls.Add(this.bcancelar);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.txtid);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.bnuevo);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.bguardar);
            this.panel4.Controls.Add(this.cbidproveedor);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.txtpreciocosto);
            this.panel4.Controls.Add(this.txtproducto);
            this.panel4.Controls.Add(this.txtubicacion);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtprecioventa);
            this.panel4.Controls.Add(this.txtcantidad);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(24, 278);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(810, 262);
            this.panel4.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(20)))), ((int)(((byte)(235)))));
            this.label1.Location = new System.Drawing.Point(449, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 21);
            this.label1.TabIndex = 38;
            this.label1.Text = "Comision (%)";
            // 
            // txtcomision
            // 
            this.txtcomision.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcomision.Location = new System.Drawing.Point(567, 25);
            this.txtcomision.Name = "txtcomision";
            this.txtcomision.Size = new System.Drawing.Size(75, 23);
            this.txtcomision.TabIndex = 37;
            // 
            // bcancelar
            // 
            this.bcancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(20)))), ((int)(((byte)(235)))));
            this.bcancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bcancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcancelar.ForeColor = System.Drawing.Color.White;
            this.bcancelar.Location = new System.Drawing.Point(449, 214);
            this.bcancelar.Name = "bcancelar";
            this.bcancelar.Size = new System.Drawing.Size(349, 44);
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
            this.label6.Location = new System.Drawing.Point(5, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 21);
            this.label6.TabIndex = 30;
            this.label6.Text = "ID.Producto";
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(123, 56);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(75, 23);
            this.txtid.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(20)))), ((int)(((byte)(235)))));
            this.label3.Location = new System.Drawing.Point(3, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 21);
            this.label3.TabIndex = 35;
            this.label3.Text = "Precio Costo";
            // 
            // bnuevo
            // 
            this.bnuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(20)))), ((int)(((byte)(235)))));
            this.bnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnuevo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnuevo.ForeColor = System.Drawing.Color.White;
            this.bnuevo.Location = new System.Drawing.Point(3, 3);
            this.bnuevo.Name = "bnuevo";
            this.bnuevo.Size = new System.Drawing.Size(102, 43);
            this.bnuevo.TabIndex = 23;
            this.bnuevo.Text = "Nuevo";
            this.bnuevo.UseVisualStyleBackColor = false;
            this.bnuevo.Click += new System.EventHandler(this.bnuevo_Click);
            this.bnuevo.MouseLeave += new System.EventHandler(this.bnuevo_MouseLeave);
            this.bnuevo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bnuevo_MouseMove);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(20)))), ((int)(((byte)(235)))));
            this.label11.Location = new System.Drawing.Point(5, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 21);
            this.label11.TabIndex = 33;
            this.label11.Text = "Proveedor";
            // 
            // bguardar
            // 
            this.bguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(20)))), ((int)(((byte)(235)))));
            this.bguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bguardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bguardar.ForeColor = System.Drawing.Color.White;
            this.bguardar.Location = new System.Drawing.Point(449, 150);
            this.bguardar.Name = "bguardar";
            this.bguardar.Size = new System.Drawing.Size(349, 44);
            this.bguardar.TabIndex = 6;
            this.bguardar.Text = "Guardar";
            this.bguardar.UseVisualStyleBackColor = false;
            this.bguardar.Click += new System.EventHandler(this.bguardar_Click);
            this.bguardar.MouseLeave += new System.EventHandler(this.bguardar_MouseLeave);
            this.bguardar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bguardar_MouseMove);
            // 
            // cbidproveedor
            // 
            this.cbidproveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbidproveedor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbidproveedor.FormattingEnabled = true;
            this.cbidproveedor.Location = new System.Drawing.Point(123, 136);
            this.cbidproveedor.Name = "cbidproveedor";
            this.cbidproveedor.Size = new System.Drawing.Size(284, 25);
            this.cbidproveedor.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(20)))), ((int)(((byte)(235)))));
            this.label7.Location = new System.Drawing.Point(5, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 21);
            this.label7.TabIndex = 31;
            this.label7.Text = "Producto";
            // 
            // txtpreciocosto
            // 
            this.txtpreciocosto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpreciocosto.Location = new System.Drawing.Point(123, 220);
            this.txtpreciocosto.Name = "txtpreciocosto";
            this.txtpreciocosto.Size = new System.Drawing.Size(75, 23);
            this.txtpreciocosto.TabIndex = 3;
            // 
            // txtproducto
            // 
            this.txtproducto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproducto.Location = new System.Drawing.Point(123, 97);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(284, 23);
            this.txtproducto.TabIndex = 0;
            // 
            // txtubicacion
            // 
            this.txtubicacion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtubicacion.Location = new System.Drawing.Point(567, 107);
            this.txtubicacion.Name = "txtubicacion";
            this.txtubicacion.Size = new System.Drawing.Size(161, 23);
            this.txtubicacion.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(20)))), ((int)(((byte)(235)))));
            this.label9.Location = new System.Drawing.Point(5, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 21);
            this.label9.TabIndex = 32;
            this.label9.Text = "Precio Venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(20)))), ((int)(((byte)(235)))));
            this.label2.Location = new System.Drawing.Point(451, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Ubicacion";
            // 
            // txtprecioventa
            // 
            this.txtprecioventa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprecioventa.Location = new System.Drawing.Point(123, 179);
            this.txtprecioventa.Name = "txtprecioventa";
            this.txtprecioventa.Size = new System.Drawing.Size(75, 23);
            this.txtprecioventa.TabIndex = 2;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantidad.Location = new System.Drawing.Point(567, 66);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(75, 23);
            this.txtcantidad.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(20)))), ((int)(((byte)(235)))));
            this.label8.Location = new System.Drawing.Point(451, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Cantidad";
            // 
            // beditar
            // 
            this.beditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(20)))), ((int)(((byte)(235)))));
            this.beditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.beditar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beditar.ForeColor = System.Drawing.Color.Snow;
            this.beditar.Location = new System.Drawing.Point(474, 222);
            this.beditar.Name = "beditar";
            this.beditar.Size = new System.Drawing.Size(102, 43);
            this.beditar.TabIndex = 40;
            this.beditar.Text = "Editar";
            this.beditar.UseVisualStyleBackColor = false;
            this.beditar.Click += new System.EventHandler(this.beditar_Click);
            this.beditar.MouseLeave += new System.EventHandler(this.beditar_MouseLeave);
            this.beditar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.beditar_MouseMove);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.Location = new System.Drawing.Point(133, 241);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(283, 23);
            this.txtbuscar.TabIndex = 42;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(20)))), ((int)(((byte)(235)))));
            this.label12.Location = new System.Drawing.Point(30, 240);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 21);
            this.label12.TabIndex = 41;
            this.label12.Text = "Buscar";
            // 
            // CUinventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.Controls.Add(this.beliminar);
            this.Controls.Add(this.btnTotalinv);
            this.Controls.Add(this.dgvinventario);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.beditar);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.label12);
            this.Name = "CUinventario";
            this.Size = new System.Drawing.Size(1003, 543);
            this.Load += new System.EventHandler(this.CUinventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvinventario)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button beliminar;
        private System.Windows.Forms.Button btnTotalinv;
        private System.Windows.Forms.DataGridView dgvinventario;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button bcancelar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bnuevo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button bguardar;
        private System.Windows.Forms.ComboBox cbidproveedor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtpreciocosto;
        private System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.TextBox txtubicacion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtprecioventa;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button beditar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcomision;
    }
}
