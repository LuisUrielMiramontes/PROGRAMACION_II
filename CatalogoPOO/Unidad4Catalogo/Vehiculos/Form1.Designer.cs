namespace Vehiculos
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
            this.btnArrancar = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.lblCombustible = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblLlantas = new System.Windows.Forms.Label();
            this.lblPuertas = new System.Windows.Forms.Label();
            this.lblVentanas = new System.Windows.Forms.Label();
            this.lblTurbinas = new System.Windows.Forms.Label();
            this.lblTipoAereo = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtLlantas = new System.Windows.Forms.TextBox();
            this.txtPuertas = new System.Windows.Forms.TextBox();
            this.txtVentanas = new System.Windows.Forms.TextBox();
            this.txtAlas = new System.Windows.Forms.TextBox();
            this.txtCombustible = new System.Windows.Forms.TextBox();
            this.gboxVehiculo = new System.Windows.Forms.GroupBox();
            this.gboxAereo = new System.Windows.Forms.GroupBox();
            this.cboxTipoAereo = new System.Windows.Forms.ComboBox();
            this.txtHelices = new System.Windows.Forms.TextBox();
            this.lblAlas = new System.Windows.Forms.Label();
            this.lblHelices = new System.Windows.Forms.Label();
            this.txtTurbinas = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnVolar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtSonidoArrancar = new System.Windows.Forms.TextBox();
            this.lblSonido = new System.Windows.Forms.Label();
            this.txtSonidoParar = new System.Windows.Forms.TextBox();
            this.txtSonidoAereo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSonidoArrancar = new System.Windows.Forms.Label();
            this.gboxVehiculo.SuspendLayout();
            this.gboxAereo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(492, 296);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnArrancar
            // 
            this.btnArrancar.Location = new System.Drawing.Point(12, 253);
            this.btnArrancar.Name = "btnArrancar";
            this.btnArrancar.Size = new System.Drawing.Size(75, 23);
            this.btnArrancar.TabIndex = 1;
            this.btnArrancar.Text = "Arrancar";
            this.btnArrancar.UseVisualStyleBackColor = true;
            this.btnArrancar.Click += new System.EventHandler(this.btnArrancar_Click);
            // 
            // btnParar
            // 
            this.btnParar.Location = new System.Drawing.Point(12, 296);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(75, 23);
            this.btnParar.TabIndex = 2;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // lblCombustible
            // 
            this.lblCombustible.AutoSize = true;
            this.lblCombustible.Location = new System.Drawing.Point(6, 25);
            this.lblCombustible.Name = "lblCombustible";
            this.lblCombustible.Size = new System.Drawing.Size(105, 13);
            this.lblCombustible.TabIndex = 3;
            this.lblCombustible.Text = "Tipo de combustible:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(6, 60);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(34, 13);
            this.lblColor.TabIndex = 4;
            this.lblColor.Text = "Color:";
            // 
            // lblLlantas
            // 
            this.lblLlantas.AutoSize = true;
            this.lblLlantas.Location = new System.Drawing.Point(6, 95);
            this.lblLlantas.Name = "lblLlantas";
            this.lblLlantas.Size = new System.Drawing.Size(95, 13);
            this.lblLlantas.TabIndex = 5;
            this.lblLlantas.Text = "Número de llantas:";
            // 
            // lblPuertas
            // 
            this.lblPuertas.AutoSize = true;
            this.lblPuertas.Location = new System.Drawing.Point(6, 131);
            this.lblPuertas.Name = "lblPuertas";
            this.lblPuertas.Size = new System.Drawing.Size(100, 13);
            this.lblPuertas.TabIndex = 6;
            this.lblPuertas.Text = "Número de puertas:";
            // 
            // lblVentanas
            // 
            this.lblVentanas.AutoSize = true;
            this.lblVentanas.Location = new System.Drawing.Point(6, 164);
            this.lblVentanas.Name = "lblVentanas";
            this.lblVentanas.Size = new System.Drawing.Size(109, 13);
            this.lblVentanas.TabIndex = 7;
            this.lblVentanas.Text = "Número de ventanas:";
            // 
            // lblTurbinas
            // 
            this.lblTurbinas.AutoSize = true;
            this.lblTurbinas.Location = new System.Drawing.Point(6, 57);
            this.lblTurbinas.Name = "lblTurbinas";
            this.lblTurbinas.Size = new System.Drawing.Size(102, 13);
            this.lblTurbinas.TabIndex = 8;
            this.lblTurbinas.Text = "Número de turbinas:";
            // 
            // lblTipoAereo
            // 
            this.lblTipoAereo.AutoSize = true;
            this.lblTipoAereo.Location = new System.Drawing.Point(6, 128);
            this.lblTipoAereo.Name = "lblTipoAereo";
            this.lblTipoAereo.Size = new System.Drawing.Size(121, 13);
            this.lblTipoAereo.TabIndex = 9;
            this.lblTipoAereo.Text = "Tipo de vehículo aéreo:";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(117, 57);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(100, 20);
            this.txtColor.TabIndex = 10;
            // 
            // txtLlantas
            // 
            this.txtLlantas.Location = new System.Drawing.Point(117, 92);
            this.txtLlantas.Name = "txtLlantas";
            this.txtLlantas.Size = new System.Drawing.Size(100, 20);
            this.txtLlantas.TabIndex = 11;
            // 
            // txtPuertas
            // 
            this.txtPuertas.Location = new System.Drawing.Point(117, 128);
            this.txtPuertas.Name = "txtPuertas";
            this.txtPuertas.Size = new System.Drawing.Size(100, 20);
            this.txtPuertas.TabIndex = 12;
            // 
            // txtVentanas
            // 
            this.txtVentanas.Location = new System.Drawing.Point(117, 161);
            this.txtVentanas.Name = "txtVentanas";
            this.txtVentanas.Size = new System.Drawing.Size(100, 20);
            this.txtVentanas.TabIndex = 13;
            // 
            // txtAlas
            // 
            this.txtAlas.Location = new System.Drawing.Point(137, 18);
            this.txtAlas.Name = "txtAlas";
            this.txtAlas.Size = new System.Drawing.Size(100, 20);
            this.txtAlas.TabIndex = 14;
            // 
            // txtCombustible
            // 
            this.txtCombustible.Location = new System.Drawing.Point(117, 22);
            this.txtCombustible.Name = "txtCombustible";
            this.txtCombustible.Size = new System.Drawing.Size(100, 20);
            this.txtCombustible.TabIndex = 16;
            // 
            // gboxVehiculo
            // 
            this.gboxVehiculo.Controls.Add(this.lblCombustible);
            this.gboxVehiculo.Controls.Add(this.txtCombustible);
            this.gboxVehiculo.Controls.Add(this.lblColor);
            this.gboxVehiculo.Controls.Add(this.lblLlantas);
            this.gboxVehiculo.Controls.Add(this.lblPuertas);
            this.gboxVehiculo.Controls.Add(this.txtVentanas);
            this.gboxVehiculo.Controls.Add(this.lblVentanas);
            this.gboxVehiculo.Controls.Add(this.txtPuertas);
            this.gboxVehiculo.Controls.Add(this.txtColor);
            this.gboxVehiculo.Controls.Add(this.txtLlantas);
            this.gboxVehiculo.Location = new System.Drawing.Point(12, 12);
            this.gboxVehiculo.Name = "gboxVehiculo";
            this.gboxVehiculo.Size = new System.Drawing.Size(231, 185);
            this.gboxVehiculo.TabIndex = 17;
            this.gboxVehiculo.TabStop = false;
            this.gboxVehiculo.Text = "Datos generales del vehículo";
            // 
            // gboxAereo
            // 
            this.gboxAereo.Controls.Add(this.cboxTipoAereo);
            this.gboxAereo.Controls.Add(this.txtHelices);
            this.gboxAereo.Controls.Add(this.lblAlas);
            this.gboxAereo.Controls.Add(this.lblHelices);
            this.gboxAereo.Controls.Add(this.lblTipoAereo);
            this.gboxAereo.Controls.Add(this.txtTurbinas);
            this.gboxAereo.Controls.Add(this.txtAlas);
            this.gboxAereo.Controls.Add(this.lblTurbinas);
            this.gboxAereo.Location = new System.Drawing.Point(249, 12);
            this.gboxAereo.Name = "gboxAereo";
            this.gboxAereo.Size = new System.Drawing.Size(243, 148);
            this.gboxAereo.TabIndex = 18;
            this.gboxAereo.TabStop = false;
            this.gboxAereo.Text = "Datos específicos aéreos";
            this.gboxAereo.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cboxTipoAereo
            // 
            this.cboxTipoAereo.FormattingEnabled = true;
            this.cboxTipoAereo.Items.AddRange(new object[] {
            "Helicóptero",
            "Avión",
            "Jet",
            "Avioneta"});
            this.cboxTipoAereo.Location = new System.Drawing.Point(137, 123);
            this.cboxTipoAereo.Name = "cboxTipoAereo";
            this.cboxTipoAereo.Size = new System.Drawing.Size(100, 21);
            this.cboxTipoAereo.TabIndex = 23;
            this.cboxTipoAereo.Text = "Seleccionar";
            // 
            // txtHelices
            // 
            this.txtHelices.Location = new System.Drawing.Point(137, 89);
            this.txtHelices.Name = "txtHelices";
            this.txtHelices.Size = new System.Drawing.Size(100, 20);
            this.txtHelices.TabIndex = 22;
            // 
            // lblAlas
            // 
            this.lblAlas.AutoSize = true;
            this.lblAlas.Location = new System.Drawing.Point(6, 22);
            this.lblAlas.Name = "lblAlas";
            this.lblAlas.Size = new System.Drawing.Size(84, 13);
            this.lblAlas.TabIndex = 19;
            this.lblAlas.Text = "Número de alas:";
            // 
            // lblHelices
            // 
            this.lblHelices.AutoSize = true;
            this.lblHelices.Location = new System.Drawing.Point(6, 92);
            this.lblHelices.Name = "lblHelices";
            this.lblHelices.Size = new System.Drawing.Size(98, 13);
            this.lblHelices.TabIndex = 20;
            this.lblHelices.Text = "Número de hélices:";
            // 
            // txtTurbinas
            // 
            this.txtTurbinas.Location = new System.Drawing.Point(137, 53);
            this.txtTurbinas.Name = "txtTurbinas";
            this.txtTurbinas.Size = new System.Drawing.Size(100, 20);
            this.txtTurbinas.TabIndex = 21;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(498, 12);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 19;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnVolar
            // 
            this.btnVolar.Location = new System.Drawing.Point(12, 213);
            this.btnVolar.Name = "btnVolar";
            this.btnVolar.Size = new System.Drawing.Size(75, 23);
            this.btnVolar.TabIndex = 20;
            this.btnVolar.Text = "Volar";
            this.btnVolar.UseVisualStyleBackColor = true;
            this.btnVolar.Click += new System.EventHandler(this.btnVolar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(498, 41);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtSonidoArrancar
            // 
            this.txtSonidoArrancar.Location = new System.Drawing.Point(349, 218);
            this.txtSonidoArrancar.Name = "txtSonidoArrancar";
            this.txtSonidoArrancar.Size = new System.Drawing.Size(100, 20);
            this.txtSonidoArrancar.TabIndex = 22;
            // 
            // lblSonido
            // 
            this.lblSonido.AutoSize = true;
            this.lblSonido.Location = new System.Drawing.Point(225, 202);
            this.lblSonido.Name = "lblSonido";
            this.lblSonido.Size = new System.Drawing.Size(342, 13);
            this.lblSonido.TabIndex = 23;
            this.lblSonido.Text = "Introduce el sonido del vehículo seleccionado al momento de arrancar:";
            // 
            // txtSonidoParar
            // 
            this.txtSonidoParar.Location = new System.Drawing.Point(349, 257);
            this.txtSonidoParar.Name = "txtSonidoParar";
            this.txtSonidoParar.Size = new System.Drawing.Size(100, 20);
            this.txtSonidoParar.TabIndex = 24;
            // 
            // txtSonidoAereo
            // 
            this.txtSonidoAereo.Location = new System.Drawing.Point(349, 179);
            this.txtSonidoAereo.Name = "txtSonidoAereo";
            this.txtSonidoAereo.Size = new System.Drawing.Size(100, 20);
            this.txtSonidoAereo.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Introduce el sonido del vehículo aéreo al momento de volar:";
            // 
            // lblSonidoArrancar
            // 
            this.lblSonidoArrancar.AutoSize = true;
            this.lblSonidoArrancar.Location = new System.Drawing.Point(232, 241);
            this.lblSonidoArrancar.Name = "lblSonidoArrancar";
            this.lblSonidoArrancar.Size = new System.Drawing.Size(327, 13);
            this.lblSonidoArrancar.TabIndex = 27;
            this.lblSonidoArrancar.Text = "Introduce el sonido del vehículo seleccionado al momento de parar:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(579, 331);
            this.Controls.Add(this.lblSonidoArrancar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSonidoAereo);
            this.Controls.Add(this.txtSonidoParar);
            this.Controls.Add(this.lblSonido);
            this.Controls.Add(this.txtSonidoArrancar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnVolar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gboxAereo);
            this.Controls.Add(this.gboxVehiculo);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnArrancar);
            this.Controls.Add(this.btnSalir);
            this.Name = "Form1";
            this.Text = "Motor";
            this.gboxVehiculo.ResumeLayout(false);
            this.gboxVehiculo.PerformLayout();
            this.gboxAereo.ResumeLayout(false);
            this.gboxAereo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnArrancar;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Label lblCombustible;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblLlantas;
        private System.Windows.Forms.Label lblPuertas;
        private System.Windows.Forms.Label lblVentanas;
        private System.Windows.Forms.Label lblTurbinas;
        private System.Windows.Forms.Label lblTipoAereo;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtLlantas;
        private System.Windows.Forms.TextBox txtPuertas;
        private System.Windows.Forms.TextBox txtVentanas;
        private System.Windows.Forms.TextBox txtAlas;
        private System.Windows.Forms.TextBox txtCombustible;
        private System.Windows.Forms.GroupBox gboxVehiculo;
        private System.Windows.Forms.GroupBox gboxAereo;
        private System.Windows.Forms.Label lblAlas;
        private System.Windows.Forms.Label lblHelices;
        private System.Windows.Forms.TextBox txtTurbinas;
        private System.Windows.Forms.TextBox txtHelices;
        private System.Windows.Forms.ComboBox cboxTipoAereo;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnVolar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtSonidoArrancar;
        private System.Windows.Forms.Label lblSonido;
        private System.Windows.Forms.TextBox txtSonidoParar;
        private System.Windows.Forms.TextBox txtSonidoAereo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSonidoArrancar;
    }
}

