namespace Sistema_de__inventarioGP2
{
    partial class CUcuadremensual
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
            this.dgvcuadre_mensual = new System.Windows.Forms.DataGridView();
            this.btactualizar = new System.Windows.Forms.Button();
            this.dtpdesde = new System.Windows.Forms.DateTimePicker();
            this.dtphasta = new System.Windows.Forms.DateTimePicker();
            this.btgenerar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cuInforme1 = new Sistema_de__inventarioGP2.CUInforme();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcuadre_mensual)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvcuadre_mensual
            // 
            this.dgvcuadre_mensual.AllowUserToAddRows = false;
            this.dgvcuadre_mensual.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvcuadre_mensual.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvcuadre_mensual.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvcuadre_mensual.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcuadre_mensual.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvcuadre_mensual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvcuadre_mensual.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvcuadre_mensual.EnableHeadersVisualStyles = false;
            this.dgvcuadre_mensual.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(33)))));
            this.dgvcuadre_mensual.Location = new System.Drawing.Point(13, 50);
            this.dgvcuadre_mensual.Name = "dgvcuadre_mensual";
            this.dgvcuadre_mensual.RowHeadersVisible = false;
            this.dgvcuadre_mensual.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvcuadre_mensual.Size = new System.Drawing.Size(975, 346);
            this.dgvcuadre_mensual.TabIndex = 60;
            // 
            // btactualizar
            // 
            this.btactualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(20)))), ((int)(((byte)(235)))));
            this.btactualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btactualizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btactualizar.ForeColor = System.Drawing.Color.White;
            this.btactualizar.Location = new System.Drawing.Point(13, 401);
            this.btactualizar.Name = "btactualizar";
            this.btactualizar.Size = new System.Drawing.Size(129, 44);
            this.btactualizar.TabIndex = 61;
            this.btactualizar.Text = "Actualizar";
            this.btactualizar.UseVisualStyleBackColor = false;
            this.btactualizar.Click += new System.EventHandler(this.btactualizar_Click);
            this.btactualizar.MouseLeave += new System.EventHandler(this.btactualizar_MouseLeave);
            this.btactualizar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btactualizar_MouseMove);
            // 
            // dtpdesde
            // 
            this.dtpdesde.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpdesde.CustomFormat = "dd-MMM-yyyy";
            this.dtpdesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpdesde.Location = new System.Drawing.Point(672, 414);
            this.dtpdesde.Name = "dtpdesde";
            this.dtpdesde.Size = new System.Drawing.Size(130, 20);
            this.dtpdesde.TabIndex = 62;
            // 
            // dtphasta
            // 
            this.dtphasta.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtphasta.CustomFormat = "dd-MMM-yyyy";
            this.dtphasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtphasta.Location = new System.Drawing.Point(672, 460);
            this.dtphasta.Name = "dtphasta";
            this.dtphasta.Size = new System.Drawing.Size(130, 20);
            this.dtphasta.TabIndex = 63;
            // 
            // btgenerar
            // 
            this.btgenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(20)))), ((int)(((byte)(235)))));
            this.btgenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btgenerar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btgenerar.ForeColor = System.Drawing.Color.White;
            this.btgenerar.Location = new System.Drawing.Point(847, 402);
            this.btgenerar.Name = "btgenerar";
            this.btgenerar.Size = new System.Drawing.Size(129, 86);
            this.btgenerar.TabIndex = 64;
            this.btgenerar.Text = "Generar Resumen de Venta";
            this.btgenerar.UseVisualStyleBackColor = false;
            this.btgenerar.Click += new System.EventHandler(this.btgenerar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(20)))), ((int)(((byte)(235)))));
            this.label12.Location = new System.Drawing.Point(558, 414);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 21);
            this.label12.TabIndex = 65;
            this.label12.Text = "Desde";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(20)))), ((int)(((byte)(235)))));
            this.label1.Location = new System.Drawing.Point(558, 460);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 66;
            this.label1.Text = "Hasta";
            // 
            // cuInforme1
            // 
            this.cuInforme1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cuInforme1.Location = new System.Drawing.Point(122, 32);
            this.cuInforme1.Name = "cuInforme1";
            this.cuInforme1.Size = new System.Drawing.Size(680, 456);
            this.cuInforme1.TabIndex = 67;
            // 
            // CUcuadremensual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.Controls.Add(this.cuInforme1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btgenerar);
            this.Controls.Add(this.dtphasta);
            this.Controls.Add(this.dtpdesde);
            this.Controls.Add(this.btactualizar);
            this.Controls.Add(this.dgvcuadre_mensual);
            this.Name = "CUcuadremensual";
            this.Size = new System.Drawing.Size(1003, 505);
            this.Load += new System.EventHandler(this.CUcuadremensual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcuadre_mensual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvcuadre_mensual;
        private System.Windows.Forms.Button btactualizar;
        private System.Windows.Forms.DateTimePicker dtpdesde;
        private System.Windows.Forms.DateTimePicker dtphasta;
        private System.Windows.Forms.Button btgenerar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private CUInforme cuInforme1;
    }
}
