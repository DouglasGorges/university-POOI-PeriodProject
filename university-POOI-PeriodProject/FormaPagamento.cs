using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace university_POOI_PeriodProject
{
    public partial class FormaPagamento : Form
    {
        double PRECOCURSOBASICO = 1000;
        double PRECOCURSOINTERMEDIARIO = 2000;
        double PRECOCURSOAVANCADO = 5000;
        double VALORAVISTA = 0.8;

        public FormaPagamento()
        {
            InitializeComponent();
        }

        private void FormaPagamento_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
            else
            {
                foreach (Form formAberto in Application.OpenForms)
                {
                    if (formAberto is AlunosCadastrar)
                    {
                        formAberto.Show();
                        break;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            this.Hide();

            foreach (Form formAberto in Application.OpenForms)
                {
                    if (formAberto is AlunosCadastrar)
                    {
                        formAberto.Show();
                        break;
                    }
                }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox1.Text = ($"R${PRECOCURSOBASICO * VALORAVISTA}");
                textBox2.Text = ($"R${PRECOCURSOINTERMEDIARIO * VALORAVISTA}");
                textBox3.Text = ($"R${PRECOCURSOAVANCADO * VALORAVISTA}");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBox1.Text = ($"R${PRECOCURSOBASICO}");
                textBox2.Text = ($"R${PRECOCURSOINTERMEDIARIO}");
                textBox3.Text = ($"R${PRECOCURSOAVANCADO}");
            }

        }
    }
}
