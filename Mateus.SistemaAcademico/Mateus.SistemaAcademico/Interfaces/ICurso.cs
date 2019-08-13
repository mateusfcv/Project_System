using Mateus.SistemaAcademico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mateus.SistemaAcademico.Interfaces
{
    public interface ICurso
    {
        void Adicionar(Curso curso);
        void Editar(Curso curso);
        void Remover(Curso curso);
        IList<Curso> ListarCursos(); 
    }
}
