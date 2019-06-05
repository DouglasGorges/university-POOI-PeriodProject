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
    }
}
