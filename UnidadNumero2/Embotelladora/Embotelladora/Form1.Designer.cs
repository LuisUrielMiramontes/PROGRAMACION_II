namespace Embotelladora
{
    partial class frm
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
            this.NivelLlenado = new System.Windows.Forms.Label();
            this.txtNivelLlenado = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NivelLlenado
            // 
            this.NivelLlenado.AutoSize = true;
            this.NivelLlenado.Location = new System.Drawing.Point(12, 41);
            this.NivelLlenado.Name = "NivelLlenado";
            this.NivelLlenado.Size = new System.Drawing.Size(143, 13);
            this.NivelLlenado.TabIndex = 0;
            this.NivelLlenado.Text = "Introduce el nivel de llenado:";
            this.NivelLlenado.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // txtNivelLlenado
            // 
            this.txtNivelLlenado.Location = new System.Drawing.Point(161, 38);
            this.txtNivelLlenado.Name = "txtNivelLlenado";
            this.txtNivelLlenado.Size = new System.Drawing.Size(85, 20);
            this.txtNivelLlenado.TabIndex = 1;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(161, 64);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(85, 32);
            this.btnVerificar.TabIndex = 2;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click_1);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(12, 64);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(58, 13);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "Resultado:";
            // 
            // frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txtNivelLlenado);
            this.Controls.Add(this.NivelLlenado);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frm";
            this.Text = "Embotelladora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NivelLlenado;
        private System.Windows.Forms.TextBox txtNivelLlenado;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label lblResultado;
    }
}

