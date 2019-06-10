using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university_POOI_PeriodProject
{
    class Aluno
    {
        String nome;
        double cpf;
        DateTime dataNascimento;
        String telefone;
        bool cursouBasico;
        bool cursouIntermediario;
        bool vaiCursarBasico;
        bool vaiCursarIntermediario;
        bool vaiCursarAvancado;


        public void setNome(String nome)
        {
            this.nome = nome;
        }

        public void setCpf(double cpf)
        {
            this.cpf = cpf;
        }

        public void setDataNascimento(DateTime dataNascimento)
        {
            this.dataNascimento = dataNascimento;
        }

        public void setTelefone(String telefone)
        {
            this.telefone = telefone;
        }

        public void setCursouBasico(bool cursouBasico)
        {
            this.cursouBasico = cursouBasico;
        }

        public void setCursouIntermediario(bool cursouIntermediario)
        {
            this.cursouIntermediario = cursouIntermediario;
        }

        public void setVaiCursarBasico(bool vaiCursarBasico)
        {
            this.vaiCursarBasico = vaiCursarBasico;
        }

        public void setVaiCursarIntermediario(bool vaiCursarIntermediario)
        {
            this.vaiCursarIntermediario = vaiCursarIntermediario;
        }

        public void setVaiCursarAvancado(bool vaiCursarAvancado)
        {
            this.vaiCursarAvancado = vaiCursarAvancado;
        }

        public String getNome()
        {
            return this.nome;
        }

        public String getTelefone()
        {
            return this.telefone;
        }

        public String getCurso()
        {
            if (vaiCursarBasico == true)
            {
                return ("Básico");
            }
            else if (vaiCursarIntermediario == true)
            {
                return ("Intermediário");
            }
            else
            {
                return ("Avançado");
            }
        }
    }
}
