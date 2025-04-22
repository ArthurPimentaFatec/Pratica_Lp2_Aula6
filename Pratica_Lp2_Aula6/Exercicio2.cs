using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pratica_Lp2_Aula6
{
    public partial class Exercicio2 : Form
    {
        double numeroH;
        double numeroN;

        public Exercicio2()
        {
            InitializeComponent();
        }

        // validação
        private void txtNumeroN_Validated(object sender, EventArgs e)
        {
            if(!double.TryParse(txtNumeroN.Text, out numeroN))
            {
                MessageBox.Show("Digite um número válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroN.Clear();
                txtNumeroN.Focus();
            }
        }

        // funções de click

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumeroN.Clear();
            txtNumeroN.Focus();
            txtResultado.Clear();
        }

        private void btnCalcularH_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            numeroN = 1;
            
            for (int i = 1; i <= numeroN; i++)
            {
                txtResultado.Text += numeroH + (1.0 / (numeroN));
                numeroN++;
            }
        }
        
    }
}
