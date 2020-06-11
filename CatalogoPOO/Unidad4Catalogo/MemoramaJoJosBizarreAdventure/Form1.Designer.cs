namespace MemoramaJoJosBizarreAdventure
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.pictureboxJoJoLogo = new System.Windows.Forms.PictureBox();
            this.pictureboxGold = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblMemoramaTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo2 = new System.Windows.Forms.Label();
            this.btnReglas = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.errorNombre = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxJoJoLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxGold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureboxJoJoLogo
            // 
            this.pictureboxJoJoLogo.BackColor = System.Drawing.Color.Black;
            this.pictureboxJoJoLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureboxJoJoLogo.Image")));
            this.pictureboxJoJoLogo.Location = new System.Drawing.Point(-1, -13);
            this.pictureboxJoJoLogo.Name = "pictureboxJoJoLogo";
            this.pictureboxJoJoLogo.Size = new System.Drawing.Size(530, 322);
            this.pictureboxJoJoLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureboxJoJoLogo.TabIndex = 0;
            this.pictureboxJoJoLogo.TabStop = false;
            // 
            // pictureboxGold
            // 
            this.pictureboxGold.BackColor = System.Drawing.Color.Black;
            this.pictureboxGold.Image = ((System.Drawing.Image)(resources.GetObject("pictureboxGold.Image")));
            this.pictureboxGold.Location = new System.Drawing.Point(100, -139);
            this.pictureboxGold.Name = "pictureboxGold";
            this.pictureboxGold.Size = new System.Drawing.Size(622, 544);
            this.pictureboxGold.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureboxGold.TabIndex = 1;
            this.pictureboxGold.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Gold;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(596, 203);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblMemoramaTitulo
            // 
            this.lblMemoramaTitulo.AutoSize = true;
            this.lblMemoramaTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblMemoramaTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblMemoramaTitulo.Font = new System.Drawing.Font("Baskerville Old Face", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemoramaTitulo.Location = new System.Drawing.Point(566, 9);
            this.lblMemoramaTitulo.Name = "lblMemoramaTitulo";
            this.lblMemoramaTitulo.Size = new System.Drawing.Size(130, 27);
            this.lblMemoramaTitulo.TabIndex = 5;
            this.lblMemoramaTitulo.Text = "Memorama";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitulo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblSubtitulo.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.Location = new System.Drawing.Point(532, 36);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(187, 18);
            this.lblSubtitulo.TabIndex = 6;
            this.lblSubtitulo.Text = "JoJo\'s Bizarre Adventure";
            // 
            // lblSubtitulo2
            // 
            this.lblSubtitulo2.AutoSize = true;
            this.lblSubtitulo2.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitulo2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblSubtitulo2.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo2.Location = new System.Drawing.Point(577, 54);
            this.lblSubtitulo2.Name = "lblSubtitulo2";
            this.lblSubtitulo2.Size = new System.Drawing.Size(107, 18);
            this.lblSubtitulo2.TabIndex = 7;
            this.lblSubtitulo2.Text = "Golden Wind";
            // 
            // btnReglas
            // 
            this.btnReglas.BackColor = System.Drawing.Color.Gold;
            this.btnReglas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReglas.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btnReglas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.btnReglas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btnReglas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReglas.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReglas.Location = new System.Drawing.Point(596, 232);
            this.btnReglas.Name = "btnReglas";
            this.btnReglas.Size = new System.Drawing.Size(75, 23);
            this.btnReglas.TabIndex = 8;
            this.btnReglas.Text = "Reglas";
            this.btnReglas.UseVisualStyleBackColor = false;
            this.btnReglas.Click += new System.EventHandler(this.btnReglas_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Gold;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrar.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(596, 261);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblNombre.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(565, 110);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(140, 14);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Introduce tu nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Baskerville Old Face", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(584, 127);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 11;
            // 
            // errorNombre
            // 
            this.errorNombre.ContainerControl = this;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(721, 296);
            this.ControlBox = false;
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnReglas);
            this.Controls.Add(this.lblSubtitulo2);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblMemoramaTitulo);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pictureboxJoJoLogo);
            this.Controls.Add(this.pictureboxGold);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(737, 335);
            this.MinimumSize = new System.Drawing.Size(737, 335);
            this.Name = "Menu";
            this.Text = "JoJo\'s Bizarre Adventure: Golden Wind (Menú)";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxJoJoLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxGold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureboxJoJoLogo;
        private System.Windows.Forms.PictureBox pictureboxGold;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblMemoramaTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblSubtitulo2;
        public System.Windows.Forms.Button btnReglas;
        public System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ErrorProvider errorNombre;
    }
}

