namespace CapturaDeCalificaciones
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
            this.lblCalif = new System.Windows.Forms.Label();
            this.txtCalif = new System.Windows.Forms.TextBox();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.lblAprobados = new System.Windows.Forms.Label();
            this.lblReprobados = new System.Windows.Forms.Label();
            this.btnReporte = new System.Windows.Forms.Button();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCalif
            // 
            this.lblCalif.AutoSize = true;
            this.lblCalif.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalif.Location = new System.Drawing.Point(12, 9);
            this.lblCalif.Name = "lblCalif";
            this.lblCalif.Size = new System.Drawing.Size(126, 15);
            this.lblCalif.TabIndex = 0;
            this.lblCalif.Text = "Calificación obtenida:";
            // 
            // txtCalif
            // 
            this.txtCalif.Location = new System.Drawing.Point(144, 7);
            this.txtCalif.Name = "txtCalif";
            this.txtCalif.Size = new System.Drawing.Size(38, 20);
            this.txtCalif.TabIndex = 1;
            // 
            // btnCapturar
            // 
            this.btnCapturar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapturar.Location = new System.Drawing.Point(188, 5);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(75, 23);
            this.btnCapturar.TabIndex = 2;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // lblAprobados
            // 
            this.lblAprobados.AutoSize = true;
            this.lblAprobados.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAprobados.Location = new System.Drawing.Point(12, 39);
            this.lblAprobados.Name = "lblAprobados";
            this.lblAprobados.Size = new System.Drawing.Size(69, 15);
            this.lblAprobados.TabIndex = 3;
            this.lblAprobados.Text = "Aprobados:";
            // 
            // lblReprobados
            // 
            this.lblReprobados.AutoSize = true;
            this.lblReprobados.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReprobados.Location = new System.Drawing.Point(6, 66);
            this.lblReprobados.Name = "lblReprobados";
            this.lblReprobados.Size = new System.Drawing.Size(75, 15);
            this.lblReprobados.TabIndex = 4;
            this.lblReprobados.Text = "Reprobados:";
            // 
            // btnReporte
            // 
            this.btnReporte.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.Location = new System.Drawing.Point(188, 58);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(75, 23);
            this.btnReporte.TabIndex = 5;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedio.Location = new System.Drawing.Point(57, 93);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(125, 19);
            this.lblPromedio.TabIndex = 6;
            this.lblPromedio.Text = "Promedio total:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.lblReprobados);
            this.Controls.Add(this.lblAprobados);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.txtCalif);
            this.Controls.Add(this.lblCalif);
            this.Name = "Form1";
            this.Text = "Registro de calificaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCalif;
        private System.Windows.Forms.TextBox txtCalif;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.Label lblAprobados;
        private System.Windows.Forms.Label lblReprobados;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Label lblPromedio;
    }
}

