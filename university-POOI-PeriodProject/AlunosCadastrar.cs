using System;
using System.Collections;
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
            formaPagamento.FormaDePagamentoEscolhida += FormaPagamento_FormaDePagamentoEscolhida;
            formaPagamento.abrir();
            this.Hide();
        }

        private void FormaPagamento_FormaDePagamentoEscolhida(FormaDePagamentoDTO formaDePagamento)
        {
            if(formaDePagamento.emDinheiro == true)
            {
                textBox4.Text = "Dinheiro";
            }
            else
            {
                textBox4.Text = "Débito";
            }

            //TODO implementar preenchimentos restantes aqui
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
                pictureBox1.ImageLocation = "D:/Faculdade/GitHub/university-POOI-PeriodProject/university-POOI-PeriodProject/resources/paoComOvo.jpg";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            

            if (radioButton2.Checked)
            {
                pictureBox1.ImageLocation = "D:/Faculdade/GitHub/university-POOI-PeriodProject/university-POOI-PeriodProject/resources/lasanha.jpg";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                pictureBox1.ImageLocation = "D:/Faculdade/GitHub/university-POOI-PeriodProject/university-POOI-PeriodProject/resources/sushi.jpg";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                checkBox2.Enabled = false;
                checkBox2.Checked = false;
                radioButton2.Enabled = false;
                radioButton2.Checked = false;
                radioButton3.Enabled = false;
                radioButton3.Checked = false;

                radioButton1.Checked = true;
            }
            else if (checkBox1.Checked == true)
            {
                radioButton2.Enabled = true;
                radioButton2.Checked = true;
                checkBox2.Enabled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == false)
            {
                radioButton3.Enabled = false;
                radioButton2.Checked = true;
            }
            else if (checkBox2.Checked == true)
            {
                radioButton3.Enabled = true;
                radioButton3.Checked = true;
            }

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            aluno.setNome(textBox1.Text);
            aluno.setCpf(double.Parse(textBox2.Text)); //falta tratar quando tem 0 à esquerda
            //aluno.setDataNascimento(DateTime.Parse(dateTimePicker1));
            aluno.setTelefone(textBox3.Text);
            
            if (radioButton1.Checked == true)
            {
                aluno.setVaiCursarBasico(true);
            }
            else
            {
                aluno.setVaiCursarBasico(false);
            }


            if (radioButton2.Checked == true)
            {
                aluno.setVaiCursarIntermediario(true);
            }
            else
            {
                aluno.setVaiCursarIntermediario(false);
            }

            if (radioButton3.Checked == true)
            {
                aluno.setVaiCursarAvancado(true);
            }
            else
            {
                aluno.setVaiCursarAvancado(false);
            }

            if (checkBox1.Checked == true)
            {
                aluno.setCursouBasico(true);
            }
            else
            {
                aluno.setCursouBasico(false);
            }

            if (checkBox2.Checked == true)
            {
                aluno.setCursouIntermediario(true);
            }
            else
            {
                aluno.setCursouIntermediario(false);
            }


            Persistencia.Instance.AlunosMatriculados.Add(aluno);

            ConfirmacaoDeCadastro confirmacaoDeCadastro = new ConfirmacaoDeCadastro();
            confirmacaoDeCadastro.Show();
            this.Hide();
        }
    }
}
