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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nombre1 = int.Parse(txtNombre1.Text);
            int nombre2 = int.Parse(txtNombre2.Text);

            int reponse = nombre1 + nombre2;

            txtReponse.Text = reponse.ToString();
        }
    }
}
