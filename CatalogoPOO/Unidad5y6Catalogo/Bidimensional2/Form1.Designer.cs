namespace Bidimensional2
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
            this.gbxArreglo = new System.Windows.Forms.GroupBox();
            this.lblFilas = new System.Windows.Forms.Label();
            this.lblColumnas = new System.Windows.Forms.Label();
            this.txtFilas = new System.Windows.Forms.TextBox();
            this.txtColumnas = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbxAccion = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnPar = new System.Windows.Forms.Button();
            this.txtBuscarNum = new System.Windows.Forms.TextBox();
            this.lblBuscarNum = new System.Windows.Forms.Label();
            this.lblNumPares = new System.Windows.Forms.Label();
            this.btnOperaciones = new System.Windows.Forms.Button();
            this.gbxArreglo.SuspendLayout();
            this.gbxAccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxArreglo
            // 
            this.gbxArreglo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gbxArreglo.Controls.Add(this.btnImprimir);
            this.gbxArreglo.Controls.Add(this.btnIngresar);
            this.gbxArreglo.Controls.Add(this.txtColumnas);
            this.gbxArreglo.Controls.Add(this.txtFilas);
            this.gbxArreglo.Controls.Add(this.lblColumnas);
            this.gbxArreglo.Controls.Add(this.lblFilas);
            this.gbxArreglo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxArreglo.ForeColor = System.Drawing.Color.Black;
            this.gbxArreglo.Location = new System.Drawing.Point(12, 12);
            this.gbxArreglo.Name = "gbxArreglo";
            this.gbxArreglo.Size = new System.Drawing.Size(284, 196);
            this.gbxArreglo.TabIndex = 0;
            this.gbxArreglo.TabStop = false;
            this.gbxArreglo.Text = "Arreglo Bidimensional";
            // 
            // lblFilas
            // 
            this.lblFilas.AutoSize = true;
            this.lblFilas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilas.ForeColor = System.Drawing.Color.Black;
            this.lblFilas.Location = new System.Drawing.Point(42, 41);
            this.lblFilas.Name = "lblFilas";
            this.lblFilas.Size = new System.Drawing.Size(33, 13);
            this.lblFilas.TabIndex = 0;
            this.lblFilas.Text = "Filas";
            // 
            // lblColumnas
            // 
            this.lblColumnas.AutoSize = true;
            this.lblColumnas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumnas.ForeColor = System.Drawing.Color.Black;
            this.lblColumnas.Location = new System.Drawing.Point(197, 41);
            this.lblColumnas.Name = "lblColumnas";
            this.lblColumnas.Size = new System.Drawing.Size(61, 13);
            this.lblColumnas.TabIndex = 1;
            this.lblColumnas.Text = "Columnas";
            // 
            // txtFilas
            // 
            this.txtFilas.Location = new System.Drawing.Point(6, 60);
            this.txtFilas.Name = "txtFilas";
            this.txtFilas.Size = new System.Drawing.Size(100, 22);
            this.txtFilas.TabIndex = 2;
            // 
            // txtColumnas
            // 
            this.txtColumnas.Location = new System.Drawing.Point(178, 60);
            this.txtColumnas.Name = "txtColumnas";
            this.txtColumnas.Size = new System.Drawing.Size(100, 22);
            this.txtColumnas.TabIndex = 3;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.Snow;
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.Black;
            this.btnIngresar.Location = new System.Drawing.Point(21, 156);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.Snow;
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.Black;
            this.btnImprimir.Location = new System.Drawing.Point(190, 156);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 5;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Snow;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.Location = new System.Drawing.Point(511, 226);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Snow;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(12, 226);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // gbxAccion
            // 
            this.gbxAccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gbxAccion.Controls.Add(this.btnBuscar);
            this.gbxAccion.Controls.Add(this.btnPar);
            this.gbxAccion.Controls.Add(this.txtBuscarNum);
            this.gbxAccion.Controls.Add(this.lblBuscarNum);
            this.gbxAccion.Controls.Add(this.lblNumPares);
            this.gbxAccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAccion.ForeColor = System.Drawing.Color.Black;
            this.gbxAccion.Location = new System.Drawing.Point(302, 12);
            this.gbxAccion.Name = "gbxAccion";
            this.gbxAccion.Size = new System.Drawing.Size(284, 196);
            this.gbxAccion.TabIndex = 6;
            this.gbxAccion.TabStop = false;
            this.gbxAccion.Text = "Acción";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Snow;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Location = new System.Drawing.Point(178, 88);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnPar
            // 
            this.btnPar.BackColor = System.Drawing.Color.Snow;
            this.btnPar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPar.ForeColor = System.Drawing.Color.Black;
            this.btnPar.Location = new System.Drawing.Point(26, 60);
            this.btnPar.Name = "btnPar";
            this.btnPar.Size = new System.Drawing.Size(75, 23);
            this.btnPar.TabIndex = 4;
            this.btnPar.Text = "Par";
            this.btnPar.UseVisualStyleBackColor = false;
            this.btnPar.Click += new System.EventHandler(this.btnPar_Click);
            // 
            // txtBuscarNum
            // 
            this.txtBuscarNum.Location = new System.Drawing.Point(165, 60);
            this.txtBuscarNum.Name = "txtBuscarNum";
            this.txtBuscarNum.Size = new System.Drawing.Size(100, 22);
            this.txtBuscarNum.TabIndex = 3;
            this.txtBuscarNum.TextChanged += new System.EventHandler(this.txtBuscarNum_TextChanged);
            // 
            // lblBuscarNum
            // 
            this.lblBuscarNum.AutoSize = true;
            this.lblBuscarNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarNum.ForeColor = System.Drawing.Color.Black;
            this.lblBuscarNum.Location = new System.Drawing.Point(165, 41);
            this.lblBuscarNum.Name = "lblBuscarNum";
            this.lblBuscarNum.Size = new System.Drawing.Size(99, 13);
            this.lblBuscarNum.TabIndex = 1;
            this.lblBuscarNum.Text = "Buscar Números";
            // 
            // lblNumPares
            // 
            this.lblNumPares.AutoSize = true;
            this.lblNumPares.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPares.ForeColor = System.Drawing.Color.Black;
            this.lblNumPares.Location = new System.Drawing.Point(19, 41);
            this.lblNumPares.Name = "lblNumPares";
            this.lblNumPares.Size = new System.Drawing.Size(92, 13);
            this.lblNumPares.TabIndex = 0;
            this.lblNumPares.Text = "Números Pares";
            // 
            // btnOperaciones
            // 
            this.btnOperaciones.BackColor = System.Drawing.Color.Snow;
            this.btnOperaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOperaciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOperaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOperaciones.ForeColor = System.Drawing.Color.Black;
            this.btnOperaciones.Location = new System.Drawing.Point(263, 226);
            this.btnOperaciones.Name = "btnOperaciones";
            this.btnOperaciones.Size = new System.Drawing.Size(75, 23);
            this.btnOperaciones.TabIndex = 8;
            this.btnOperaciones.Text = "Operaciones";
            this.btnOperaciones.UseVisualStyleBackColor = false;
            this.btnOperaciones.Click += new System.EventHandler(this.btnOperaciones_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(598, 261);
            this.Controls.Add(this.btnOperaciones);
            this.Controls.Add(this.gbxAccion);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gbxArreglo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Bidimensional";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxArreglo.ResumeLayout(false);
            this.gbxArreglo.PerformLayout();
            this.gbxAccion.ResumeLayout(false);
            this.gbxAccion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxArreglo;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtColumnas;
        private System.Windows.Forms.TextBox txtFilas;
        private System.Windows.Forms.Label lblColumnas;
        private System.Windows.Forms.Label lblFilas;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox gbxAccion;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnPar;
        private System.Windows.Forms.TextBox txtBuscarNum;
        private System.Windows.Forms.Label lblBuscarNum;
        private System.Windows.Forms.Label lblNumPares;
        private System.Windows.Forms.Button btnOperaciones;
    }
}

