using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university_POOI_PeriodProject
{
    public class Persistencia //Criada essa classe para servir como banco de dados para guardar os objetos Aluno
    {
        private static readonly Persistencia instance = new Persistencia();

        private Persistencia() {
            //throw new Exception("Persistência Singleton");
        }

        public static Persistencia Instance
        {
            get
            {
                return instance;
            }
        }

        private ArrayList alunosMatriculados = new ArrayList();

        public ArrayList AlunosMatriculados
        {
            get
            {
                return alunosMatriculados;
            }
        }
    }
}
