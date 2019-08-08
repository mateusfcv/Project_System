using Mateus.SistemaAcademico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mateus.SistemaAcademico.Interfaces
{
    public interface IDisciplina
    {
        void Adicionar(Disciplina d);
        void Atualizar(Disciplina d);
        void Remover(Disciplina d);
        IList<Disciplina> ListarDisciplinas(); 
    }
}
