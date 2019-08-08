using Mateus.SistemaAcademico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mateus.SistemaAcademico.Interfaces
{
    public interface IConteudo
    {
        void Adicionar(Conteudo c);
        void Atualizar(Conteudo c);
        void Remover(Conteudo c);
        IList<Conteudo> ListarConteudos();  
    }
}
