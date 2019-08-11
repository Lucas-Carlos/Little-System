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
    public partial class FrmSplash : Form
    {
        public FrmSplash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pbAcesso.Value < 100)
            {
                pbAcesso.Value = pbAcesso.Value + 10;
            }
            else
            {                
                timer1.Enabled = false;
                this.Visible = false;
                FrmPrincipal s = new FrmPrincipal();
                s.Show();
            }
        }
    }
}
