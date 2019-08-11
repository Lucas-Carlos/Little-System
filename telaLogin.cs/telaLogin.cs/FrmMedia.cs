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
    public partial class FrmMedia : Form
    {
        public FrmMedia()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Calculadora calculadora = new Calculadora();

            try
            {
                if (rdb2.Checked == true)
                {
                    calculadora.N1 = Convert.ToDouble(txtn1.Text);
                    calculadora.N2 = Convert.ToDouble(txtn2.Text);
                    txtresul.Text = Convert.ToString(calculadora.calcularMediade2());
                }

                else if (rdb3.Checked == true)
                {
                    calculadora.N1 = Convert.ToDouble(txtn1.Text);
                    calculadora.N2 = Convert.ToDouble(txtn2.Text);
                    calculadora.N3 = Convert.ToDouble(txtn3.Text);
                    txtresul.Text = Convert.ToString(calculadora.calcularMediade3());
                }

                else if (rdb4.Checked == true)
                {
                    calculadora.N1 = Convert.ToDouble(txtn1.Text);
                    calculadora.N2 = Convert.ToDouble(txtn2.Text);
                    calculadora.N3 = Convert.ToDouble(txtn3.Text);
                    calculadora.N4 = Convert.ToDouble(txtn4.Text);
                    txtresul.Text = Convert.ToString(calculadora.calcularMediade4());
                }

                else
                {
                    calculadora.N1 = Convert.ToDouble(txtn1.Text);
                    calculadora.N2 = Convert.ToDouble(txtn2.Text);
                    calculadora.N3 = Convert.ToDouble(txtn3.Text);
                    calculadora.N4 = Convert.ToDouble(txtn4.Text);
                    calculadora.N5 = Convert.ToDouble(txtn5.Text);
                    txtresul.Text = Convert.ToString(calculadora.calcularMediade5());
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Digite apenas caracteres válidos (números).");
            }
        }

        private void rdb2_CheckedChanged(object sender, EventArgs e)
        {
            
            if (rdb2.Checked == true)
            {
                txtn1.Enabled = true;
                txtn2.Enabled = true;
                txtn3.Enabled = false;
                txtn4.Enabled = false;
                txtn5.Enabled = false;
                txtresul.Enabled = false;
            }
        }

        private void rdb3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb3.Checked == true)
            {
                txtn1.Enabled = true;
                txtn2.Enabled = true;
                txtn3.Enabled = true;
                txtn4.Enabled = false;
                txtn5.Enabled = false;
                txtresul.Enabled = false;
            }
        }

        private void rdb4_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb4.Checked == true)
            {
                txtn1.Enabled = true;
                txtn2.Enabled = true;
                txtn3.Enabled = true;
                txtn4.Enabled = true;
                txtn5.Enabled = false;
                txtresul.Enabled = false;
            }
        }

        private void rdb5_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb5.Checked == true)
            {
                txtn1.Enabled = true;
                txtn2.Enabled = true;
                txtn3.Enabled = true;
                txtn4.Enabled = true;
                txtn5.Enabled = true;
                txtresul.Enabled = false;
            }
        }

        private void FrmMedia_Load(object sender, EventArgs e)
        {
            if (rdb2.Checked == false && rdb3.Checked == false && rdb4.Checked == false && rdb5.Checked == false)
            {
                txtn1.Enabled = false;
                txtn2.Enabled = false;
                txtn3.Enabled = false;
                txtn4.Enabled = false;
                txtn5.Enabled = false;
                txtresul.Enabled = false;
            }
        }
    }
}
