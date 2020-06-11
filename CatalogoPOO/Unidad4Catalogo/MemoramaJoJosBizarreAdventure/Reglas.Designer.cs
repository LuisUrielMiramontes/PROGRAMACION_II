namespace MemoramaJoJosBizarreAdventure
{
    partial class Reglas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reglas));
            this.lblReglasTitulo = new System.Windows.Forms.Label();
            this.lblReglasTexto = new System.Windows.Forms.Label();
            this.pictureboxReglas1 = new System.Windows.Forms.PictureBox();
            this.pictureboxReglas2 = new System.Windows.Forms.PictureBox();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxReglas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxReglas2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReglasTitulo
            // 
            this.lblReglasTitulo.AutoSize = true;
            this.lblReglasTitulo.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReglasTitulo.Location = new System.Drawing.Point(65, 9);
            this.lblReglasTitulo.Name = "lblReglasTitulo";
            this.lblReglasTitulo.Size = new System.Drawing.Size(164, 24);
            this.lblReglasTitulo.TabIndex = 0;
            this.lblReglasTitulo.Text = "Reglas del juego:";
            // 
            // lblReglasTexto
            // 
            this.lblReglasTexto.AutoSize = true;
            this.lblReglasTexto.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReglasTexto.Location = new System.Drawing.Point(2, 33);
            this.lblReglasTexto.Name = "lblReglasTexto";
            this.lblReglasTexto.Size = new System.Drawing.Size(273, 70);
            this.lblReglasTexto.TabIndex = 1;
            this.lblReglasTexto.Text = resources.GetString("lblReglasTexto.Text");
            this.lblReglasTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureboxReglas1
            // 
            this.pictureboxReglas1.Image = ((System.Drawing.Image)(resources.GetObject("pictureboxReglas1.Image")));
            this.pictureboxReglas1.Location = new System.Drawing.Point(-945, 0);
            this.pictureboxReglas1.Name = "pictureboxReglas1";
            this.pictureboxReglas1.Size = new System.Drawing.Size(1697, 262);
            this.pictureboxReglas1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureboxReglas1.TabIndex = 2;
            this.pictureboxReglas1.TabStop = false;
            // 
            // pictureboxReglas2
            // 
            this.pictureboxReglas2.Image = ((System.Drawing.Image)(resources.GetObject("pictureboxReglas2.Image")));
            this.pictureboxReglas2.Location = new System.Drawing.Point(134, 0);
            this.pictureboxReglas2.Name = "pictureboxReglas2";
            this.pictureboxReglas2.Size = new System.Drawing.Size(642, 262);
            this.pictureboxReglas2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureboxReglas2.TabIndex = 3;
            this.pictureboxReglas2.TabStop = false;
            // 
            // btnOk
            // 
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOk.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(190, 226);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // Reglas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(277, 261);
            this.ControlBox = false;
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblReglasTexto);
            this.Controls.Add(this.lblReglasTitulo);
            this.Controls.Add(this.pictureboxReglas2);
            this.Controls.Add(this.pictureboxReglas1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(293, 300);
            this.MinimumSize = new System.Drawing.Size(293, 300);
            this.Name = "Reglas";
            this.Text = "Reglas";
            this.Load += new System.EventHandler(this.Reglas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxReglas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxReglas2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReglasTitulo;
        private System.Windows.Forms.Label lblReglasTexto;
        private System.Windows.Forms.PictureBox pictureboxReglas1;
        private System.Windows.Forms.PictureBox pictureboxReglas2;
        public System.Windows.Forms.Button btnOk;
    }
}