using Mateus.SistemaAcademico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mateus.SistemaAcademico.Interfaces
{
    public interface IProfessor
    {
        void Adicionar(Professor professor);
        void Atualizar(Professor professor); 
        void Remover(Professor professor);
        IList<Professor> ListarProfessores(); 
    }
}
