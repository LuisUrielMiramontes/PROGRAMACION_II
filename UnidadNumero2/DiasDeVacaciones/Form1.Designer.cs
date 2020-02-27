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
            this.btnResultado = new System.Windows.Forms.Button();
            this.lblTrabajados = new System.Windows.Forms.Label();
            this.txtAnios = new System.Windows.Forms.TextBox();
            this.lblDias = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(197, 226);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnResultado
            // 
            this.btnResultado.Location = new System.Drawing.Point(173, 61);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(100, 23);
            this.btnResultado.TabIndex = 2;
            this.btnResultado.Text = "Resultado";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // lblTrabajados
            // 
            this.lblTrabajados.AutoSize = true;
            this.lblTrabajados.Location = new System.Drawing.Point(12, 9);
            this.lblTrabajados.Name = "lblTrabajados";
            this.lblTrabajados.Size = new System.Drawing.Size(155, 13);
            this.lblTrabajados.TabIndex = 3;
            this.lblTrabajados.Text = "Años trabajados en la empresa:";
            // 
            // txtAnios
            // 
            this.txtAnios.Location = new System.Drawing.Point(173, 6);
            this.txtAnios.Name = "txtAnios";
            this.txtAnios.Size = new System.Drawing.Size(100, 20);
            this.txtAnios.TabIndex = 4;
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(12, 42);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(86, 13);
            this.lblDias.TabIndex = 5;
            this.lblDias.Text = "Número de días:";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(173, 32);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(99, 23);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 261);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.txtAnios);
            this.Controls.Add(this.lblTrabajados);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnSalir);
            this.Name = "Form1";
            this.Text = "Vacaciones para empleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.Label lblTrabajados;
        private System.Windows.Forms.TextBox txtAnios;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Button btnNuevo;
    }
}

