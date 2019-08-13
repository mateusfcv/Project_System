using Mateus.SistemaAcademico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mateus.SistemaAcademico.Interfaces
{
    interface IResponsavel
    {
        void Adicionar(Responsavel responsavel);
        void Editar(Responsavel responsavel);
        void Remover(Responsavel responsavel);
        IList<Responsavel> ListarResponsavel(); 
    }
}
