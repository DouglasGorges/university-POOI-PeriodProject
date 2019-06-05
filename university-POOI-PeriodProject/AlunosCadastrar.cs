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
    public partial class AlunosCadastrar : Form
    {
        public AlunosCadastrar()
        {
            InitializeComponent();
        }

        private void AlunosCadastrar_FormClosed(object sender, FormClosedEventArgs e)
        {

            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
            else
            {
                foreach (Form formAberto in Application.OpenForms)
                {
                    if (formAberto is Home)
                    {
                        formAberto.Show();
                        break;
                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormaPagamento formaPagamento = new FormaPagamento();
            formaPagamento.Show();
            this.Hide();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            foreach (Form formAberto in Application.OpenForms)
            {
                if (formAberto is Home)
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
                pictureBox1.Image = null;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                pictureBox1.Image = null;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                pictureBox1.Image = null;
            }
        }
    }
}
