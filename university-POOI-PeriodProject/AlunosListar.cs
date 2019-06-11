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
        
        private void AlunosListar_FormClosed(object sender, FormClosedEventArgs e)
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

        private void showInListView(ArrayList alunosMatriculados)
        {
            /*
            AlunosListar alunosListar = new AlunosListar();
            ListViewItem lvi = new ListViewItem(alunosMatriculados.);
            lvi.SubItems.Add(aluno.getTelefone());
            lvi.SubItems.Add(aluno.getCurso());
            alunosListar.setListView1(lvi);

            listView1.Items.Add();

            */
        }
    }
}
