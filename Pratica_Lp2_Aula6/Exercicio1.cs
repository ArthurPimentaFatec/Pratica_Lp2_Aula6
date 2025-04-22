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
    public partial class Exercicio1 : Form
    {

        public Exercicio1()
        {
            InitializeComponent();
        }

        // validação

        private void rchTxtFrase_Validated(object sender, EventArgs e)
        {
            if (rchTxtFrase.Text.Length > 100)
            {
                MessageBox.Show("Por favor, use no máximo 100 caracteres.");
                rchTxtFrase.Clear();
                rchTxtFrase.Focus();
            }
        }

        // funções de click

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            rchTxtFrase.Clear();
            rchTxtFrase.Focus();
        }

        private void btnQtdBrancos_Click(object sender, EventArgs e)
        {
            int contagem, i, letterCount;
            contagem = 0;
            i = 0;
            
            letterCount = rchTxtFrase.Text.Length;

            if (rchTxtFrase.Text == "")
            {
                MessageBox.Show("Escreva algo antes de usar as funções.");
            }
            else
            {
                for(i = 0; i < letterCount; i++)
                {
                    if (rchTxtFrase.Text[i] == ' ')
                    {
                        contagem++;
                    }
                }
            }

            MessageBox.Show($"A frase contém {contagem} espaços em branco.");
        }

        private void btnQtdR_Click(object sender, EventArgs e)
        {
            int contagem, i, letterCount;
            contagem = 0;
            i = 0;

            letterCount = rchTxtFrase.Text.Length;

            if(rchTxtFrase.Text == "")
            {
                MessageBox.Show("Escreva algo antes de usar as funções.");
            } 
            else
            {
                do
                {
                    if(rchTxtFrase.Text[i] == 'r' || rchTxtFrase.Text[i] == 'R')
                    {
                        contagem++;
                    }
                    i++;
                } while (i < letterCount);
            }

            MessageBox.Show($"A frase tem {contagem} quantidade de letras 'R'.");
        }

        private void btnQtdPar_Click(object sender, EventArgs e)
        {
            int contagem, i, letterCount;
            contagem = 0;
            i = 0;

            letterCount = rchTxtFrase.Text.Length;


            if (rchTxtFrase.Text == "")
            {
                MessageBox.Show("Escreva algo antes de usar as funções.");
            } 
            else
            {
                while (i < letterCount - 1)
                {
                    if (rchTxtFrase.Text[i] == rchTxtFrase.Text[i + 1] )
                    {
                        contagem++;
                    }
                    i++;
                }
            }

            MessageBox.Show($"A frase contém {contagem} sequências de pares de letras iguais.");
        }
    }
}
