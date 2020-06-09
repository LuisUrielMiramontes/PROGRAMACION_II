namespace Bidimensional2
{
    partial class Operaciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxOperacion = new System.Windows.Forms.GroupBox();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnTamañoMatriz = new System.Windows.Forms.Button();
            this.gbxMatriz = new System.Windows.Forms.GroupBox();
            this.btnIngresarDatosA = new System.Windows.Forms.Button();
            this.btnIngresarDatosB = new System.Windows.Forms.Button();
            this.txtColumnas = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnMultiplicacion = new System.Windows.Forms.Button();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.lblIgual = new System.Windows.Forms.Label();
            this.lblAgregacion = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.gbxOperacion.SuspendLayout();
            this.gbxMatriz.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxOperacion
            // 
            this.gbxOperacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gbxOperacion.Controls.Add(this.btnMultiplicacion);
            this.gbxOperacion.Controls.Add(this.btnResta);
            this.gbxOperacion.Controls.Add(this.btnDivision);
            this.gbxOperacion.Controls.Add(this.btnSuma);
            this.gbxOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxOperacion.ForeColor = System.Drawing.Color.Black;
            this.gbxOperacion.Location = new System.Drawing.Point(168, 130);
            this.gbxOperacion.Name = "gbxOperacion";
            this.gbxOperacion.Size = new System.Drawing.Size(273, 119);
            this.gbxOperacion.TabIndex = 8;
            this.gbxOperacion.TabStop = false;
            this.gbxOperacion.Text = "Operación";
            // 
            // btnSuma
            // 
            this.btnSuma.BackColor = System.Drawing.Color.Snow;
            this.btnSuma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuma.ForeColor = System.Drawing.Color.Black;
            this.btnSuma.Location = new System.Drawing.Point(15, 21);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(86, 23);
            this.btnSuma.TabIndex = 5;
            this.btnSuma.Text = "Suma";
            this.btnSuma.UseVisualStyleBackColor = false;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnTamañoMatriz
            // 
            this.btnTamañoMatriz.BackColor = System.Drawing.Color.Snow;
            this.btnTamañoMatriz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTamañoMatriz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTamañoMatriz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTamañoMatriz.ForeColor = System.Drawing.Color.Black;
            this.btnTamañoMatriz.Location = new System.Drawing.Point(32, 37);
            this.btnTamañoMatriz.Name = "btnTamañoMatriz";
            this.btnTamañoMatriz.Size = new System.Drawing.Size(75, 34);
            this.btnTamañoMatriz.TabIndex = 4;
            this.btnTamañoMatriz.Text = "Tamaño Matriz";
            this.btnTamañoMatriz.UseVisualStyleBackColor = false;
            this.btnTamañoMatriz.Click += new System.EventHandler(this.btnTamañoMatriz_Click);
            // 
            // gbxMatriz
            // 
            this.gbxMatriz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gbxMatriz.Controls.Add(this.btnIngresarDatosA);
            this.gbxMatriz.Controls.Add(this.btnTamañoMatriz);
            this.gbxMatriz.Controls.Add(this.btnIngresarDatosB);
            this.gbxMatriz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxMatriz.ForeColor = System.Drawing.Color.Black;
            this.gbxMatriz.Location = new System.Drawing.Point(2, 2);
            this.gbxMatriz.Name = "gbxMatriz";
            this.gbxMatriz.Size = new System.Drawing.Size(145, 196);
            this.gbxMatriz.TabIndex = 7;
            this.gbxMatriz.TabStop = false;
            this.gbxMatriz.Text = "Matriz Bidimensional";
            // 
            // btnIngresarDatosA
            // 
            this.btnIngresarDatosA.BackColor = System.Drawing.Color.Snow;
            this.btnIngresarDatosA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresarDatosA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIngresarDatosA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarDatosA.ForeColor = System.Drawing.Color.Black;
            this.btnIngresarDatosA.Location = new System.Drawing.Point(32, 77);
            this.btnIngresarDatosA.Name = "btnIngresarDatosA";
            this.btnIngresarDatosA.Size = new System.Drawing.Size(75, 35);
            this.btnIngresarDatosA.TabIndex = 5;
            this.btnIngresarDatosA.Text = "Ingresar Datos A";
            this.btnIngresarDatosA.UseVisualStyleBackColor = false;
            this.btnIngresarDatosA.Click += new System.EventHandler(this.btnIngresarDatosA_Click);
            // 
            // btnIngresarDatosB
            // 
            this.btnIngresarDatosB.BackColor = System.Drawing.Color.Snow;
            this.btnIngresarDatosB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresarDatosB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIngresarDatosB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarDatosB.ForeColor = System.Drawing.Color.Black;
            this.btnIngresarDatosB.Location = new System.Drawing.Point(32, 118);
            this.btnIngresarDatosB.Name = "btnIngresarDatosB";
            this.btnIngresarDatosB.Size = new System.Drawing.Size(75, 35);
            this.btnIngresarDatosB.TabIndex = 4;
            this.btnIngresarDatosB.Text = "Ingresar Datos B";
            this.btnIngresarDatosB.UseVisualStyleBackColor = false;
            this.btnIngresarDatosB.Click += new System.EventHandler(this.btnIngresarDatosB_Click);
            // 
            // txtColumnas
            // 
            this.txtColumnas.Location = new System.Drawing.Point(314, 217);
            this.txtColumnas.Name = "txtColumnas";
            this.txtColumnas.Size = new System.Drawing.Size(100, 20);
            this.txtColumnas.TabIndex = 3;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(168, 12);
            this.txtA.Multiline = true;
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 102);
            this.txtA.TabIndex = 2;
            // 
            // btnDivision
            // 
            this.btnDivision.BackColor = System.Drawing.Color.Snow;
            this.btnDivision.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDivision.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivision.ForeColor = System.Drawing.Color.Black;
            this.btnDivision.Location = new System.Drawing.Point(173, 84);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(86, 23);
            this.btnDivision.TabIndex = 6;
            this.btnDivision.Text = "División";
            this.btnDivision.UseVisualStyleBackColor = false;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnResta
            // 
            this.btnResta.BackColor = System.Drawing.Color.Snow;
            this.btnResta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResta.ForeColor = System.Drawing.Color.Black;
            this.btnResta.Location = new System.Drawing.Point(173, 21);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(86, 23);
            this.btnResta.TabIndex = 7;
            this.btnResta.Text = "Resta";
            this.btnResta.UseVisualStyleBackColor = false;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnMultiplicacion
            // 
            this.btnMultiplicacion.BackColor = System.Drawing.Color.Snow;
            this.btnMultiplicacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMultiplicacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMultiplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicacion.ForeColor = System.Drawing.Color.Black;
            this.btnMultiplicacion.Location = new System.Drawing.Point(15, 84);
            this.btnMultiplicacion.Name = "btnMultiplicacion";
            this.btnMultiplicacion.Size = new System.Drawing.Size(86, 23);
            this.btnMultiplicacion.TabIndex = 8;
            this.btnMultiplicacion.Text = "Multiplicación";
            this.btnMultiplicacion.UseVisualStyleBackColor = false;
            this.btnMultiplicacion.Click += new System.EventHandler(this.btnMultiplicacion_Click);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(341, 12);
            this.txtB.Multiline = true;
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 102);
            this.txtB.TabIndex = 9;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(514, 12);
            this.txtC.Multiline = true;
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 102);
            this.txtC.TabIndex = 10;
            // 
            // lblIgual
            // 
            this.lblIgual.AutoSize = true;
            this.lblIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIgual.ForeColor = System.Drawing.Color.Black;
            this.lblIgual.Location = new System.Drawing.Point(470, 56);
            this.lblIgual.Name = "lblIgual";
            this.lblIgual.Size = new System.Drawing.Size(14, 13);
            this.lblIgual.TabIndex = 11;
            this.lblIgual.Text = "=";
            // 
            // lblAgregacion
            // 
            this.lblAgregacion.AutoSize = true;
            this.lblAgregacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregacion.ForeColor = System.Drawing.Color.Black;
            this.lblAgregacion.Location = new System.Drawing.Point(295, 56);
            this.lblAgregacion.Name = "lblAgregacion";
            this.lblAgregacion.Size = new System.Drawing.Size(14, 13);
            this.lblAgregacion.TabIndex = 12;
            this.lblAgregacion.Text = "+";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Snow;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.Location = new System.Drawing.Point(616, 197);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Snow;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.Black;
            this.btnCerrar.Location = new System.Drawing.Point(616, 226);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 14;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Operaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(703, 261);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblAgregacion);
            this.Controls.Add(this.lblIgual);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.gbxOperacion);
            this.Controls.Add(this.gbxMatriz);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtColumnas);
            this.Name = "Operaciones";
            this.Text = "Operaciones";
            this.gbxOperacion.ResumeLayout(false);
            this.gbxMatriz.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxOperacion;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnTamañoMatriz;
        private System.Windows.Forms.GroupBox gbxMatriz;
        private System.Windows.Forms.Button btnIngresarDatosA;
        private System.Windows.Forms.Button btnIngresarDatosB;
        private System.Windows.Forms.TextBox txtColumnas;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Button btnMultiplicacion;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label lblIgual;
        private System.Windows.Forms.Label lblAgregacion;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
    }
}