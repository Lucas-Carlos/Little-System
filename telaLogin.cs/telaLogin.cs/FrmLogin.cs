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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string user = "Lucas";
            string senha = "123";

            if (txtLogin.Text == user && txtSenha.Text == senha)
            {
                FrmSplash f = new FrmSplash();
                f.Show();
            }
            else
            {
                MessageBox.Show("E-mail ou senha errado(s).");
            }
        }
    }
}
