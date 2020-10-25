namespace Sistema_de__inventarioGP2
{
    partial class CUcreditos
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
            this.dgvcreditos = new System.Windows.Forms.DataGridView();
            this.bimporte = new System.Windows.Forms.Button();
            this.txtimporte = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtbuscarcredito = new System.Windows.Forms.TextBox();
            this.lblfechaultimop = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblcredito = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcreditos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvcreditos
            // 
            this.dgvcreditos.AllowUserToAddRows = false;
            this.dgvcreditos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvcreditos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvcreditos.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvcreditos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvcreditos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcreditos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvcreditos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvcreditos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvcreditos.EnableHeadersVisualStyles = false;
            this.dgvcreditos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(33)))));
            this.dgvcreditos.Location = new System.Drawing.Point(12, 17);
            this.dgvcreditos.Name = "dgvcreditos";
            this.dgvcreditos.RowHeadersVisible = false;
            this.dgvcreditos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvcreditos.Size = new System.Drawing.Size(484, 386);
            this.dgvcreditos.TabIndex = 56;
            this.dgvcreditos.Click += new System.EventHandler(this.dgvcreditos_Click);
            // 
            // bimporte
            // 
            this.bimporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(20)))), ((int)(((byte)(235)))));
            this.bimporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bimporte.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bimporte.ForeColor = System.Drawing.Color.White;
            this.bimporte.Location = new System.Drawing.Point(756, 359);
            this.bimporte.Name = "bimporte";
            this.bimporte.Size = new System.Drawing.Size(152, 44);
            this.bimporte.TabIndex = 62;
            this.bimporte.Text = "Importe";
            this.bimporte.UseVisualStyleBackColor = false;
            this.bimporte.Click += new System.EventHandler(this.bimporte_Click);
            // 
            // txtimporte
            // 
            this.txtimporte.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtimporte.Location = new System.Drawing.Point(562, 380);
            this.txtimporte.Name = "txtimporte";
            this.txtimporte.Size = new System.Drawing.Size(179, 23);
            this.txtimporte.TabIndex = 63;
            this.txtimporte.TextChanged += new System.EventHandler(this.txtimporte_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(20)))), ((int)(((byte)(235)))));
            this.label12.Location = new System.Drawing.Point(12, 422);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 21);
            this.label12.TabIndex = 66;
            this.label12.Text = "Buscar";
            // 
            // txtbuscarcredito
            // 
            this.txtbuscarcredito.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscarcredito.Location = new System.Drawing.Point(76, 419);
            this.txtbuscarcredito.Name = "txtbuscarcredito";
            this.txtbuscarcredito.Size = new System.Drawing.Size(420, 23);
            this.txtbuscarcredito.TabIndex = 65;
            this.txtbuscarcredito.TextChanged += new System.EventHandler(this.txtbuscarcredito_TextChanged);
            // 
            // lblfechaultimop
            // 
            this.lblfechaultimop.AutoSize = true;
            this.lblfechaultimop.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfechaultimop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(20)))), ((int)(((byte)(235)))));
            this.lblfechaultimop.Location = new System.Drawing.Point(752, 295);
            this.lblfechaultimop.Name = "lblfechaultimop";
            this.lblfechaultimop.Size = new System.Drawing.Size(22, 21);
            this.lblfechaultimop.TabIndex = 67;
            this.lblfechaultimop.Text = "...";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(20)))), ((int)(((byte)(235)))));
            this.lblnombre.Location = new System.Drawing.Point(752, 133);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(22, 21);
            this.lblnombre.TabIndex = 68;
            this.lblnombre.Text = "...";
            // 
            // lblcredito
            // 
            this.lblcredito.AutoSize = true;
            this.lblcredito.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcredito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(20)))), ((int)(((byte)(235)))));
            this.lblcredito.Location = new System.Drawing.Point(752, 215);
            this.lblcredito.Name = "lblcredito";
            this.lblcredito.Size = new System.Drawing.Size(22, 21);
            this.lblcredito.TabIndex = 69;
            this.lblcredito.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(20)))), ((int)(((byte)(235)))));
            this.label1.Location = new System.Drawing.Point(558, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 70;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(20)))), ((int)(((byte)(235)))));
            this.label2.Location = new System.Drawing.Point(558, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 21);
            this.label2.TabIndex = 71;
            this.label2.Text = "Credito Pendiente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(20)))), ((int)(((byte)(235)))));
            this.label3.Location = new System.Drawing.Point(558, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 21);
            this.label3.TabIndex = 72;
            this.label3.Text = "Fecha de ultimo pago";
            // 
            // CUcreditos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblcredito);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lblfechaultimop);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtbuscarcredito);
            this.Controls.Add(this.txtimporte);
            this.Controls.Add(this.bimporte);
            this.Controls.Add(this.dgvcreditos);
            this.Name = "CUcreditos";
            this.Size = new System.Drawing.Size(1003, 507);
            this.Load += new System.EventHandler(this.CUcreditos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcreditos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvcreditos;
        private System.Windows.Forms.Button bimporte;
        private System.Windows.Forms.TextBox txtimporte;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtbuscarcredito;
        private System.Windows.Forms.Label lblfechaultimop;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblcredito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
