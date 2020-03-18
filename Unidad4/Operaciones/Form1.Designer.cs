namespace Operaciones
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
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.lblValor1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnResultados = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.cboxOperacion = new System.Windows.Forms.ComboBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(15, 25);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(100, 20);
            this.txtValor1.TabIndex = 0;
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(214, 27);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(116, 20);
            this.txtValor2.TabIndex = 1;
            // 
            // lblValor1
            // 
            this.lblValor1.AutoSize = true;
            this.lblValor1.Location = new System.Drawing.Point(12, 9);
            this.lblValor1.Name = "lblValor1";
            this.lblValor1.Size = new System.Drawing.Size(108, 13);
            this.lblValor1.TabIndex = 2;
            this.lblValor1.Text = "Introduce un número:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Introduce otro número:";
            // 
            // btnResultados
            // 
            this.btnResultados.Location = new System.Drawing.Point(336, 25);
            this.btnResultados.Name = "btnResultados";
            this.btnResultados.Size = new System.Drawing.Size(75, 22);
            this.btnResultados.TabIndex = 8;
            this.btnResultados.Text = "Resultado";
            this.btnResultados.UseVisualStyleBackColor = true;
            this.btnResultados.Click += new System.EventHandler(this.btnResultados_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(417, 26);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 9;
            // 
            // cboxOperacion
            // 
            this.cboxOperacion.FormattingEnabled = true;
            this.cboxOperacion.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cboxOperacion.Location = new System.Drawing.Point(144, 26);
            this.cboxOperacion.Name = "cboxOperacion";
            this.cboxOperacion.Size = new System.Drawing.Size(40, 21);
            this.cboxOperacion.TabIndex = 10;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(440, 10);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(58, 13);
            this.lblResultado.TabIndex = 11;
            this.lblResultado.Text = "Resultado:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 55);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.cboxOperacion);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnResultados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblValor1);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.txtValor1);
            this.Name = "Form1";
            this.Text = "Operaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Label lblValor1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnResultados;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.ComboBox cboxOperacion;
        private System.Windows.Forms.Label lblResultado;
    }
}

