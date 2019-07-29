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
        void Adicionar(Curso c);
        void Atualizar(Curso c);
        void Remover(Curso c);
        IList<Curso> Cursos(); 
    }
}
