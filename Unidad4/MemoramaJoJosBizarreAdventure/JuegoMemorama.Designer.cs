namespace MemoramaJoJosBizarreAdventure
{
    partial class JuegoMemorama
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JuegoMemorama));
            this.panelMemorama = new System.Windows.Forms.Panel();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.lblRecord = new System.Windows.Forms.Label();
            this.lblNumeroRecord = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblNombreMemorama = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelMemorama
            // 
            this.panelMemorama.BackColor = System.Drawing.Color.Transparent;
            this.panelMemorama.Location = new System.Drawing.Point(3, 103);
            this.panelMemorama.Name = "panelMemorama";
            this.panelMemorama.Size = new System.Drawing.Size(390, 390);
            this.panelMemorama.TabIndex = 0;
            this.panelMemorama.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMemorama_Paint);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackColor = System.Drawing.Color.SeaShell;
            this.btnReiniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReiniciar.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.btnReiniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaShell;
            this.btnReiniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaShell;
            this.btnReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReiniciar.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.Location = new System.Drawing.Point(287, 48);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(75, 23);
            this.btnReiniciar.TabIndex = 1;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = false;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.BackColor = System.Drawing.Color.Transparent;
            this.lblRecord.Font = new System.Drawing.Font("Baskerville Old Face", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.ForeColor = System.Drawing.Color.SeaShell;
            this.lblRecord.Location = new System.Drawing.Point(201, 9);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(123, 36);
            this.lblRecord.TabIndex = 2;
            this.lblRecord.Text = "Record:";
            // 
            // lblNumeroRecord
            // 
            this.lblNumeroRecord.AutoSize = true;
            this.lblNumeroRecord.BackColor = System.Drawing.Color.Transparent;
            this.lblNumeroRecord.Font = new System.Drawing.Font("Baskerville Old Face", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroRecord.ForeColor = System.Drawing.Color.SeaShell;
            this.lblNumeroRecord.Location = new System.Drawing.Point(327, 9);
            this.lblNumeroRecord.Name = "lblNumeroRecord";
            this.lblNumeroRecord.Size = new System.Drawing.Size(32, 36);
            this.lblNumeroRecord.TabIndex = 3;
            this.lblNumeroRecord.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.SeaShell;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaShell;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaShell;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrar.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(287, 74);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblNombreMemorama
            // 
            this.lblNombreMemorama.AutoSize = true;
            this.lblNombreMemorama.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreMemorama.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMemorama.ForeColor = System.Drawing.Color.Black;
            this.lblNombreMemorama.Location = new System.Drawing.Point(6, 82);
            this.lblNombreMemorama.Name = "lblNombreMemorama";
            this.lblNombreMemorama.Size = new System.Drawing.Size(59, 14);
            this.lblNombreMemorama.TabIndex = 5;
            this.lblNombreMemorama.Text = "Jugador:";
            // 
            // JuegoMemorama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1151, 496);
            this.ControlBox = false;
            this.Controls.Add(this.lblNombreMemorama);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.lblNumeroRecord);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.panelMemorama);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1167, 535);
            this.MinimumSize = new System.Drawing.Size(1167, 535);
            this.Name = "JuegoMemorama";
            this.Text = "Juego Memorama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMemorama;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Label lblNumeroRecord;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnCerrar;
        public System.Windows.Forms.Label lblNombreMemorama;
    }
}