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
        void Adicionar(Frequencia frequencia);
        void Editar(Frequencia frequencia);
        void Remover(Frequencia frequencia);  
        IList<Frequencia> ListarFrequencias(); 
    }
}
