namespace Figuras
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
            this.gmbCuadrado = new System.Windows.Forms.GroupBox();
            this.gmbTriangulo = new System.Windows.Forms.GroupBox();
            this.gmbCirculo = new System.Windows.Forms.GroupBox();
            this.lblLadoCuadrado = new System.Windows.Forms.Label();
            this.txtLadoCuadrado = new System.Windows.Forms.TextBox();
            this.btnResultadosCuadrado = new System.Windows.Forms.Button();
            this.lblAreaCuadrado = new System.Windows.Forms.Label();
            this.lblPerimetroCuadrado = new System.Windows.Forms.Label();
            this.lblBaseTriangulo = new System.Windows.Forms.Label();
            this.txtBaseTriangulo = new System.Windows.Forms.TextBox();
            this.lblAlturaTriangulo = new System.Windows.Forms.Label();
            this.txtAlturaTriangulo = new System.Windows.Forms.TextBox();
            this.lblAreaTriangulo = new System.Windows.Forms.Label();
            this.btnResultadosTriangulo = new System.Windows.Forms.Button();
            this.lblPerimetroTriangulo = new System.Windows.Forms.Label();
            this.lblRadioCirculo = new System.Windows.Forms.Label();
            this.txtRadioCirculo = new System.Windows.Forms.TextBox();
            this.lblCircunferenciaCirculo = new System.Windows.Forms.Label();
            this.txtCircunferenciaCirculo = new System.Windows.Forms.TextBox();
            this.btnResultadosCirculo = new System.Windows.Forms.Button();
            this.lblAreaCirculo = new System.Windows.Forms.Label();
            this.lblPerimetroCirculo = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gmbCuadrado.SuspendLayout();
            this.gmbTriangulo.SuspendLayout();
            this.gmbCirculo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gmbCuadrado
            // 
            this.gmbCuadrado.Controls.Add(this.lblPerimetroCuadrado);
            this.gmbCuadrado.Controls.Add(this.lblAreaCuadrado);
            this.gmbCuadrado.Controls.Add(this.btnResultadosCuadrado);
            this.gmbCuadrado.Controls.Add(this.txtLadoCuadrado);
            this.gmbCuadrado.Controls.Add(this.lblLadoCuadrado);
            this.gmbCuadrado.Location = new System.Drawing.Point(13, 12);
            this.gmbCuadrado.Name = "gmbCuadrado";
            this.gmbCuadrado.Size = new System.Drawing.Size(196, 182);
            this.gmbCuadrado.TabIndex = 0;
            this.gmbCuadrado.TabStop = false;
            this.gmbCuadrado.Text = "Cuadrado:";
            // 
            // gmbTriangulo
            // 
            this.gmbTriangulo.Controls.Add(this.lblPerimetroTriangulo);
            this.gmbTriangulo.Controls.Add(this.btnResultadosTriangulo);
            this.gmbTriangulo.Controls.Add(this.lblAreaTriangulo);
            this.gmbTriangulo.Controls.Add(this.txtAlturaTriangulo);
            this.gmbTriangulo.Controls.Add(this.lblAlturaTriangulo);
            this.gmbTriangulo.Controls.Add(this.txtBaseTriangulo);
            this.gmbTriangulo.Controls.Add(this.lblBaseTriangulo);
            this.gmbTriangulo.Location = new System.Drawing.Point(215, 12);
            this.gmbTriangulo.Name = "gmbTriangulo";
            this.gmbTriangulo.Size = new System.Drawing.Size(174, 182);
            this.gmbTriangulo.TabIndex = 1;
            this.gmbTriangulo.TabStop = false;
            this.gmbTriangulo.Text = "Triangulo:";
            // 
            // gmbCirculo
            // 
            this.gmbCirculo.Controls.Add(this.lblPerimetroCirculo);
            this.gmbCirculo.Controls.Add(this.lblAreaCirculo);
            this.gmbCirculo.Controls.Add(this.btnResultadosCirculo);
            this.gmbCirculo.Controls.Add(this.txtCircunferenciaCirculo);
            this.gmbCirculo.Controls.Add(this.lblCircunferenciaCirculo);
            this.gmbCirculo.Controls.Add(this.txtRadioCirculo);
            this.gmbCirculo.Controls.Add(this.lblRadioCirculo);
            this.gmbCirculo.Location = new System.Drawing.Point(395, 9);
            this.gmbCirculo.Name = "gmbCirculo";
            this.gmbCirculo.Size = new System.Drawing.Size(210, 185);
            this.gmbCirculo.TabIndex = 2;
            this.gmbCirculo.TabStop = false;
            this.gmbCirculo.Text = "Círculo:";
            // 
            // lblLadoCuadrado
            // 
            this.lblLadoCuadrado.AutoSize = true;
            this.lblLadoCuadrado.Location = new System.Drawing.Point(19, 16);
            this.lblLadoCuadrado.Name = "lblLadoCuadrado";
            this.lblLadoCuadrado.Size = new System.Drawing.Size(156, 13);
            this.lblLadoCuadrado.TabIndex = 0;
            this.lblLadoCuadrado.Text = "Introduce la medida de un lado:";
            // 
            // txtLadoCuadrado
            // 
            this.txtLadoCuadrado.Location = new System.Drawing.Point(22, 32);
            this.txtLadoCuadrado.Name = "txtLadoCuadrado";
            this.txtLadoCuadrado.Size = new System.Drawing.Size(153, 20);
            this.txtLadoCuadrado.TabIndex = 1;
            // 
            // btnResultadosCuadrado
            // 
            this.btnResultadosCuadrado.Location = new System.Drawing.Point(62, 58);
            this.btnResultadosCuadrado.Name = "btnResultadosCuadrado";
            this.btnResultadosCuadrado.Size = new System.Drawing.Size(75, 23);
            this.btnResultadosCuadrado.TabIndex = 2;
            this.btnResultadosCuadrado.Text = "Resultados";
            this.btnResultadosCuadrado.UseVisualStyleBackColor = true;
            this.btnResultadosCuadrado.Click += new System.EventHandler(this.btnResultadosCuadrado_Click);
            // 
            // lblAreaCuadrado
            // 
            this.lblAreaCuadrado.AutoSize = true;
            this.lblAreaCuadrado.Location = new System.Drawing.Point(6, 84);
            this.lblAreaCuadrado.Name = "lblAreaCuadrado";
            this.lblAreaCuadrado.Size = new System.Drawing.Size(97, 13);
            this.lblAreaCuadrado.TabIndex = 3;
            this.lblAreaCuadrado.Text = "Área del cuadrado:";
            // 
            // lblPerimetroCuadrado
            // 
            this.lblPerimetroCuadrado.AutoSize = true;
            this.lblPerimetroCuadrado.Location = new System.Drawing.Point(6, 106);
            this.lblPerimetroCuadrado.Name = "lblPerimetroCuadrado";
            this.lblPerimetroCuadrado.Size = new System.Drawing.Size(121, 13);
            this.lblPerimetroCuadrado.TabIndex = 4;
            this.lblPerimetroCuadrado.Text = "Perímetro del cuadrado:";
            // 
            // lblBaseTriangulo
            // 
            this.lblBaseTriangulo.AutoSize = true;
            this.lblBaseTriangulo.Location = new System.Drawing.Point(3, 16);
            this.lblBaseTriangulo.Name = "lblBaseTriangulo";
            this.lblBaseTriangulo.Size = new System.Drawing.Size(165, 13);
            this.lblBaseTriangulo.TabIndex = 0;
            this.lblBaseTriangulo.Text = "Introduce la base de un triangulo:";
            // 
            // txtBaseTriangulo
            // 
            this.txtBaseTriangulo.Location = new System.Drawing.Point(6, 32);
            this.txtBaseTriangulo.Name = "txtBaseTriangulo";
            this.txtBaseTriangulo.Size = new System.Drawing.Size(162, 20);
            this.txtBaseTriangulo.TabIndex = 1;
            // 
            // lblAlturaTriangulo
            // 
            this.lblAlturaTriangulo.AutoSize = true;
            this.lblAlturaTriangulo.Location = new System.Drawing.Point(3, 55);
            this.lblAlturaTriangulo.Name = "lblAlturaTriangulo";
            this.lblAlturaTriangulo.Size = new System.Drawing.Size(168, 13);
            this.lblAlturaTriangulo.TabIndex = 2;
            this.lblAlturaTriangulo.Text = "Introduce la altura de un triangulo:";
            // 
            // txtAlturaTriangulo
            // 
            this.txtAlturaTriangulo.Location = new System.Drawing.Point(6, 71);
            this.txtAlturaTriangulo.Name = "txtAlturaTriangulo";
            this.txtAlturaTriangulo.Size = new System.Drawing.Size(162, 20);
            this.txtAlturaTriangulo.TabIndex = 3;
            // 
            // lblAreaTriangulo
            // 
            this.lblAreaTriangulo.AutoSize = true;
            this.lblAreaTriangulo.Location = new System.Drawing.Point(3, 123);
            this.lblAreaTriangulo.Name = "lblAreaTriangulo";
            this.lblAreaTriangulo.Size = new System.Drawing.Size(92, 13);
            this.lblAreaTriangulo.TabIndex = 4;
            this.lblAreaTriangulo.Text = "Área del triangulo:";
            // 
            // btnResultadosTriangulo
            // 
            this.btnResultadosTriangulo.Location = new System.Drawing.Point(50, 97);
            this.btnResultadosTriangulo.Name = "btnResultadosTriangulo";
            this.btnResultadosTriangulo.Size = new System.Drawing.Size(75, 23);
            this.btnResultadosTriangulo.TabIndex = 5;
            this.btnResultadosTriangulo.Text = "Resultados";
            this.btnResultadosTriangulo.UseVisualStyleBackColor = true;
            this.btnResultadosTriangulo.Click += new System.EventHandler(this.btnResultadosTriangulo_Click);
            // 
            // lblPerimetroTriangulo
            // 
            this.lblPerimetroTriangulo.AutoSize = true;
            this.lblPerimetroTriangulo.Location = new System.Drawing.Point(3, 145);
            this.lblPerimetroTriangulo.Name = "lblPerimetroTriangulo";
            this.lblPerimetroTriangulo.Size = new System.Drawing.Size(116, 13);
            this.lblPerimetroTriangulo.TabIndex = 6;
            this.lblPerimetroTriangulo.Text = "Perímetro del triangulo:";
            // 
            // lblRadioCirculo
            // 
            this.lblRadioCirculo.AutoSize = true;
            this.lblRadioCirculo.Location = new System.Drawing.Point(32, 19);
            this.lblRadioCirculo.Name = "lblRadioCirculo";
            this.lblRadioCirculo.Size = new System.Drawing.Size(158, 13);
            this.lblRadioCirculo.TabIndex = 0;
            this.lblRadioCirculo.Text = "Introduce el radio de un círculo:";
            // 
            // txtRadioCirculo
            // 
            this.txtRadioCirculo.Location = new System.Drawing.Point(35, 35);
            this.txtRadioCirculo.Name = "txtRadioCirculo";
            this.txtRadioCirculo.Size = new System.Drawing.Size(155, 20);
            this.txtRadioCirculo.TabIndex = 1;
            // 
            // lblCircunferenciaCirculo
            // 
            this.lblCircunferenciaCirculo.AutoSize = true;
            this.lblCircunferenciaCirculo.Location = new System.Drawing.Point(6, 58);
            this.lblCircunferenciaCirculo.Name = "lblCircunferenciaCirculo";
            this.lblCircunferenciaCirculo.Size = new System.Drawing.Size(202, 13);
            this.lblCircunferenciaCirculo.TabIndex = 2;
            this.lblCircunferenciaCirculo.Text = "Introduce la circunferencia de un círculo:";
            // 
            // txtCircunferenciaCirculo
            // 
            this.txtCircunferenciaCirculo.Location = new System.Drawing.Point(35, 74);
            this.txtCircunferenciaCirculo.Name = "txtCircunferenciaCirculo";
            this.txtCircunferenciaCirculo.Size = new System.Drawing.Size(155, 20);
            this.txtCircunferenciaCirculo.TabIndex = 3;
            // 
            // btnResultadosCirculo
            // 
            this.btnResultadosCirculo.Location = new System.Drawing.Point(78, 99);
            this.btnResultadosCirculo.Name = "btnResultadosCirculo";
            this.btnResultadosCirculo.Size = new System.Drawing.Size(75, 23);
            this.btnResultadosCirculo.TabIndex = 6;
            this.btnResultadosCirculo.Text = "Resultados";
            this.btnResultadosCirculo.UseVisualStyleBackColor = true;
            this.btnResultadosCirculo.Click += new System.EventHandler(this.btnResultadosCirculo_Click);
            // 
            // lblAreaCirculo
            // 
            this.lblAreaCirculo.AutoSize = true;
            this.lblAreaCirculo.Location = new System.Drawing.Point(6, 126);
            this.lblAreaCirculo.Name = "lblAreaCirculo";
            this.lblAreaCirculo.Size = new System.Drawing.Size(85, 13);
            this.lblAreaCirculo.TabIndex = 7;
            this.lblAreaCirculo.Text = "Área del círculo:";
            // 
            // lblPerimetroCirculo
            // 
            this.lblPerimetroCirculo.AutoSize = true;
            this.lblPerimetroCirculo.Location = new System.Drawing.Point(6, 148);
            this.lblPerimetroCirculo.Name = "lblPerimetroCirculo";
            this.lblPerimetroCirculo.Size = new System.Drawing.Size(109, 13);
            this.lblPerimetroCirculo.TabIndex = 8;
            this.lblPerimetroCirculo.Text = "Perímetro del círculo:";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(530, 254);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 289);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gmbCirculo);
            this.Controls.Add(this.gmbTriangulo);
            this.Controls.Add(this.gmbCuadrado);
            this.Name = "Form1";
            this.Text = "Figuras geométricas";
            this.gmbCuadrado.ResumeLayout(false);
            this.gmbCuadrado.PerformLayout();
            this.gmbTriangulo.ResumeLayout(false);
            this.gmbTriangulo.PerformLayout();
            this.gmbCirculo.ResumeLayout(false);
            this.gmbCirculo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gmbCuadrado;
        private System.Windows.Forms.GroupBox gmbTriangulo;
        private System.Windows.Forms.GroupBox gmbCirculo;
        private System.Windows.Forms.Label lblLadoCuadrado;
        private System.Windows.Forms.TextBox txtLadoCuadrado;
        private System.Windows.Forms.Button btnResultadosCuadrado;
        private System.Windows.Forms.Label lblPerimetroCuadrado;
        private System.Windows.Forms.Label lblAreaCuadrado;
        private System.Windows.Forms.Label lblPerimetroTriangulo;
        private System.Windows.Forms.Button btnResultadosTriangulo;
        private System.Windows.Forms.Label lblAreaTriangulo;
        private System.Windows.Forms.TextBox txtAlturaTriangulo;
        private System.Windows.Forms.Label lblAlturaTriangulo;
        private System.Windows.Forms.TextBox txtBaseTriangulo;
        private System.Windows.Forms.Label lblBaseTriangulo;
        private System.Windows.Forms.Label lblPerimetroCirculo;
        private System.Windows.Forms.Label lblAreaCirculo;
        private System.Windows.Forms.Button btnResultadosCirculo;
        private System.Windows.Forms.TextBox txtCircunferenciaCirculo;
        private System.Windows.Forms.Label lblCircunferenciaCirculo;
        private System.Windows.Forms.TextBox txtRadioCirculo;
        private System.Windows.Forms.Label lblRadioCirculo;
        private System.Windows.Forms.Button btnSalir;
    }
}

