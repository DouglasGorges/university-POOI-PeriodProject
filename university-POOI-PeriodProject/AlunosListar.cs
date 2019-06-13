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
    public partial class AlunosListar : Form
    {
        public AlunosListar()
        {
            InitializeComponent();
        }
        
        private void AlunosListar_FormClosed(object sender, FormClosedEventArgs e) //Tratamento para fechamento da janela
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

        public void abrir() //método para abrir a tela quando clicar no botão Listar Alunos Cadastrados no Form1. Foi criado para não perder o tempo de processamento da classe. Sem o método eu não consegui carregar os alunos na lista.
        {
            showInListView();
            Show();
        }

        private void showInListView() //Método criado para varrer a minha instância de Alunos Cadastrados e preencher o ListView.
        {
            foreach(Aluno aluno in Persistencia.Instance.AlunosMatriculados)
            {
                //AlunosListar alunosListar = new AlunosListar();
                ListViewItem lvi = new ListViewItem(aluno.getNome());
                //lvi.SubItems.Add(aluno.getNome());
                lvi.SubItems.Add(aluno.getPagamento());
                lvi.SubItems.Add(aluno.getCurso());
                //alunosListar.setListView1(lvi);

                listView1.Items.Add(lvi);
            }
            
        }
    }
}
