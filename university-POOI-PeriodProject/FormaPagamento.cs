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
        private double PRECOCURSOBASICO = 1000; //Constantes com os valores do curso
        private double PRECOCURSOINTERMEDIARIO = 2000;
        private double PRECOCURSOAVANCADO = 5000;
        private double VALORAVISTA = 0.8;

        private FormaDePagamentoDTO formaDePagamento;

        public delegate void FormadePagamentoEscolhidaHandler(FormaDePagamentoDTO formaDePagamento);

        public event FormadePagamentoEscolhidaHandler FormaDePagamentoEscolhida;

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

        public void abrir()
        {
            //TODO Limpar tela forma de pagamento implemmentar aqui
            formaDePagamento = new FormaDePagamentoDTO();
            this.Show();
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

            if(FormaDePagamentoEscolhida != null) //Instanciando a classe de forma a ser "null safe"
            {
                
                FormaDePagamentoEscolhida(formaDePagamento);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) //Dois métodos para dinamizar a apresentação dos valores dos cursos
        {
            if (radioButton1.Checked)
            {
                textBox1.Text = ($"R${PRECOCURSOBASICO * VALORAVISTA}");
                textBox2.Text = ($"R${PRECOCURSOINTERMEDIARIO * VALORAVISTA}");
                textBox3.Text = ($"R${PRECOCURSOAVANCADO * VALORAVISTA}");

                formaDePagamento.precoCursoBasico = (PRECOCURSOBASICO * VALORAVISTA);
                formaDePagamento.precoCursoIntermediario = (PRECOCURSOINTERMEDIARIO * VALORAVISTA);
                formaDePagamento.precoCursoAvancado = (PRECOCURSOAVANCADO * VALORAVISTA);

                formaDePagamento.emDinheiro = true;

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBox1.Text = ($"R${PRECOCURSOBASICO}");
                textBox2.Text = ($"R${PRECOCURSOINTERMEDIARIO}");
                textBox3.Text = ($"R${PRECOCURSOAVANCADO}");

                formaDePagamento.precoCursoBasico = (PRECOCURSOBASICO);
                formaDePagamento.precoCursoIntermediario = (PRECOCURSOINTERMEDIARIO);
                formaDePagamento.precoCursoAvancado = (PRECOCURSOAVANCADO);

                formaDePagamento.emDinheiro = false;
            }

        }
    }
}
