using Mateus.SistemaAcademico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mateus.SistemaAcademico.Interfaces
{
    public interface IFrequencia
    {
        void Adicionar(Frequencia f);
        void Atualizar(Frequencia f);
        void Remover(Frequencia f);
        IList<Frequencia> Frequencias();
    }
}
