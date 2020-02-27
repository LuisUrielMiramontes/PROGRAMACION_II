namespace DiasDeVacaciones
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnResultados = new System.Windows.Forms.Button();
            this.lblAnios = new System.Windows.Forms.Label();
            this.lblDias = new System.Windows.Forms.Label();
            this.txtAnios = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(285, 226);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnResultados
            // 
            this.btnResultados.Location = new System.Drawing.Point(233, 4);
            this.btnResultados.Name = "btnResultados";
            this.btnResultados.Size = new System.Drawing.Size(100, 23);
            this.btnResultados.TabIndex = 1;
            this.btnResultados.Text = "Resultados";
            this.btnResultados.UseVisualStyleBackColor = true;
            this.btnResultados.Click += new System.EventHandler(this.btnResultados_Click);
            // 
            // lblAnios
            // 
            this.lblAnios.AutoSize = true;
            this.lblAnios.Location = new System.Drawing.Point(35, 9);
            this.lblAnios.Name = "lblAnios";
            this.lblAnios.Size = new System.Drawing.Size(86, 13);
            this.lblAnios.TabIndex = 2;
            this.lblAnios.Text = "Años trabajados:";
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(35, 45);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(181, 13);
            this.lblDias.TabIndex = 4;
            this.lblDias.Text = "Días de vacaciones correspondidos:";
            // 
            // txtAnios
            // 
            this.txtAnios.Location = new System.Drawing.Point(127, 6);
            this.txtAnios.Name = "txtAnios";
            this.txtAnios.Size = new System.Drawing.Size(100, 20);
            this.txtAnios.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 261);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.txtAnios);
            this.Controls.Add(this.lblAnios);
            this.Controls.Add(this.btnResultados);
            this.Controls.Add(this.btnSalir);
            this.Name = "Form1";
            this.Text = "Días de vacaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnResultados;
        private System.Windows.Forms.Label lblAnios;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.TextBox txtAnios;
    }
}

