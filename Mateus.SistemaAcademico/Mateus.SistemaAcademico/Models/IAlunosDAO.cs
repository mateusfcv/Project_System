using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mateus.SistemaAcademico.Models
{
    interface IAlunosDAO
    {
        void Adicionar(Alunos a);
        void Atualizar(Alunos a);
        void Remover(Alunos a);
        IList<Alunos> Alunos();
    }
}
