using Mateus.SistemaAcademico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mateus.SistemaAcademico.Interfaces
{
    public interface IAlunosDAO
    {
        void Adicionar(Alunos a);
        void Atualizar(Alunos a);
        void Remover(Alunos a);
        IList<Alunos> Alunos();
    }
}
