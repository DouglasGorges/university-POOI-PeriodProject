using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university_POOI_PeriodProject
{
    public class FormaDePagamentoDTO
    {

        public double precoCursoBasico { get; set; }
        public double precoCursoIntermediario { get; set; }
        public double precoCursoAvancado { get; set; }

        public bool emDinheiro { get; set; }
    // private bool emDebito = false;



        public bool vaiPagarEmDinheiro()
        {
            if (emDinheiro == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
