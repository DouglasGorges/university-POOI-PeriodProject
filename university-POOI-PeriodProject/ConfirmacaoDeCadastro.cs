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
    public partial class ConfirmacaoDeCadastro : Form
    {
        public ConfirmacaoDeCadastro()
        {
            InitializeComponent();
        }

        private void ConfirmacaoDeCadastro_FormClosed(object sender, FormClosedEventArgs e)
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

            //TODO implementar limpeza da tela de cadastro
        }
    }
}
