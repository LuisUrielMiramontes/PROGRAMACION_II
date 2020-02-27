namespace EntradasDeUnConcierto
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
            this.cboxCategoria = new System.Windows.Forms.ComboBox();
            this.lblAsistente = new System.Windows.Forms.Label();
            this.cboxNumero = new System.Windows.Forms.ComboBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblBebe = new System.Windows.Forms.Label();
            this.lblNiño = new System.Windows.Forms.Label();
            this.lblAdulto = new System.Windows.Forms.Label();
            this.lblTerceraEdad = new System.Windows.Forms.Label();
            this.lblDatos = new System.Windows.Forms.Label();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboxCategoria
            // 
            this.cboxCategoria.BackColor = System.Drawing.Color.Gold;
            this.cboxCategoria.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxCategoria.FormattingEnabled = true;
            this.cboxCategoria.Items.AddRange(new object[] {
            "Bebé",
            "Niño",
            "Adulto",
            "Tercera edad"});
            this.cboxCategoria.Location = new System.Drawing.Point(137, 46);
            this.cboxCategoria.Name = "cboxCategoria";
            this.cboxCategoria.Size = new System.Drawing.Size(121, 23);
            this.cboxCategoria.TabIndex = 0;
            this.cboxCategoria.Text = "Categoría";
            // 
            // lblAsistente
            // 
            this.lblAsistente.AutoSize = true;
            this.lblAsistente.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsistente.ForeColor = System.Drawing.Color.Yellow;
            this.lblAsistente.Location = new System.Drawing.Point(23, 43);
            this.lblAsistente.Name = "lblAsistente";
            this.lblAsistente.Size = new System.Drawing.Size(108, 33);
            this.lblAsistente.TabIndex = 1;
            this.lblAsistente.Text = "Asistente:";
            // 
            // cboxNumero
            // 
            this.cboxNumero.BackColor = System.Drawing.Color.Gold;
            this.cboxNumero.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxNumero.FormattingEnabled = true;
            this.cboxNumero.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cboxNumero.Location = new System.Drawing.Point(137, 75);
            this.cboxNumero.Name = "cboxNumero";
            this.cboxNumero.Size = new System.Drawing.Size(121, 23);
            this.cboxNumero.TabIndex = 2;
            this.cboxNumero.Text = "No. de personas";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Yellow;
            this.lblTitulo.Location = new System.Drawing.Point(87, 6);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(113, 37);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Entradas";
            // 
            // lblBebe
            // 
            this.lblBebe.AutoSize = true;
            this.lblBebe.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBebe.ForeColor = System.Drawing.Color.Gold;
            this.lblBebe.Location = new System.Drawing.Point(54, 104);
            this.lblBebe.Name = "lblBebe";
            this.lblBebe.Size = new System.Drawing.Size(43, 19);
            this.lblBebe.TabIndex = 4;
            this.lblBebe.Text = "Bebés:";
            // 
            // lblNiño
            // 
            this.lblNiño.AutoSize = true;
            this.lblNiño.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNiño.ForeColor = System.Drawing.Color.Gold;
            this.lblNiño.Location = new System.Drawing.Point(55, 123);
            this.lblNiño.Name = "lblNiño";
            this.lblNiño.Size = new System.Drawing.Size(42, 19);
            this.lblNiño.TabIndex = 5;
            this.lblNiño.Text = "Niños:";
            // 
            // lblAdulto
            // 
            this.lblAdulto.AutoSize = true;
            this.lblAdulto.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdulto.ForeColor = System.Drawing.Color.Gold;
            this.lblAdulto.Location = new System.Drawing.Point(43, 142);
            this.lblAdulto.Name = "lblAdulto";
            this.lblAdulto.Size = new System.Drawing.Size(54, 19);
            this.lblAdulto.TabIndex = 6;
            this.lblAdulto.Text = "Adultos:";
            // 
            // lblTerceraEdad
            // 
            this.lblTerceraEdad.AutoSize = true;
            this.lblTerceraEdad.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerceraEdad.ForeColor = System.Drawing.Color.Gold;
            this.lblTerceraEdad.Location = new System.Drawing.Point(12, 161);
            this.lblTerceraEdad.Name = "lblTerceraEdad";
            this.lblTerceraEdad.Size = new System.Drawing.Size(85, 19);
            this.lblTerceraEdad.TabIndex = 7;
            this.lblTerceraEdad.Text = "Tercera edad:";
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Font = new System.Drawing.Font("Segoe Print", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.ForeColor = System.Drawing.Color.Yellow;
            this.lblDatos.Location = new System.Drawing.Point(48, 75);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(54, 26);
            this.lblDatos.TabIndex = 8;
            this.lblDatos.Text = "Datos";
            // 
            // btnCapturar
            // 
            this.btnCapturar.BackColor = System.Drawing.Color.Gold;
            this.btnCapturar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapturar.Location = new System.Drawing.Point(29, 183);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(75, 23);
            this.btnCapturar.TabIndex = 9;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.UseVisualStyleBackColor = false;
            this.btnCapturar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.Color.Gold;
            this.btnReporte.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.Color.Black;
            this.btnReporte.Location = new System.Drawing.Point(29, 212);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(75, 23);
            this.btnReporte.TabIndex = 10;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.lblTerceraEdad);
            this.Controls.Add(this.lblAdulto);
            this.Controls.Add(this.lblNiño);
            this.Controls.Add(this.lblBebe);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.cboxNumero);
            this.Controls.Add(this.lblAsistente);
            this.Controls.Add(this.cboxCategoria);
            this.Name = "Form1";
            this.Text = "Concierto - Green Day";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxCategoria;
        private System.Windows.Forms.Label lblAsistente;
        private System.Windows.Forms.ComboBox cboxNumero;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblBebe;
        private System.Windows.Forms.Label lblNiño;
        private System.Windows.Forms.Label lblAdulto;
        private System.Windows.Forms.Label lblTerceraEdad;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.Button btnReporte;
    }
}

