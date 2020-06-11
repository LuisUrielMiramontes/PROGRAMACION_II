namespace Temperatura
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
            this.lblIntroducir = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblGrados = new System.Windows.Forms.Label();
            this.txtGrados = new System.Windows.Forms.TextBox();
            this.cboxTipo = new System.Windows.Forms.ComboBox();
            this.btnResultado = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIntroducir
            // 
            this.lblIntroducir.AutoSize = true;
            this.lblIntroducir.Location = new System.Drawing.Point(10, 25);
            this.lblIntroducir.Name = "lblIntroducir";
            this.lblIntroducir.Size = new System.Drawing.Size(90, 13);
            this.lblIntroducir.TabIndex = 0;
            this.lblIntroducir.Text = "Introduce grados:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(24, 60);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(76, 13);
            this.lblTipo.TabIndex = 1;
            this.lblTipo.Text = "Tipo de grado:";
            // 
            // lblGrados
            // 
            this.lblGrados.AutoSize = true;
            this.lblGrados.Location = new System.Drawing.Point(54, 103);
            this.lblGrados.Name = "lblGrados";
            this.lblGrados.Size = new System.Drawing.Size(44, 13);
            this.lblGrados.TabIndex = 3;
            this.lblGrados.Text = "Grados:";
            // 
            // txtGrados
            // 
            this.txtGrados.Location = new System.Drawing.Point(133, 22);
            this.txtGrados.Name = "txtGrados";
            this.txtGrados.Size = new System.Drawing.Size(100, 20);
            this.txtGrados.TabIndex = 4;
            this.txtGrados.TextChanged += new System.EventHandler(this.txtGrados_TextChanged);
            // 
            // cboxTipo
            // 
            this.cboxTipo.FormattingEnabled = true;
            this.cboxTipo.Items.AddRange(new object[] {
            "Fahrenheit",
            "Celsius"});
            this.cboxTipo.Location = new System.Drawing.Point(133, 57);
            this.cboxTipo.Name = "cboxTipo";
            this.cboxTipo.Size = new System.Drawing.Size(100, 21);
            this.cboxTipo.TabIndex = 5;
            // 
            // btnResultado
            // 
            this.btnResultado.Location = new System.Drawing.Point(23, 139);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(75, 23);
            this.btnResultado.TabIndex = 6;
            this.btnResultado.Text = "Resultados";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(197, 226);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.cboxTipo);
            this.Controls.Add(this.txtGrados);
            this.Controls.Add(this.lblGrados);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblIntroducir);
            this.Name = "Form1";
            this.Text = "Temperatura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIntroducir;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblGrados;
        private System.Windows.Forms.TextBox txtGrados;
        private System.Windows.Forms.ComboBox cboxTipo;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.Button btnSalir;
    }
}

