namespace Empleados_Restaurante
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
            this.btnSalarioMesero = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gmbMesero = new System.Windows.Forms.GroupBox();
            this.dtpFechaMesero = new System.Windows.Forms.DateTimePicker();
            this.cmbDiasMesero = new System.Windows.Forms.ComboBox();
            this.txtSueldoMesero = new System.Windows.Forms.TextBox();
            this.lblDiasMesero = new System.Windows.Forms.Label();
            this.lblSueldoMesero = new System.Windows.Forms.Label();
            this.txtPropinaMesero = new System.Windows.Forms.TextBox();
            this.txtNombreMesero = new System.Windows.Forms.TextBox();
            this.lblPropinaMesero = new System.Windows.Forms.Label();
            this.lblFechaMesero = new System.Windows.Forms.Label();
            this.lblNombreMesero = new System.Windows.Forms.Label();
            this.gmbRepartidor = new System.Windows.Forms.GroupBox();
            this.dtpFechaRepartidor = new System.Windows.Forms.DateTimePicker();
            this.cmbDiasRepartidor = new System.Windows.Forms.ComboBox();
            this.lblDiasRepartidor = new System.Windows.Forms.Label();
            this.btnSalarioRepartidor = new System.Windows.Forms.Button();
            this.txtSueldoRepartidor = new System.Windows.Forms.TextBox();
            this.lblSueloRepartidor = new System.Windows.Forms.Label();
            this.txtAbonosRepartidor = new System.Windows.Forms.TextBox();
            this.lblAbonosRepartidor = new System.Windows.Forms.Label();
            this.cmbZonaRepartidor = new System.Windows.Forms.ComboBox();
            this.lblZonaRepartidor = new System.Windows.Forms.Label();
            this.txtPropinaRepartidor = new System.Windows.Forms.TextBox();
            this.txtNombreRepartidor = new System.Windows.Forms.TextBox();
            this.lblPropinaRepartidor = new System.Windows.Forms.Label();
            this.lblFechaRepartidor = new System.Windows.Forms.Label();
            this.lblNombreRepartidor = new System.Windows.Forms.Label();
            this.gmbCajero = new System.Windows.Forms.GroupBox();
            this.dtpFechaCajero = new System.Windows.Forms.DateTimePicker();
            this.cmbNumeroCaja = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSueldoCajero = new System.Windows.Forms.TextBox();
            this.btnSalarioCajero = new System.Windows.Forms.Button();
            this.cmbDiasCajero = new System.Windows.Forms.ComboBox();
            this.lblSueldoCajero = new System.Windows.Forms.Label();
            this.txtNombreCajero = new System.Windows.Forms.TextBox();
            this.lblDiasCajero = new System.Windows.Forms.Label();
            this.lblFechaCajero = new System.Windows.Forms.Label();
            this.lblNombreCajero = new System.Windows.Forms.Label();
            this.gmbMesero.SuspendLayout();
            this.gmbRepartidor.SuspendLayout();
            this.gmbCajero.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalarioMesero
            // 
            this.btnSalarioMesero.Location = new System.Drawing.Point(79, 179);
            this.btnSalarioMesero.Name = "btnSalarioMesero";
            this.btnSalarioMesero.Size = new System.Drawing.Size(75, 23);
            this.btnSalarioMesero.TabIndex = 1;
            this.btnSalarioMesero.Text = "Salario";
            this.btnSalarioMesero.UseVisualStyleBackColor = true;
            this.btnSalarioMesero.Click += new System.EventHandler(this.btnSalarioMesero_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(432, 251);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // gmbMesero
            // 
            this.gmbMesero.Controls.Add(this.dtpFechaMesero);
            this.gmbMesero.Controls.Add(this.cmbDiasMesero);
            this.gmbMesero.Controls.Add(this.txtSueldoMesero);
            this.gmbMesero.Controls.Add(this.lblDiasMesero);
            this.gmbMesero.Controls.Add(this.lblSueldoMesero);
            this.gmbMesero.Controls.Add(this.btnSalarioMesero);
            this.gmbMesero.Controls.Add(this.txtPropinaMesero);
            this.gmbMesero.Controls.Add(this.txtNombreMesero);
            this.gmbMesero.Controls.Add(this.lblPropinaMesero);
            this.gmbMesero.Controls.Add(this.lblFechaMesero);
            this.gmbMesero.Controls.Add(this.lblNombreMesero);
            this.gmbMesero.Location = new System.Drawing.Point(12, 12);
            this.gmbMesero.Name = "gmbMesero";
            this.gmbMesero.Size = new System.Drawing.Size(160, 208);
            this.gmbMesero.TabIndex = 3;
            this.gmbMesero.TabStop = false;
            this.gmbMesero.Text = "Mesero";
            // 
            // dtpFechaMesero
            // 
            this.dtpFechaMesero.Location = new System.Drawing.Point(9, 64);
            this.dtpFechaMesero.Name = "dtpFechaMesero";
            this.dtpFechaMesero.Size = new System.Drawing.Size(145, 20);
            this.dtpFechaMesero.TabIndex = 10;
            this.dtpFechaMesero.Value = new System.DateTime(2020, 3, 15, 0, 0, 0, 0);
            // 
            // cmbDiasMesero
            // 
            this.cmbDiasMesero.FormattingEnabled = true;
            this.cmbDiasMesero.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cmbDiasMesero.Location = new System.Drawing.Point(97, 121);
            this.cmbDiasMesero.Name = "cmbDiasMesero";
            this.cmbDiasMesero.Size = new System.Drawing.Size(57, 21);
            this.cmbDiasMesero.TabIndex = 9;
            // 
            // txtSueldoMesero
            // 
            this.txtSueldoMesero.Location = new System.Drawing.Point(54, 152);
            this.txtSueldoMesero.Name = "txtSueldoMesero";
            this.txtSueldoMesero.Size = new System.Drawing.Size(100, 20);
            this.txtSueldoMesero.TabIndex = 8;
            // 
            // lblDiasMesero
            // 
            this.lblDiasMesero.AutoSize = true;
            this.lblDiasMesero.Location = new System.Drawing.Point(6, 124);
            this.lblDiasMesero.Name = "lblDiasMesero";
            this.lblDiasMesero.Size = new System.Drawing.Size(85, 13);
            this.lblDiasMesero.TabIndex = 7;
            this.lblDiasMesero.Text = "Días trabajados:";
            // 
            // lblSueldoMesero
            // 
            this.lblSueldoMesero.AutoSize = true;
            this.lblSueldoMesero.Location = new System.Drawing.Point(6, 155);
            this.lblSueldoMesero.Name = "lblSueldoMesero";
            this.lblSueldoMesero.Size = new System.Drawing.Size(43, 13);
            this.lblSueldoMesero.TabIndex = 6;
            this.lblSueldoMesero.Text = "Sueldo:";
            // 
            // txtPropinaMesero
            // 
            this.txtPropinaMesero.Location = new System.Drawing.Point(97, 90);
            this.txtPropinaMesero.Name = "txtPropinaMesero";
            this.txtPropinaMesero.Size = new System.Drawing.Size(57, 20);
            this.txtPropinaMesero.TabIndex = 5;
            // 
            // txtNombreMesero
            // 
            this.txtNombreMesero.Location = new System.Drawing.Point(54, 13);
            this.txtNombreMesero.Name = "txtNombreMesero";
            this.txtNombreMesero.Size = new System.Drawing.Size(100, 20);
            this.txtNombreMesero.TabIndex = 3;
            // 
            // lblPropinaMesero
            // 
            this.lblPropinaMesero.AutoSize = true;
            this.lblPropinaMesero.Location = new System.Drawing.Point(6, 93);
            this.lblPropinaMesero.Name = "lblPropinaMesero";
            this.lblPropinaMesero.Size = new System.Drawing.Size(88, 13);
            this.lblPropinaMesero.TabIndex = 2;
            this.lblPropinaMesero.Text = "Propina semanal:";
            // 
            // lblFechaMesero
            // 
            this.lblFechaMesero.AutoSize = true;
            this.lblFechaMesero.Location = new System.Drawing.Point(6, 45);
            this.lblFechaMesero.Name = "lblFechaMesero";
            this.lblFechaMesero.Size = new System.Drawing.Size(109, 13);
            this.lblFechaMesero.TabIndex = 1;
            this.lblFechaMesero.Text = "Fecha de nacimiento:";
            // 
            // lblNombreMesero
            // 
            this.lblNombreMesero.AutoSize = true;
            this.lblNombreMesero.Location = new System.Drawing.Point(6, 16);
            this.lblNombreMesero.Name = "lblNombreMesero";
            this.lblNombreMesero.Size = new System.Drawing.Size(47, 13);
            this.lblNombreMesero.TabIndex = 0;
            this.lblNombreMesero.Text = "Nombre:";
            // 
            // gmbRepartidor
            // 
            this.gmbRepartidor.Controls.Add(this.dtpFechaRepartidor);
            this.gmbRepartidor.Controls.Add(this.cmbDiasRepartidor);
            this.gmbRepartidor.Controls.Add(this.lblDiasRepartidor);
            this.gmbRepartidor.Controls.Add(this.btnSalarioRepartidor);
            this.gmbRepartidor.Controls.Add(this.txtSueldoRepartidor);
            this.gmbRepartidor.Controls.Add(this.lblSueloRepartidor);
            this.gmbRepartidor.Controls.Add(this.txtAbonosRepartidor);
            this.gmbRepartidor.Controls.Add(this.lblAbonosRepartidor);
            this.gmbRepartidor.Controls.Add(this.cmbZonaRepartidor);
            this.gmbRepartidor.Controls.Add(this.lblZonaRepartidor);
            this.gmbRepartidor.Controls.Add(this.txtPropinaRepartidor);
            this.gmbRepartidor.Controls.Add(this.txtNombreRepartidor);
            this.gmbRepartidor.Controls.Add(this.lblPropinaRepartidor);
            this.gmbRepartidor.Controls.Add(this.lblFechaRepartidor);
            this.gmbRepartidor.Controls.Add(this.lblNombreRepartidor);
            this.gmbRepartidor.Location = new System.Drawing.Point(178, 12);
            this.gmbRepartidor.Name = "gmbRepartidor";
            this.gmbRepartidor.Size = new System.Drawing.Size(164, 262);
            this.gmbRepartidor.TabIndex = 4;
            this.gmbRepartidor.TabStop = false;
            this.gmbRepartidor.Text = "Repartidor";
            // 
            // dtpFechaRepartidor
            // 
            this.dtpFechaRepartidor.Location = new System.Drawing.Point(9, 64);
            this.dtpFechaRepartidor.Name = "dtpFechaRepartidor";
            this.dtpFechaRepartidor.Size = new System.Drawing.Size(149, 20);
            this.dtpFechaRepartidor.TabIndex = 18;
            this.dtpFechaRepartidor.Value = new System.DateTime(2020, 3, 15, 0, 0, 0, 0);
            // 
            // cmbDiasRepartidor
            // 
            this.cmbDiasRepartidor.FormattingEnabled = true;
            this.cmbDiasRepartidor.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cmbDiasRepartidor.Location = new System.Drawing.Point(97, 121);
            this.cmbDiasRepartidor.Name = "cmbDiasRepartidor";
            this.cmbDiasRepartidor.Size = new System.Drawing.Size(61, 21);
            this.cmbDiasRepartidor.TabIndex = 17;
            // 
            // lblDiasRepartidor
            // 
            this.lblDiasRepartidor.AutoSize = true;
            this.lblDiasRepartidor.Location = new System.Drawing.Point(6, 124);
            this.lblDiasRepartidor.Name = "lblDiasRepartidor";
            this.lblDiasRepartidor.Size = new System.Drawing.Size(85, 13);
            this.lblDiasRepartidor.TabIndex = 16;
            this.lblDiasRepartidor.Text = "Días trabajados:";
            // 
            // btnSalarioRepartidor
            // 
            this.btnSalarioRepartidor.Location = new System.Drawing.Point(83, 233);
            this.btnSalarioRepartidor.Name = "btnSalarioRepartidor";
            this.btnSalarioRepartidor.Size = new System.Drawing.Size(75, 23);
            this.btnSalarioRepartidor.TabIndex = 15;
            this.btnSalarioRepartidor.Text = "Salario";
            this.btnSalarioRepartidor.UseVisualStyleBackColor = true;
            this.btnSalarioRepartidor.Click += new System.EventHandler(this.btnSalarioRepartidor_Click);
            // 
            // txtSueldoRepartidor
            // 
            this.txtSueldoRepartidor.Location = new System.Drawing.Point(52, 207);
            this.txtSueldoRepartidor.Name = "txtSueldoRepartidor";
            this.txtSueldoRepartidor.Size = new System.Drawing.Size(106, 20);
            this.txtSueldoRepartidor.TabIndex = 14;
            // 
            // lblSueloRepartidor
            // 
            this.lblSueloRepartidor.AutoSize = true;
            this.lblSueloRepartidor.Location = new System.Drawing.Point(6, 210);
            this.lblSueloRepartidor.Name = "lblSueloRepartidor";
            this.lblSueloRepartidor.Size = new System.Drawing.Size(43, 13);
            this.lblSueloRepartidor.TabIndex = 13;
            this.lblSueloRepartidor.Text = "Sueldo:";
            // 
            // txtAbonosRepartidor
            // 
            this.txtAbonosRepartidor.Location = new System.Drawing.Point(97, 181);
            this.txtAbonosRepartidor.Name = "txtAbonosRepartidor";
            this.txtAbonosRepartidor.Size = new System.Drawing.Size(61, 20);
            this.txtAbonosRepartidor.TabIndex = 12;
            // 
            // lblAbonosRepartidor
            // 
            this.lblAbonosRepartidor.AutoSize = true;
            this.lblAbonosRepartidor.Location = new System.Drawing.Point(6, 184);
            this.lblAbonosRepartidor.Name = "lblAbonosRepartidor";
            this.lblAbonosRepartidor.Size = new System.Drawing.Size(87, 13);
            this.lblAbonosRepartidor.TabIndex = 11;
            this.lblAbonosRepartidor.Text = "Total de abonos:";
            // 
            // cmbZonaRepartidor
            // 
            this.cmbZonaRepartidor.FormattingEnabled = true;
            this.cmbZonaRepartidor.Items.AddRange(new object[] {
            "Zona 1",
            "Zona 2"});
            this.cmbZonaRepartidor.Location = new System.Drawing.Point(98, 152);
            this.cmbZonaRepartidor.Name = "cmbZonaRepartidor";
            this.cmbZonaRepartidor.Size = new System.Drawing.Size(61, 21);
            this.cmbZonaRepartidor.TabIndex = 10;
            // 
            // lblZonaRepartidor
            // 
            this.lblZonaRepartidor.AutoSize = true;
            this.lblZonaRepartidor.Location = new System.Drawing.Point(6, 155);
            this.lblZonaRepartidor.Name = "lblZonaRepartidor";
            this.lblZonaRepartidor.Size = new System.Drawing.Size(86, 13);
            this.lblZonaRepartidor.TabIndex = 9;
            this.lblZonaRepartidor.Text = "Zona de reparto:";
            // 
            // txtPropinaRepartidor
            // 
            this.txtPropinaRepartidor.Location = new System.Drawing.Point(97, 90);
            this.txtPropinaRepartidor.Name = "txtPropinaRepartidor";
            this.txtPropinaRepartidor.Size = new System.Drawing.Size(61, 20);
            this.txtPropinaRepartidor.TabIndex = 8;
            // 
            // txtNombreRepartidor
            // 
            this.txtNombreRepartidor.Location = new System.Drawing.Point(58, 13);
            this.txtNombreRepartidor.Name = "txtNombreRepartidor";
            this.txtNombreRepartidor.Size = new System.Drawing.Size(100, 20);
            this.txtNombreRepartidor.TabIndex = 6;
            // 
            // lblPropinaRepartidor
            // 
            this.lblPropinaRepartidor.AutoSize = true;
            this.lblPropinaRepartidor.Location = new System.Drawing.Point(6, 93);
            this.lblPropinaRepartidor.Name = "lblPropinaRepartidor";
            this.lblPropinaRepartidor.Size = new System.Drawing.Size(88, 13);
            this.lblPropinaRepartidor.TabIndex = 2;
            this.lblPropinaRepartidor.Text = "Propina semanal:";
            // 
            // lblFechaRepartidor
            // 
            this.lblFechaRepartidor.AutoSize = true;
            this.lblFechaRepartidor.Location = new System.Drawing.Point(6, 45);
            this.lblFechaRepartidor.Name = "lblFechaRepartidor";
            this.lblFechaRepartidor.Size = new System.Drawing.Size(109, 13);
            this.lblFechaRepartidor.TabIndex = 1;
            this.lblFechaRepartidor.Text = "Fecha de nacimiento:";
            // 
            // lblNombreRepartidor
            // 
            this.lblNombreRepartidor.AutoSize = true;
            this.lblNombreRepartidor.Location = new System.Drawing.Point(6, 16);
            this.lblNombreRepartidor.Name = "lblNombreRepartidor";
            this.lblNombreRepartidor.Size = new System.Drawing.Size(47, 13);
            this.lblNombreRepartidor.TabIndex = 0;
            this.lblNombreRepartidor.Text = "Nombre:";
            // 
            // gmbCajero
            // 
            this.gmbCajero.Controls.Add(this.dtpFechaCajero);
            this.gmbCajero.Controls.Add(this.cmbNumeroCaja);
            this.gmbCajero.Controls.Add(this.label1);
            this.gmbCajero.Controls.Add(this.txtSueldoCajero);
            this.gmbCajero.Controls.Add(this.btnSalarioCajero);
            this.gmbCajero.Controls.Add(this.cmbDiasCajero);
            this.gmbCajero.Controls.Add(this.lblSueldoCajero);
            this.gmbCajero.Controls.Add(this.txtNombreCajero);
            this.gmbCajero.Controls.Add(this.lblDiasCajero);
            this.gmbCajero.Controls.Add(this.lblFechaCajero);
            this.gmbCajero.Controls.Add(this.lblNombreCajero);
            this.gmbCajero.Location = new System.Drawing.Point(348, 12);
            this.gmbCajero.Name = "gmbCajero";
            this.gmbCajero.Size = new System.Drawing.Size(167, 208);
            this.gmbCajero.TabIndex = 5;
            this.gmbCajero.TabStop = false;
            this.gmbCajero.Text = "Cajero";
            // 
            // dtpFechaCajero
            // 
            this.dtpFechaCajero.Location = new System.Drawing.Point(9, 64);
            this.dtpFechaCajero.Name = "dtpFechaCajero";
            this.dtpFechaCajero.Size = new System.Drawing.Size(150, 20);
            this.dtpFechaCajero.TabIndex = 20;
            this.dtpFechaCajero.Value = new System.DateTime(2020, 3, 15, 0, 0, 0, 0);
            // 
            // cmbNumeroCaja
            // 
            this.cmbNumeroCaja.FormattingEnabled = true;
            this.cmbNumeroCaja.Items.AddRange(new object[] {
            "Caja 1",
            "Caja 2"});
            this.cmbNumeroCaja.Location = new System.Drawing.Point(97, 89);
            this.cmbNumeroCaja.Name = "cmbNumeroCaja";
            this.cmbNumeroCaja.Size = new System.Drawing.Size(62, 21);
            this.cmbNumeroCaja.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Número de caja:";
            // 
            // txtSueldoCajero
            // 
            this.txtSueldoCajero.Location = new System.Drawing.Point(55, 153);
            this.txtSueldoCajero.Name = "txtSueldoCajero";
            this.txtSueldoCajero.Size = new System.Drawing.Size(106, 20);
            this.txtSueldoCajero.TabIndex = 17;
            // 
            // btnSalarioCajero
            // 
            this.btnSalarioCajero.Location = new System.Drawing.Point(86, 179);
            this.btnSalarioCajero.Name = "btnSalarioCajero";
            this.btnSalarioCajero.Size = new System.Drawing.Size(75, 23);
            this.btnSalarioCajero.TabIndex = 16;
            this.btnSalarioCajero.Text = "Salario";
            this.btnSalarioCajero.UseVisualStyleBackColor = true;
            this.btnSalarioCajero.Click += new System.EventHandler(this.btnSalarioCajero_Click);
            // 
            // cmbDiasCajero
            // 
            this.cmbDiasCajero.FormattingEnabled = true;
            this.cmbDiasCajero.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cmbDiasCajero.Location = new System.Drawing.Point(97, 121);
            this.cmbDiasCajero.Name = "cmbDiasCajero";
            this.cmbDiasCajero.Size = new System.Drawing.Size(64, 21);
            this.cmbDiasCajero.TabIndex = 7;
            // 
            // lblSueldoCajero
            // 
            this.lblSueldoCajero.AutoSize = true;
            this.lblSueldoCajero.Location = new System.Drawing.Point(6, 155);
            this.lblSueldoCajero.Name = "lblSueldoCajero";
            this.lblSueldoCajero.Size = new System.Drawing.Size(43, 13);
            this.lblSueldoCajero.TabIndex = 6;
            this.lblSueldoCajero.Text = "Sueldo:";
            // 
            // txtNombreCajero
            // 
            this.txtNombreCajero.Location = new System.Drawing.Point(59, 13);
            this.txtNombreCajero.Name = "txtNombreCajero";
            this.txtNombreCajero.Size = new System.Drawing.Size(100, 20);
            this.txtNombreCajero.TabIndex = 3;
            // 
            // lblDiasCajero
            // 
            this.lblDiasCajero.AutoSize = true;
            this.lblDiasCajero.Location = new System.Drawing.Point(6, 124);
            this.lblDiasCajero.Name = "lblDiasCajero";
            this.lblDiasCajero.Size = new System.Drawing.Size(85, 13);
            this.lblDiasCajero.TabIndex = 2;
            this.lblDiasCajero.Text = "Días trabajados:";
            // 
            // lblFechaCajero
            // 
            this.lblFechaCajero.AutoSize = true;
            this.lblFechaCajero.Location = new System.Drawing.Point(6, 45);
            this.lblFechaCajero.Name = "lblFechaCajero";
            this.lblFechaCajero.Size = new System.Drawing.Size(109, 13);
            this.lblFechaCajero.TabIndex = 1;
            this.lblFechaCajero.Text = "Fecha de nacimiento:";
            // 
            // lblNombreCajero
            // 
            this.lblNombreCajero.AutoSize = true;
            this.lblNombreCajero.Location = new System.Drawing.Point(6, 16);
            this.lblNombreCajero.Name = "lblNombreCajero";
            this.lblNombreCajero.Size = new System.Drawing.Size(47, 13);
            this.lblNombreCajero.TabIndex = 0;
            this.lblNombreCajero.Text = "Nombre:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 282);
            this.Controls.Add(this.gmbCajero);
            this.Controls.Add(this.gmbRepartidor);
            this.Controls.Add(this.gmbMesero);
            this.Controls.Add(this.btnSalir);
            this.Name = "Form1";
            this.Text = "Empleados";
            this.gmbMesero.ResumeLayout(false);
            this.gmbMesero.PerformLayout();
            this.gmbRepartidor.ResumeLayout(false);
            this.gmbRepartidor.PerformLayout();
            this.gmbCajero.ResumeLayout(false);
            this.gmbCajero.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSalarioMesero;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox gmbMesero;
        private System.Windows.Forms.Label lblPropinaMesero;
        private System.Windows.Forms.Label lblFechaMesero;
        private System.Windows.Forms.Label lblNombreMesero;
        private System.Windows.Forms.GroupBox gmbRepartidor;
        private System.Windows.Forms.Label lblPropinaRepartidor;
        private System.Windows.Forms.Label lblFechaRepartidor;
        private System.Windows.Forms.Label lblNombreRepartidor;
        private System.Windows.Forms.GroupBox gmbCajero;
        private System.Windows.Forms.Label lblDiasCajero;
        private System.Windows.Forms.Label lblFechaCajero;
        private System.Windows.Forms.Label lblNombreCajero;
        private System.Windows.Forms.TextBox txtNombreMesero;
        private System.Windows.Forms.TextBox txtNombreRepartidor;
        private System.Windows.Forms.TextBox txtNombreCajero;
        private System.Windows.Forms.TextBox txtPropinaMesero;
        private System.Windows.Forms.TextBox txtPropinaRepartidor;
        private System.Windows.Forms.Label lblSueldoMesero;
        private System.Windows.Forms.Label lblZonaRepartidor;
        private System.Windows.Forms.Label lblSueldoCajero;
        private System.Windows.Forms.TextBox txtSueldoMesero;
        private System.Windows.Forms.Label lblDiasMesero;
        private System.Windows.Forms.ComboBox cmbDiasMesero;
        private System.Windows.Forms.ComboBox cmbZonaRepartidor;
        private System.Windows.Forms.TextBox txtAbonosRepartidor;
        private System.Windows.Forms.Label lblAbonosRepartidor;
        private System.Windows.Forms.Button btnSalarioRepartidor;
        private System.Windows.Forms.TextBox txtSueldoRepartidor;
        private System.Windows.Forms.Label lblSueloRepartidor;
        private System.Windows.Forms.ComboBox cmbDiasRepartidor;
        private System.Windows.Forms.Label lblDiasRepartidor;
        private System.Windows.Forms.ComboBox cmbDiasCajero;
        private System.Windows.Forms.TextBox txtSueldoCajero;
        private System.Windows.Forms.Button btnSalarioCajero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbNumeroCaja;
        private System.Windows.Forms.DateTimePicker dtpFechaMesero;
        private System.Windows.Forms.DateTimePicker dtpFechaRepartidor;
        private System.Windows.Forms.DateTimePicker dtpFechaCajero;
    }
}

