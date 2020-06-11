namespace InterfaceMaquinaExpendedora
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gmbCocaCola = new System.Windows.Forms.GroupBox();
            this.picCocaCola = new System.Windows.Forms.PictureBox();
            this.btnCocaCola = new System.Windows.Forms.Button();
            this.cmbCocaCola = new System.Windows.Forms.ComboBox();
            this.lblRefrescoCocaCola = new System.Windows.Forms.Label();
            this.gmbDrPepper = new System.Windows.Forms.GroupBox();
            this.picDrPepper = new System.Windows.Forms.PictureBox();
            this.btnDrPepper = new System.Windows.Forms.Button();
            this.cmbDrPepper = new System.Windows.Forms.ComboBox();
            this.lblRefrescoDrPepper = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gmbCocaCola.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCocaCola)).BeginInit();
            this.gmbDrPepper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDrPepper)).BeginInit();
            this.SuspendLayout();
            // 
            // gmbCocaCola
            // 
            this.gmbCocaCola.Controls.Add(this.picCocaCola);
            this.gmbCocaCola.Controls.Add(this.btnCocaCola);
            this.gmbCocaCola.Controls.Add(this.cmbCocaCola);
            this.gmbCocaCola.Controls.Add(this.lblRefrescoCocaCola);
            this.gmbCocaCola.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gmbCocaCola.ForeColor = System.Drawing.Color.White;
            this.gmbCocaCola.Location = new System.Drawing.Point(12, 12);
            this.gmbCocaCola.Name = "gmbCocaCola";
            this.gmbCocaCola.Size = new System.Drawing.Size(149, 142);
            this.gmbCocaCola.TabIndex = 0;
            this.gmbCocaCola.TabStop = false;
            this.gmbCocaCola.Text = "Coca-Cola";
            // 
            // picCocaCola
            // 
            this.picCocaCola.Image = ((System.Drawing.Image)(resources.GetObject("picCocaCola.Image")));
            this.picCocaCola.Location = new System.Drawing.Point(28, 86);
            this.picCocaCola.Name = "picCocaCola";
            this.picCocaCola.Size = new System.Drawing.Size(100, 50);
            this.picCocaCola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCocaCola.TabIndex = 3;
            this.picCocaCola.TabStop = false;
            // 
            // btnCocaCola
            // 
            this.btnCocaCola.BackColor = System.Drawing.Color.Red;
            this.btnCocaCola.Location = new System.Drawing.Point(40, 59);
            this.btnCocaCola.Name = "btnCocaCola";
            this.btnCocaCola.Size = new System.Drawing.Size(75, 23);
            this.btnCocaCola.TabIndex = 2;
            this.btnCocaCola.Text = "Precio";
            this.btnCocaCola.UseVisualStyleBackColor = false;
            this.btnCocaCola.Click += new System.EventHandler(this.btnCocaCola_Click);
            // 
            // cmbCocaCola
            // 
            this.cmbCocaCola.BackColor = System.Drawing.Color.Red;
            this.cmbCocaCola.FormattingEnabled = true;
            this.cmbCocaCola.Items.AddRange(new object[] {
            "Lata 350ml",
            "Botella 600ml"});
            this.cmbCocaCola.Location = new System.Drawing.Point(6, 32);
            this.cmbCocaCola.Name = "cmbCocaCola";
            this.cmbCocaCola.Size = new System.Drawing.Size(137, 21);
            this.cmbCocaCola.TabIndex = 1;
            // 
            // lblRefrescoCocaCola
            // 
            this.lblRefrescoCocaCola.AutoSize = true;
            this.lblRefrescoCocaCola.ForeColor = System.Drawing.Color.White;
            this.lblRefrescoCocaCola.Location = new System.Drawing.Point(6, 16);
            this.lblRefrescoCocaCola.Name = "lblRefrescoCocaCola";
            this.lblRefrescoCocaCola.Size = new System.Drawing.Size(139, 13);
            this.lblRefrescoCocaCola.TabIndex = 0;
            this.lblRefrescoCocaCola.Text = "Selecciona tu refresco:";
            // 
            // gmbDrPepper
            // 
            this.gmbDrPepper.Controls.Add(this.picDrPepper);
            this.gmbDrPepper.Controls.Add(this.btnDrPepper);
            this.gmbDrPepper.Controls.Add(this.cmbDrPepper);
            this.gmbDrPepper.Controls.Add(this.lblRefrescoDrPepper);
            this.gmbDrPepper.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gmbDrPepper.ForeColor = System.Drawing.Color.White;
            this.gmbDrPepper.Location = new System.Drawing.Point(167, 12);
            this.gmbDrPepper.Name = "gmbDrPepper";
            this.gmbDrPepper.Size = new System.Drawing.Size(149, 142);
            this.gmbDrPepper.TabIndex = 1;
            this.gmbDrPepper.TabStop = false;
            this.gmbDrPepper.Text = "DrPepper";
            // 
            // picDrPepper
            // 
            this.picDrPepper.Image = ((System.Drawing.Image)(resources.GetObject("picDrPepper.Image")));
            this.picDrPepper.Location = new System.Drawing.Point(27, 86);
            this.picDrPepper.Name = "picDrPepper";
            this.picDrPepper.Size = new System.Drawing.Size(100, 50);
            this.picDrPepper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDrPepper.TabIndex = 4;
            this.picDrPepper.TabStop = false;
            // 
            // btnDrPepper
            // 
            this.btnDrPepper.BackColor = System.Drawing.Color.Red;
            this.btnDrPepper.Location = new System.Drawing.Point(39, 59);
            this.btnDrPepper.Name = "btnDrPepper";
            this.btnDrPepper.Size = new System.Drawing.Size(75, 23);
            this.btnDrPepper.TabIndex = 3;
            this.btnDrPepper.Text = "Precio";
            this.btnDrPepper.UseVisualStyleBackColor = false;
            this.btnDrPepper.Click += new System.EventHandler(this.btnDrPepper_Click);
            // 
            // cmbDrPepper
            // 
            this.cmbDrPepper.BackColor = System.Drawing.Color.Red;
            this.cmbDrPepper.FormattingEnabled = true;
            this.cmbDrPepper.Items.AddRange(new object[] {
            "Lata 350ml",
            "Botella 600ml"});
            this.cmbDrPepper.Location = new System.Drawing.Point(6, 32);
            this.cmbDrPepper.Name = "cmbDrPepper";
            this.cmbDrPepper.Size = new System.Drawing.Size(137, 21);
            this.cmbDrPepper.TabIndex = 2;
            // 
            // lblRefrescoDrPepper
            // 
            this.lblRefrescoDrPepper.AutoSize = true;
            this.lblRefrescoDrPepper.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefrescoDrPepper.ForeColor = System.Drawing.Color.White;
            this.lblRefrescoDrPepper.Location = new System.Drawing.Point(6, 16);
            this.lblRefrescoDrPepper.Name = "lblRefrescoDrPepper";
            this.lblRefrescoDrPepper.Size = new System.Drawing.Size(139, 13);
            this.lblRefrescoDrPepper.TabIndex = 2;
            this.lblRefrescoDrPepper.Text = "Selecciona tu refresco:";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(319, 18);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(396, 162);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gmbDrPepper);
            this.Controls.Add(this.gmbCocaCola);
            this.Name = "Form1";
            this.Text = "Máquina Expendedora (Precios)";
            this.gmbCocaCola.ResumeLayout(false);
            this.gmbCocaCola.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCocaCola)).EndInit();
            this.gmbDrPepper.ResumeLayout(false);
            this.gmbDrPepper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDrPepper)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gmbCocaCola;
        private System.Windows.Forms.ComboBox cmbCocaCola;
        private System.Windows.Forms.Label lblRefrescoCocaCola;
        private System.Windows.Forms.GroupBox gmbDrPepper;
        private System.Windows.Forms.Label lblRefrescoDrPepper;
        private System.Windows.Forms.Button btnCocaCola;
        private System.Windows.Forms.Button btnDrPepper;
        private System.Windows.Forms.ComboBox cmbDrPepper;
        private System.Windows.Forms.PictureBox picCocaCola;
        private System.Windows.Forms.PictureBox picDrPepper;
        private System.Windows.Forms.Button btnSalir;
    }
}

