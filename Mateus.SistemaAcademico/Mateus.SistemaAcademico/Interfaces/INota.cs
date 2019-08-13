using Mateus.SistemaAcademico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mateus.SistemaAcademico.Interfaces
{
    public interface INota
    {
        void Adicionar(Nota nota);
        void Atualizar(Nota nota);
        void Remover(Nota nota);
        IList<Nota> Notas(); 
    } 
}
