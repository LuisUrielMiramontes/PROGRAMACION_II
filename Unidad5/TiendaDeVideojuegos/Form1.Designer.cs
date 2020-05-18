namespace TiendaDeVideojuegos
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
            this.gbxDatosTienda = new System.Windows.Forms.GroupBox();
            this.btnImprimirProductos = new System.Windows.Forms.Button();
            this.btnRegistrarProductos = new System.Windows.Forms.Button();
            this.nudNumProductos = new System.Windows.Forms.NumericUpDown();
            this.lblNumProductos = new System.Windows.Forms.Label();
            this.txtNombreTienda = new System.Windows.Forms.TextBox();
            this.lblNombreTienda = new System.Windows.Forms.Label();
            this.gbxProductosRegistrados = new System.Windows.Forms.GroupBox();
            this.rtbProductosRegistrados = new System.Windows.Forms.RichTextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbxDatosTienda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumProductos)).BeginInit();
            this.gbxProductosRegistrados.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxDatosTienda
            // 
            this.gbxDatosTienda.Controls.Add(this.btnImprimirProductos);
            this.gbxDatosTienda.Controls.Add(this.btnRegistrarProductos);
            this.gbxDatosTienda.Controls.Add(this.nudNumProductos);
            this.gbxDatosTienda.Controls.Add(this.lblNumProductos);
            this.gbxDatosTienda.Controls.Add(this.txtNombreTienda);
            this.gbxDatosTienda.Controls.Add(this.lblNombreTienda);
            this.gbxDatosTienda.Location = new System.Drawing.Point(12, 12);
            this.gbxDatosTienda.Name = "gbxDatosTienda";
            this.gbxDatosTienda.Size = new System.Drawing.Size(260, 130);
            this.gbxDatosTienda.TabIndex = 0;
            this.gbxDatosTienda.TabStop = false;
            this.gbxDatosTienda.Text = "Datos de la tienda de videojuegos";
            // 
            // btnImprimirProductos
            // 
            this.btnImprimirProductos.Location = new System.Drawing.Point(117, 100);
            this.btnImprimirProductos.Name = "btnImprimirProductos";
            this.btnImprimirProductos.Size = new System.Drawing.Size(137, 23);
            this.btnImprimirProductos.TabIndex = 5;
            this.btnImprimirProductos.Text = "Imprimir productos";
            this.btnImprimirProductos.UseVisualStyleBackColor = true;
            this.btnImprimirProductos.Click += new System.EventHandler(this.btnImprimirProductos_Click);
            // 
            // btnRegistrarProductos
            // 
            this.btnRegistrarProductos.Location = new System.Drawing.Point(117, 71);
            this.btnRegistrarProductos.Name = "btnRegistrarProductos";
            this.btnRegistrarProductos.Size = new System.Drawing.Size(137, 23);
            this.btnRegistrarProductos.TabIndex = 4;
            this.btnRegistrarProductos.Text = "Registrar productos";
            this.btnRegistrarProductos.UseVisualStyleBackColor = true;
            this.btnRegistrarProductos.Click += new System.EventHandler(this.btnRegistrarProductos_Click);
            // 
            // nudNumProductos
            // 
            this.nudNumProductos.Location = new System.Drawing.Point(173, 45);
            this.nudNumProductos.Name = "nudNumProductos";
            this.nudNumProductos.Size = new System.Drawing.Size(81, 20);
            this.nudNumProductos.TabIndex = 3;
            // 
            // lblNumProductos
            // 
            this.lblNumProductos.AutoSize = true;
            this.lblNumProductos.Location = new System.Drawing.Point(6, 48);
            this.lblNumProductos.Name = "lblNumProductos";
            this.lblNumProductos.Size = new System.Drawing.Size(161, 13);
            this.lblNumProductos.TabIndex = 2;
            this.lblNumProductos.Text = "Número de productos a registrar:";
            // 
            // txtNombreTienda
            // 
            this.txtNombreTienda.Location = new System.Drawing.Point(117, 19);
            this.txtNombreTienda.Name = "txtNombreTienda";
            this.txtNombreTienda.Size = new System.Drawing.Size(137, 20);
            this.txtNombreTienda.TabIndex = 1;
            // 
            // lblNombreTienda
            // 
            this.lblNombreTienda.AutoSize = true;
            this.lblNombreTienda.Location = new System.Drawing.Point(6, 22);
            this.lblNombreTienda.Name = "lblNombreTienda";
            this.lblNombreTienda.Size = new System.Drawing.Size(105, 13);
            this.lblNombreTienda.TabIndex = 0;
            this.lblNombreTienda.Text = "Nombre de la tienda:";
            // 
            // gbxProductosRegistrados
            // 
            this.gbxProductosRegistrados.Controls.Add(this.rtbProductosRegistrados);
            this.gbxProductosRegistrados.Location = new System.Drawing.Point(278, 12);
            this.gbxProductosRegistrados.Name = "gbxProductosRegistrados";
            this.gbxProductosRegistrados.Size = new System.Drawing.Size(364, 237);
            this.gbxProductosRegistrados.TabIndex = 6;
            this.gbxProductosRegistrados.TabStop = false;
            this.gbxProductosRegistrados.Text = "Productos registrados:";
            // 
            // rtbProductosRegistrados
            // 
            this.rtbProductosRegistrados.Location = new System.Drawing.Point(6, 19);
            this.rtbProductosRegistrados.Name = "rtbProductosRegistrados";
            this.rtbProductosRegistrados.Size = new System.Drawing.Size(352, 212);
            this.rtbProductosRegistrados.TabIndex = 0;
            this.rtbProductosRegistrados.Text = "";
            this.rtbProductosRegistrados.TextChanged += new System.EventHandler(this.rtbProductosRegistrados_TextChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(129, 220);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(137, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 261);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gbxProductosRegistrados);
            this.Controls.Add(this.gbxDatosTienda);
            this.Name = "Form1";
            this.Text = "Tienda de videojuegos";
            this.gbxDatosTienda.ResumeLayout(false);
            this.gbxDatosTienda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumProductos)).EndInit();
            this.gbxProductosRegistrados.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxDatosTienda;
        private System.Windows.Forms.TextBox txtNombreTienda;
        private System.Windows.Forms.Label lblNombreTienda;
        private System.Windows.Forms.NumericUpDown nudNumProductos;
        private System.Windows.Forms.Label lblNumProductos;
        private System.Windows.Forms.Button btnRegistrarProductos;
        private System.Windows.Forms.Button btnImprimirProductos;
        private System.Windows.Forms.GroupBox gbxProductosRegistrados;
        private System.Windows.Forms.RichTextBox rtbProductosRegistrados;
        private System.Windows.Forms.Button btnSalir;
    }
}

