using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoCalculoArea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BntCalcularArea_Click(object sender, EventArgs e)
        {
            try
            {
                double raio = Convert.ToDouble(txtRaio.Text);
                double area = Math.PI * Math.Pow(raio, 2);
                lbResposta.Text = "Área = " + area.ToString("N2") + " cm quadrado";
            }
            catch (Exception)
            {
                lbResposta.Text = "Raio inválido";
                txtRaio.Focus();
            }

        }

        private void txtRaio_KeyPress(object sender, KeyPressEventArgs e)
        {
            char tecla = e.KeyChar;
            if (Char.IsLetter(tecla))
            {
                e.Handled = true;
            }
            if (tecla == '.')
            {
                e.KeyChar = '.';
            }
        }
    }
}
