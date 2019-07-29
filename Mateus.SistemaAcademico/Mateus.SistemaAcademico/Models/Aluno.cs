using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Models
{
    public class Aluno
    {
        public int IdAluno { get; set; }
        public int RegistroDoAluno { get; set; }
        public Responsavel Responsavel { get; set; }

        public Aluno ()
        {

        }

        public Aluno(int idAluno, int registroDoAluno, Responsavel responsavel)
        {
            IdAluno = idAluno;
            RegistroDoAluno = registroDoAluno;
            Responsavel = responsavel;
        }
    } 
}