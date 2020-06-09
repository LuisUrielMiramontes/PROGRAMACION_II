namespace MatrizSumaFCD
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
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.nudFilasColumnas = new System.Windows.Forms.NumericUpDown();
            this.lblFilasColumnas = new System.Windows.Forms.Label();
            this.rtbMatriz = new System.Windows.Forms.RichTextBox();
            this.btnSumarFilas = new System.Windows.Forms.Button();
            this.btnSumarColumnas = new System.Windows.Forms.Button();
            this.btnSumarDiagonal = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.rtbFilas = new System.Windows.Forms.RichTextBox();
            this.rtbColumnas = new System.Windows.Forms.RichTextBox();
            this.rtbDiagonal = new System.Windows.Forms.RichTextBox();
            this.lblFilasDatos = new System.Windows.Forms.Label();
            this.lblDatosColumna = new System.Windows.Forms.Label();
            this.lblDatosDiagonal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudFilasColumnas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(81, 82);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(87, 23);
            this.btnImprimir.TabIndex = 5;
            this.btnImprimir.Text = "Imprimir Matriz";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(81, 53);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(87, 23);
            this.btnCapturar.TabIndex = 6;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // nudFilasColumnas
            // 
            this.nudFilasColumnas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nudFilasColumnas.Location = new System.Drawing.Point(81, 27);
            this.nudFilasColumnas.Name = "nudFilasColumnas";
            this.nudFilasColumnas.Size = new System.Drawing.Size(87, 20);
            this.nudFilasColumnas.TabIndex = 9;
            // 
            // lblFilasColumnas
            // 
            this.lblFilasColumnas.AutoSize = true;
            this.lblFilasColumnas.Location = new System.Drawing.Point(80, 9);
            this.lblFilasColumnas.Name = "lblFilasColumnas";
            this.lblFilasColumnas.Size = new System.Drawing.Size(88, 13);
            this.lblFilasColumnas.TabIndex = 10;
            this.lblFilasColumnas.Text = "Filas y Columnas:";
            // 
            // rtbMatriz
            // 
            this.rtbMatriz.Location = new System.Drawing.Point(174, 9);
            this.rtbMatriz.Name = "rtbMatriz";
            this.rtbMatriz.Size = new System.Drawing.Size(100, 96);
            this.rtbMatriz.TabIndex = 12;
            this.rtbMatriz.Text = "";
            // 
            // btnSumarFilas
            // 
            this.btnSumarFilas.Location = new System.Drawing.Point(174, 111);
            this.btnSumarFilas.Name = "btnSumarFilas";
            this.btnSumarFilas.Size = new System.Drawing.Size(100, 23);
            this.btnSumarFilas.TabIndex = 13;
            this.btnSumarFilas.Text = "Sumar Filas";
            this.btnSumarFilas.UseVisualStyleBackColor = true;
            this.btnSumarFilas.Click += new System.EventHandler(this.btnSumarFilas_Click);
            // 
            // btnSumarColumnas
            // 
            this.btnSumarColumnas.Location = new System.Drawing.Point(174, 140);
            this.btnSumarColumnas.Name = "btnSumarColumnas";
            this.btnSumarColumnas.Size = new System.Drawing.Size(100, 23);
            this.btnSumarColumnas.TabIndex = 14;
            this.btnSumarColumnas.Text = "Sumar Columnas";
            this.btnSumarColumnas.UseVisualStyleBackColor = true;
            this.btnSumarColumnas.Click += new System.EventHandler(this.btnSumarColumnas_Click);
            // 
            // btnSumarDiagonal
            // 
            this.btnSumarDiagonal.Location = new System.Drawing.Point(174, 169);
            this.btnSumarDiagonal.Name = "btnSumarDiagonal";
            this.btnSumarDiagonal.Size = new System.Drawing.Size(100, 23);
            this.btnSumarDiagonal.TabIndex = 15;
            this.btnSumarDiagonal.Text = "Sumar Diagonal";
            this.btnSumarDiagonal.UseVisualStyleBackColor = true;
            this.btnSumarDiagonal.Click += new System.EventHandler(this.btnSumarDiagonal_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(174, 226);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(98, 23);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // rtbFilas
            // 
            this.rtbFilas.Location = new System.Drawing.Point(101, 111);
            this.rtbFilas.Name = "rtbFilas";
            this.rtbFilas.Size = new System.Drawing.Size(65, 23);
            this.rtbFilas.TabIndex = 17;
            this.rtbFilas.Text = "";
            // 
            // rtbColumnas
            // 
            this.rtbColumnas.Location = new System.Drawing.Point(101, 140);
            this.rtbColumnas.Name = "rtbColumnas";
            this.rtbColumnas.Size = new System.Drawing.Size(65, 23);
            this.rtbColumnas.TabIndex = 18;
            this.rtbColumnas.Text = "";
            // 
            // rtbDiagonal
            // 
            this.rtbDiagonal.Location = new System.Drawing.Point(101, 169);
            this.rtbDiagonal.Name = "rtbDiagonal";
            this.rtbDiagonal.Size = new System.Drawing.Size(65, 23);
            this.rtbDiagonal.TabIndex = 19;
            this.rtbDiagonal.Text = "";
            // 
            // lblFilasDatos
            // 
            this.lblFilasDatos.AutoSize = true;
            this.lblFilasDatos.Location = new System.Drawing.Point(12, 115);
            this.lblFilasDatos.Name = "lblFilasDatos";
            this.lblFilasDatos.Size = new System.Drawing.Size(57, 13);
            this.lblFilasDatos.TabIndex = 20;
            this.lblFilasDatos.Text = "Datos Fila:";
            // 
            // lblDatosColumna
            // 
            this.lblDatosColumna.AutoSize = true;
            this.lblDatosColumna.Location = new System.Drawing.Point(12, 144);
            this.lblDatosColumna.Name = "lblDatosColumna";
            this.lblDatosColumna.Size = new System.Drawing.Size(82, 13);
            this.lblDatosColumna.TabIndex = 21;
            this.lblDatosColumna.Text = "Datos Columna:";
            // 
            // lblDatosDiagonal
            // 
            this.lblDatosDiagonal.AutoSize = true;
            this.lblDatosDiagonal.Location = new System.Drawing.Point(12, 173);
            this.lblDatosDiagonal.Name = "lblDatosDiagonal";
            this.lblDatosDiagonal.Size = new System.Drawing.Size(83, 13);
            this.lblDatosDiagonal.TabIndex = 22;
            this.lblDatosDiagonal.Text = "Datos Diagonal:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblDatosDiagonal);
            this.Controls.Add(this.lblDatosColumna);
            this.Controls.Add(this.lblFilasDatos);
            this.Controls.Add(this.rtbDiagonal);
            this.Controls.Add(this.rtbColumnas);
            this.Controls.Add(this.rtbFilas);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnSumarDiagonal);
            this.Controls.Add(this.btnSumarColumnas);
            this.Controls.Add(this.btnSumarFilas);
            this.Controls.Add(this.rtbMatriz);
            this.Controls.Add(this.lblFilasColumnas);
            this.Controls.Add(this.nudFilasColumnas);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.btnImprimir);
            this.Name = "Form1";
            this.Text = "Matriz Suma";
            ((System.ComponentModel.ISupportInitialize)(this.nudFilasColumnas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.NumericUpDown nudFilasColumnas;
        private System.Windows.Forms.Label lblFilasColumnas;
        private System.Windows.Forms.RichTextBox rtbMatriz;
        private System.Windows.Forms.Button btnSumarFilas;
        private System.Windows.Forms.Button btnSumarColumnas;
        private System.Windows.Forms.Button btnSumarDiagonal;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.RichTextBox rtbFilas;
        private System.Windows.Forms.RichTextBox rtbColumnas;
        private System.Windows.Forms.RichTextBox rtbDiagonal;
        private System.Windows.Forms.Label lblFilasDatos;
        private System.Windows.Forms.Label lblDatosColumna;
        private System.Windows.Forms.Label lblDatosDiagonal;
    }
}

