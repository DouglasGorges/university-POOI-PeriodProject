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
    }
}
