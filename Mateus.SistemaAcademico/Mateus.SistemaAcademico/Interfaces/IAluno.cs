using Mateus.SistemaAcademico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mateus.SistemaAcademico.Interfaces
{
    public interface IAluno
    {
        void Adicionar(Aluno a);
        //Aluno Adicionar();
        void Atualizar(Aluno a);
        //Aluno Atualizar();
        void Remover(Aluno a);
        //Aluno Remover();
        IList<Aluno> ListarAlunos();
    }
}
