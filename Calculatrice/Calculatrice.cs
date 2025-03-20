using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice
{
    public partial class Calculatrice : Form
    {
        public Calculatrice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double nombre1 = double.Parse(txtNombre1.Text);
            double nombre2 = double.Parse(txtNombre2.Text);
            string signe = txtSigne.Text;
            double reponse = 0;
            if (signe == "+")
            {
                reponse = nombre1 + nombre2;
            }
            else if (signe == "-")
            {
                reponse = nombre1 - nombre2;
            }
            else if (signe == "X")
            {
                reponse = nombre1 * nombre2;
            }
            else if (signe == ":")
            {
                if (nombre2 == 0)
                {
                    MessageBox.Show("Division impossible");
                }
                else
                {
                    reponse = nombre1 / nombre2;
                }
            }
            else if (signe == "%")
            {
                if (nombre2 == 0)
                {
                    MessageBox.Show("Division impossible");
                }
                else
                {
                    reponse = nombre1 % nombre2;
                }
            }

            txtReponse.Text = reponse.ToString();

        }
    }
}
