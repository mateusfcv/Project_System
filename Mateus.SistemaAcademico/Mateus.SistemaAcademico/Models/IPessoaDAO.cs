using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mateus.SistemaAcademico.Models
{
    interface IPessoaDAO
    {
        void Adicionar(Pessoa p);
        void Atualizar(Pessoa p);
        void Remover(Pessoa p);
        IList<Pessoa> Pessoas();
    }
}
