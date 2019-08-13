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
        void Adicionar(Aluno aluno);
        void Editar(Aluno aluno);
        void Remover(Aluno aluno);
        IList<Aluno> ListarAlunos();
    }
}
