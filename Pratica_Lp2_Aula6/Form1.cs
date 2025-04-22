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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exercício1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Exercicio1>().Count() > 0)
            {
                Application.OpenForms["Exercicio1"].BringToFront();
            }
            else
            {
                Exercicio1 obj1 = new Exercicio1();
                obj1.MdiParent = this;
                obj1.WindowState = FormWindowState.Maximized;
                obj1.Show();

            }
        }

        private void exercício2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Exercicio2>().Count() > 0)
            {
                Application.OpenForms["Exercicio2"].BringToFront();
            }
            else
            {
                Exercicio2 obj2 = new Exercicio2();
                obj2.MdiParent = this;
                obj2.WindowState = FormWindowState.Maximized;
                obj2.Show();

            }
        }

        private void exercício3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Exercicio3>().Count() > 0)
            {
                Application.OpenForms["Exercicio3"].BringToFront();
            }
            else
            {
                Exercicio3 obj3 = new Exercicio3();
                obj3.MdiParent = this;
                obj3.WindowState = FormWindowState.Maximized;
                obj3.Show();

            }
        }
    }
}
