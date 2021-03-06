﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university_POOI_PeriodProject
{
    class Aluno //Essa é a classe Aluno, que será instanciada a cada novo cadastro
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
        String vaiPagarComo;


        public void setNome(String nome) //Abaixo temos getters e setters como métodos, pois ainda não consegui implementar o {get; set; }
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

        public void setVaiPagarComo(String vaiPagarComo)
        {
            this.vaiPagarComo = vaiPagarComo;
        }

        public String getNome()
        {
            return this.nome;
        }

        public String getPagamento()
        {
            return this.vaiPagarComo;
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
