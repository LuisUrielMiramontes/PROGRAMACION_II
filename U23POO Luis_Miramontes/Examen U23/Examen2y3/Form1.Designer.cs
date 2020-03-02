namespace Examen2y3
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
            this.lblTrabajados = new System.Windows.Forms.Label();
            this.lblDias = new System.Windows.Forms.Label();
            this.txtAnios = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnResultado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTrabajados
            // 
            this.lblTrabajados.AutoSize = true;
            this.lblTrabajados.Location = new System.Drawing.Point(18, 21);
            this.lblTrabajados.Name = "lblTrabajados";
            this.lblTrabajados.Size = new System.Drawing.Size(86, 13);
            this.lblTrabajados.TabIndex = 0;
            this.lblTrabajados.Text = "Años trabajados:";
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(18, 52);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(181, 13);
            this.lblDias.TabIndex = 1;
            this.lblDias.Text = "Días de vacaciones correspondidos:";
            // 
            // txtAnios
            // 
            this.txtAnios.Location = new System.Drawing.Point(110, 18);
            this.txtAnios.Name = "txtAnios";
            this.txtAnios.Size = new System.Drawing.Size(100, 20);
            this.txtAnios.TabIndex = 2;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(237, 226);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnResultado
            // 
            this.btnResultado.Location = new System.Drawing.Point(216, 17);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(75, 23);
            this.btnResultado.TabIndex = 4;
            this.btnResultado.Text = "Resultados";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 261);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtAnios);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.lblTrabajados);
            this.Name = "Form1";
            this.Text = "Dias de vacaciones";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTrabajados;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.TextBox txtAnios;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnResultado;
    }
}

