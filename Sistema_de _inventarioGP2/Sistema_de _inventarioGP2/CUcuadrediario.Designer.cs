namespace Sistema_de__inventarioGP2
{
    partial class CUcuadrediario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.bfindedia = new System.Windows.Forms.Button();
            this.dgvventas_dia = new System.Windows.Forms.DataGridView();
            this.rbventashoy = new System.Windows.Forms.RadioButton();
            this.rbtodasventas = new System.Windows.Forms.RadioButton();
            this.btactualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvventas_dia)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(20)))), ((int)(((byte)(235)))));
            this.label2.Location = new System.Drawing.Point(8, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 62;
            this.label2.Text = "Buscar";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.Location = new System.Drawing.Point(100, 426);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(290, 23);
            this.txtbuscar.TabIndex = 61;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // bfindedia
            // 
            this.bfindedia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(20)))), ((int)(((byte)(235)))));
            this.bfindedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bfindedia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfindedia.ForeColor = System.Drawing.Color.White;
            this.bfindedia.Location = new System.Drawing.Point(779, 405);
            this.bfindedia.Name = "bfindedia";
            this.bfindedia.Size = new System.Drawing.Size(204, 44);
            this.bfindedia.TabIndex = 60;
            this.bfindedia.Text = "Fin de dia";
            this.bfindedia.UseVisualStyleBackColor = false;
            this.bfindedia.Click += new System.EventHandler(this.bfindedia_Click);
            // 
            // dgvventas_dia
            // 
            this.dgvventas_dia.AllowUserToAddRows = false;
            this.dgvventas_dia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvventas_dia.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvventas_dia.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvventas_dia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvventas_dia.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvventas_dia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvventas_dia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvventas_dia.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvventas_dia.EnableHeadersVisualStyles = false;
            this.dgvventas_dia.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(33)))));
            this.dgvventas_dia.Location = new System.Drawing.Point(12, 51);
            this.dgvventas_dia.Name = "dgvventas_dia";
            this.dgvventas_dia.RowHeadersVisible = false;
            this.dgvventas_dia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvventas_dia.Size = new System.Drawing.Size(971, 346);
            this.dgvventas_dia.TabIndex = 59;
            // 
            // rbventashoy
            // 
            this.rbventashoy.AutoSize = true;
            this.rbventashoy.Checked = true;
            this.rbventashoy.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbventashoy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(20)))), ((int)(((byte)(235)))));
            this.rbventashoy.Location = new System.Drawing.Point(12, 20);
            this.rbventashoy.Name = "rbventashoy";
            this.rbventashoy.Size = new System.Drawing.Size(57, 25);
            this.rbventashoy.TabIndex = 66;
            this.rbventashoy.TabStop = true;
            this.rbventashoy.Text = "Hoy";
            this.rbventashoy.UseVisualStyleBackColor = true;
            this.rbventashoy.CheckedChanged += new System.EventHandler(this.rbventashoy_CheckedChanged);
            // 
            // rbtodasventas
            // 
            this.rbtodasventas.AutoSize = true;
            this.rbtodasventas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtodasventas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(20)))), ((int)(((byte)(235)))));
            this.rbtodasventas.Location = new System.Drawing.Point(147, 20);
            this.rbtodasventas.Name = "rbtodasventas";
            this.rbtodasventas.Size = new System.Drawing.Size(74, 25);
            this.rbtodasventas.TabIndex = 67;
            this.rbtodasventas.Text = "Todas";
            this.rbtodasventas.UseVisualStyleBackColor = true;
            this.rbtodasventas.CheckedChanged += new System.EventHandler(this.rbtodasventas_CheckedChanged);
            // 
            // btactualizar
            // 
            this.btactualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(20)))), ((int)(((byte)(235)))));
            this.btactualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btactualizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btactualizar.ForeColor = System.Drawing.Color.White;
            this.btactualizar.Location = new System.Drawing.Point(632, 405);
            this.btactualizar.Name = "btactualizar";
            this.btactualizar.Size = new System.Drawing.Size(129, 44);
            this.btactualizar.TabIndex = 68;
            this.btactualizar.Text = "Actualizar";
            this.btactualizar.UseVisualStyleBackColor = false;
            this.btactualizar.Click += new System.EventHandler(this.btactualizar_Click);
            // 
            // CUcuadrediario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.Controls.Add(this.btactualizar);
            this.Controls.Add(this.rbtodasventas);
            this.Controls.Add(this.rbventashoy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.bfindedia);
            this.Controls.Add(this.dgvventas_dia);
            this.Name = "CUcuadrediario";
            this.Size = new System.Drawing.Size(1003, 505);
            this.Load += new System.EventHandler(this.CUcuadrediario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvventas_dia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Button bfindedia;
        public System.Windows.Forms.DataGridView dgvventas_dia;
        private System.Windows.Forms.RadioButton rbventashoy;
        private System.Windows.Forms.RadioButton rbtodasventas;
        private System.Windows.Forms.Button btactualizar;
    }
}
