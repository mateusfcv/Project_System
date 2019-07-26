using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mateus.SistemaAcademico.Interfaces
{
    public interface ITipoProva
    {
        void Avaliacao();

        void Substitutivas();

        void ExameFinal();
    }
}
