namespace Recibo
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
            this.lblContrato = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtKilowats = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.cboxContrato = new System.Windows.Forms.ComboBox();
            this.lblRecibo = new System.Windows.Forms.Label();
            this.lblContrat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblContrato
            // 
            this.lblContrato.AutoSize = true;
            this.lblContrato.Location = new System.Drawing.Point(22, 45);
            this.lblContrato.Name = "lblContrato";
            this.lblContrato.Size = new System.Drawing.Size(88, 13);
            this.lblContrato.TabIndex = 1;
            this.lblContrato.Text = "Tipo de contrato:";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(197, 226);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCobrar
            // 
            this.btnCobrar.Location = new System.Drawing.Point(172, 89);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(75, 23);
            this.btnCobrar.TabIndex = 5;
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.UseVisualStyleBackColor = true;
            this.btnCobrar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(172, 121);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtKilowats
            // 
            this.txtKilowats.Location = new System.Drawing.Point(160, 15);
            this.txtKilowats.Name = "txtKilowats";
            this.txtKilowats.Size = new System.Drawing.Size(100, 20);
            this.txtKilowats.TabIndex = 9;
            this.txtKilowats.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(22, 18);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(132, 13);
            this.lblCantidad.TabIndex = 0;
            this.lblCantidad.Text = "Cantidad de kilowats (Kw):";
            this.lblCantidad.Click += new System.EventHandler(this.label1_Click);
            // 
            // cboxContrato
            // 
            this.cboxContrato.FormattingEnabled = true;
            this.cboxContrato.Items.AddRange(new object[] {
            "Hogar",
            "Negocio"});
            this.cboxContrato.Location = new System.Drawing.Point(160, 41);
            this.cboxContrato.Name = "cboxContrato";
            this.cboxContrato.Size = new System.Drawing.Size(100, 21);
            this.cboxContrato.TabIndex = 2;
            this.cboxContrato.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblRecibo
            // 
            this.lblRecibo.AutoSize = true;
            this.lblRecibo.Location = new System.Drawing.Point(34, 94);
            this.lblRecibo.Name = "lblRecibo";
            this.lblRecibo.Size = new System.Drawing.Size(44, 13);
            this.lblRecibo.TabIndex = 10;
            this.lblRecibo.Text = "Recibo:";
            // 
            // lblContrat
            // 
            this.lblContrat.AutoSize = true;
            this.lblContrat.Location = new System.Drawing.Point(28, 126);
            this.lblContrat.Name = "lblContrat";
            this.lblContrat.Size = new System.Drawing.Size(50, 13);
            this.lblContrat.TabIndex = 11;
            this.lblContrat.Text = "Contrato:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblContrat);
            this.Controls.Add(this.lblRecibo);
            this.Controls.Add(this.txtKilowats);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.cboxContrato);
            this.Controls.Add(this.lblContrato);
            this.Controls.Add(this.lblCantidad);
            this.Name = "Form1";
            this.Text = "Recibo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblContrato;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtKilowats;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.ComboBox cboxContrato;
        private System.Windows.Forms.Label lblRecibo;
        private System.Windows.Forms.Label lblContrat;
    }
}

