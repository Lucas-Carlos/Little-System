using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telaLogin.cs
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void calcularMédiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMedia fMedia = new FrmMedia();
            fMedia.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Obrigado por utilizar nosso programa!");
            Application.Exit();
        }
    }
}
