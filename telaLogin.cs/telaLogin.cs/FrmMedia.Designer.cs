namespace telaLogin.cs
{
    partial class FrmMedia
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
            this.btnFechar = new System.Windows.Forms.Button();
            this.txtn1 = new System.Windows.Forms.TextBox();
            this.txtn2 = new System.Windows.Forms.TextBox();
            this.txtn3 = new System.Windows.Forms.TextBox();
            this.txtn4 = new System.Windows.Forms.TextBox();
            this.txtn5 = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblresul = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.rdb2 = new System.Windows.Forms.RadioButton();
            this.rdb3 = new System.Windows.Forms.RadioButton();
            this.rdb4 = new System.Windows.Forms.RadioButton();
            this.rdb5 = new System.Windows.Forms.RadioButton();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.txtresul = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(208, 380);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(95, 28);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txtn1
            // 
            this.txtn1.Location = new System.Drawing.Point(125, 145);
            this.txtn1.Name = "txtn1";
            this.txtn1.Size = new System.Drawing.Size(100, 20);
            this.txtn1.TabIndex = 1;
            // 
            // txtn2
            // 
            this.txtn2.Location = new System.Drawing.Point(125, 172);
            this.txtn2.Name = "txtn2";
            this.txtn2.Size = new System.Drawing.Size(100, 20);
            this.txtn2.TabIndex = 2;
            // 
            // txtn3
            // 
            this.txtn3.Location = new System.Drawing.Point(125, 198);
            this.txtn3.Name = "txtn3";
            this.txtn3.Size = new System.Drawing.Size(100, 20);
            this.txtn3.TabIndex = 3;
            // 
            // txtn4
            // 
            this.txtn4.Location = new System.Drawing.Point(126, 224);
            this.txtn4.Name = "txtn4";
            this.txtn4.Size = new System.Drawing.Size(100, 20);
            this.txtn4.TabIndex = 4;
            // 
            // txtn5
            // 
            this.txtn5.Location = new System.Drawing.Point(126, 252);
            this.txtn5.Name = "txtn5";
            this.txtn5.Size = new System.Drawing.Size(100, 20);
            this.txtn5.TabIndex = 5;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(8, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(298, 42);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Calcular a Média";
            // 
            // lblresul
            // 
            this.lblresul.AutoSize = true;
            this.lblresul.Location = new System.Drawing.Point(41, 312);
            this.lblresul.Name = "lblresul";
            this.lblresul.Size = new System.Drawing.Size(121, 13);
            this.lblresul.TabIndex = 7;
            this.lblresul.Text = "Resultado da operação:";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(76, 148);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(43, 13);
            this.lbl1.TabIndex = 8;
            this.lbl1.Text = "1º valor";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(76, 175);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(43, 13);
            this.lbl2.TabIndex = 9;
            this.lbl2.Text = "2º valor";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(77, 201);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(43, 13);
            this.lbl3.TabIndex = 10;
            this.lbl3.Text = "3º valor";
            // 
            // rdb2
            // 
            this.rdb2.AutoSize = true;
            this.rdb2.Location = new System.Drawing.Point(81, 72);
            this.rdb2.Name = "rdb2";
            this.rdb2.Size = new System.Drawing.Size(74, 17);
            this.rdb2.TabIndex = 11;
            this.rdb2.TabStop = true;
            this.rdb2.Text = "2 números";
            this.rdb2.UseVisualStyleBackColor = true;
            this.rdb2.CheckedChanged += new System.EventHandler(this.rdb2_CheckedChanged);
            // 
            // rdb3
            // 
            this.rdb3.AutoSize = true;
            this.rdb3.Location = new System.Drawing.Point(81, 95);
            this.rdb3.Name = "rdb3";
            this.rdb3.Size = new System.Drawing.Size(74, 17);
            this.rdb3.TabIndex = 12;
            this.rdb3.TabStop = true;
            this.rdb3.Text = "3 números";
            this.rdb3.UseVisualStyleBackColor = true;
            this.rdb3.CheckedChanged += new System.EventHandler(this.rdb3_CheckedChanged);
            // 
            // rdb4
            // 
            this.rdb4.AutoSize = true;
            this.rdb4.Location = new System.Drawing.Point(161, 72);
            this.rdb4.Name = "rdb4";
            this.rdb4.Size = new System.Drawing.Size(74, 17);
            this.rdb4.TabIndex = 13;
            this.rdb4.TabStop = true;
            this.rdb4.Text = "4 números";
            this.rdb4.UseVisualStyleBackColor = true;
            this.rdb4.CheckedChanged += new System.EventHandler(this.rdb4_CheckedChanged);
            // 
            // rdb5
            // 
            this.rdb5.AutoSize = true;
            this.rdb5.Location = new System.Drawing.Point(161, 95);
            this.rdb5.Name = "rdb5";
            this.rdb5.Size = new System.Drawing.Size(74, 17);
            this.rdb5.TabIndex = 14;
            this.rdb5.TabStop = true;
            this.rdb5.Text = "5 números";
            this.rdb5.UseVisualStyleBackColor = true;
            this.rdb5.CheckedChanged += new System.EventHandler(this.rdb5_CheckedChanged);
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(76, 227);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(43, 13);
            this.lbl4.TabIndex = 15;
            this.lbl4.Text = "4º valor";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(77, 255);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(43, 13);
            this.lbl5.TabIndex = 16;
            this.lbl5.Text = "5º valor";
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(12, 380);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(190, 28);
            this.btncalcular.TabIndex = 17;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // txtresul
            // 
            this.txtresul.Location = new System.Drawing.Point(168, 309);
            this.txtresul.Name = "txtresul";
            this.txtresul.Size = new System.Drawing.Size(100, 20);
            this.txtresul.TabIndex = 18;
            // 
            // FrmMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 420);
            this.Controls.Add(this.txtresul);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.rdb5);
            this.Controls.Add(this.rdb4);
            this.Controls.Add(this.rdb3);
            this.Controls.Add(this.rdb2);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblresul);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtn5);
            this.Controls.Add(this.txtn4);
            this.Controls.Add(this.txtn3);
            this.Controls.Add(this.txtn2);
            this.Controls.Add(this.txtn1);
            this.Controls.Add(this.btnFechar);
            this.Name = "FrmMedia";
            this.Text = "FrmMedia";
            this.Load += new System.EventHandler(this.FrmMedia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TextBox txtn1;
        private System.Windows.Forms.TextBox txtn2;
        private System.Windows.Forms.TextBox txtn3;
        private System.Windows.Forms.TextBox txtn4;
        private System.Windows.Forms.TextBox txtn5;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblresul;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.RadioButton rdb2;
        private System.Windows.Forms.RadioButton rdb3;
        private System.Windows.Forms.RadioButton rdb4;
        private System.Windows.Forms.RadioButton rdb5;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.TextBox txtresul;
    }
}