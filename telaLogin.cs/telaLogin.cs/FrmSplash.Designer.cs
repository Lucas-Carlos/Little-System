namespace telaLogin.cs
{
    partial class FrmSplash
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.pbAcesso = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::telaLogin.cs.Properties.Resources.ologo;
            this.pbxLogo.Location = new System.Drawing.Point(101, 12);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(139, 115);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 0;
            this.pbxLogo.TabStop = false;
            // 
            // pbAcesso
            // 
            this.pbAcesso.BackColor = System.Drawing.SystemColors.Control;
            this.pbAcesso.Enabled = false;
            this.pbAcesso.Location = new System.Drawing.Point(52, 171);
            this.pbAcesso.Name = "pbAcesso";
            this.pbAcesso.Size = new System.Drawing.Size(236, 23);
            this.pbAcesso.TabIndex = 1;
            // 
            // FrmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 280);
            this.Controls.Add(this.pbAcesso);
            this.Controls.Add(this.pbxLogo);
            this.Name = "FrmSplash";
            this.Text = "FrmSplash";
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.ProgressBar pbAcesso;
    }
}