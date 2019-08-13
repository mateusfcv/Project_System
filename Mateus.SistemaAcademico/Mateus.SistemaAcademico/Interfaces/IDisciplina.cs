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
        void Adicionar(Disciplina disciplina);
        void Atualizar(Disciplina disciplina);
        void Remover(Disciplina disciplina); 
        IList<Disciplina> ListarDisciplinas(); 
    }
}
