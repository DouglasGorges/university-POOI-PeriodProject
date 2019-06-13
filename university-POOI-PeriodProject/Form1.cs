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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void básicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CursoBasico basico = new CursoBasico();
            basico.Show();
            this.Hide();
        }

        private void intermediárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CursoIntermediario intermediario = new CursoIntermediario();
            intermediario.Show();
            this.Hide();
        }

        private void avançadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CursoAvancado avancado = new CursoAvancado();
            avancado.Show();
            this.Hide();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlunosCadastrar cadastrar = new AlunosCadastrar();
            cadastrar.Show();
            this.Hide();
        }

        private void listarMatriculadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlunosListar listar = new AlunosListar();
            listar.abrir(); //Aqui é feito o comando para abrir a janela de listagem e carregar a lista
            this.Hide();


        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre sobre = new Sobre();
            sobre.Show();
            this.Hide();
        }
    }
}
