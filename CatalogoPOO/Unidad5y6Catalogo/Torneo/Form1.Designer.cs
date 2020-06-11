namespace Torneo
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
            this.lblNombreTorneo = new System.Windows.Forms.Label();
            this.lblNumEquipos = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.gbxDatosTorneo = new System.Windows.Forms.GroupBox();
            this.btnGanador = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnResultados = new System.Windows.Forms.Button();
            this.txtNombreTorneo = new System.Windows.Forms.TextBox();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.nudNumEquipos = new System.Windows.Forms.NumericUpDown();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbxDatosTorneo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumEquipos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreTorneo
            // 
            this.lblNombreTorneo.AutoSize = true;
            this.lblNombreTorneo.Location = new System.Drawing.Point(6, 16);
            this.lblNombreTorneo.Name = "lblNombreTorneo";
            this.lblNombreTorneo.Size = new System.Drawing.Size(97, 13);
            this.lblNombreTorneo.TabIndex = 0;
            this.lblNombreTorneo.Text = "Nombre del torneo:";
            // 
            // lblNumEquipos
            // 
            this.lblNumEquipos.AutoSize = true;
            this.lblNumEquipos.Location = new System.Drawing.Point(6, 43);
            this.lblNumEquipos.Name = "lblNumEquipos";
            this.lblNumEquipos.Size = new System.Drawing.Size(102, 13);
            this.lblNumEquipos.TabIndex = 1;
            this.lblNumEquipos.Text = "Número de equipos:";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(6, 69);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(82, 13);
            this.lblFechaInicio.TabIndex = 3;
            this.lblFechaInicio.Text = "Fecha de inicio:";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(6, 94);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(69, 13);
            this.lblFechaFin.TabIndex = 4;
            this.lblFechaFin.Text = "Fecha de fin:";
            // 
            // gbxDatosTorneo
            // 
            this.gbxDatosTorneo.Controls.Add(this.btnGanador);
            this.gbxDatosTorneo.Controls.Add(this.btnBorrar);
            this.gbxDatosTorneo.Controls.Add(this.btnGuardar);
            this.gbxDatosTorneo.Controls.Add(this.btnResultados);
            this.gbxDatosTorneo.Controls.Add(this.txtNombreTorneo);
            this.gbxDatosTorneo.Controls.Add(this.dtpFechaFin);
            this.gbxDatosTorneo.Controls.Add(this.dtpFechaInicio);
            this.gbxDatosTorneo.Controls.Add(this.nudNumEquipos);
            this.gbxDatosTorneo.Controls.Add(this.lblNumEquipos);
            this.gbxDatosTorneo.Controls.Add(this.lblNombreTorneo);
            this.gbxDatosTorneo.Controls.Add(this.lblFechaInicio);
            this.gbxDatosTorneo.Controls.Add(this.lblFechaFin);
            this.gbxDatosTorneo.Location = new System.Drawing.Point(12, 12);
            this.gbxDatosTorneo.Name = "gbxDatosTorneo";
            this.gbxDatosTorneo.Size = new System.Drawing.Size(225, 172);
            this.gbxDatosTorneo.TabIndex = 8;
            this.gbxDatosTorneo.TabStop = false;
            this.gbxDatosTorneo.Text = "Datos del torneo";
            // 
            // btnGanador
            // 
            this.btnGanador.Location = new System.Drawing.Point(144, 143);
            this.btnGanador.Name = "btnGanador";
            this.btnGanador.Size = new System.Drawing.Size(75, 23);
            this.btnGanador.TabIndex = 12;
            this.btnGanador.Text = "Ganador";
            this.btnGanador.UseVisualStyleBackColor = true;
            this.btnGanador.Click += new System.EventHandler(this.btnGanador_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(6, 117);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 11;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(6, 143);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnResultados
            // 
            this.btnResultados.Location = new System.Drawing.Point(115, 117);
            this.btnResultados.Name = "btnResultados";
            this.btnResultados.Size = new System.Drawing.Size(104, 23);
            this.btnResultados.TabIndex = 11;
            this.btnResultados.Text = "Ingresar resultados";
            this.btnResultados.UseVisualStyleBackColor = true;
            this.btnResultados.Click += new System.EventHandler(this.btnResultados_Click);
            // 
            // txtNombreTorneo
            // 
            this.txtNombreTorneo.Location = new System.Drawing.Point(115, 13);
            this.txtNombreTorneo.Name = "txtNombreTorneo";
            this.txtNombreTorneo.Size = new System.Drawing.Size(104, 20);
            this.txtNombreTorneo.TabIndex = 9;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(115, 91);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(104, 20);
            this.dtpFechaFin.TabIndex = 8;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(115, 65);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(104, 20);
            this.dtpFechaInicio.TabIndex = 7;
            // 
            // nudNumEquipos
            // 
            this.nudNumEquipos.Location = new System.Drawing.Point(115, 39);
            this.nudNumEquipos.Name = "nudNumEquipos";
            this.nudNumEquipos.Size = new System.Drawing.Size(104, 20);
            this.nudNumEquipos.TabIndex = 5;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(162, 190);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 221);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gbxDatosTorneo);
            this.Name = "Form1";
            this.Text = "Torneo";
            this.gbxDatosTorneo.ResumeLayout(false);
            this.gbxDatosTorneo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumEquipos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombreTorneo;
        private System.Windows.Forms.Label lblNumEquipos;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.GroupBox gbxDatosTorneo;
        private System.Windows.Forms.TextBox txtNombreTorneo;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.NumericUpDown nudNumEquipos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnResultados;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnGanador;
    }
}

