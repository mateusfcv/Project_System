using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Models
{
    public class Professor : Pessoa
    {
        public int RegistroDoProfessor;
        public Disciplina DisciplinasMinistratadas;
        public string Titulacao;

        public Professor ()
        {

        }

        public Professor(Nome nome, List<Telefone> telefone, Endereco endereco, Cpf cpf, int registroDoProfessor, Disciplina disciplinasMinistratadas, string titulacao)
            :base(nome, telefone, endereco, cpf)
        {
            RegistroDoProfessor = registroDoProfessor;
            DisciplinasMinistratadas = disciplinasMinistratadas;
            Titulacao = titulacao;
        }

        public Professor(int registroDoProfessor, Disciplina disciplinasMinistratadas, string titulacao)
        {
            RegistroDoProfessor = registroDoProfessor;
            DisciplinasMinistratadas = disciplinasMinistratadas;
            Titulacao = titulacao;
        }
    }
}