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
    public partial class CursoIntermediario : Form
    {
        public CursoIntermediario()
        {
            InitializeComponent();
        }

        private void CursoIntermediario_FormClosed(object sender, FormClosedEventArgs e)
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

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
