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
        void Atualizar(Aluno a);
        void Remover(Aluno a);
        void ObterAluno(Aluno a);
        IList<Aluno> ListarAlunos();
        
    }
}
