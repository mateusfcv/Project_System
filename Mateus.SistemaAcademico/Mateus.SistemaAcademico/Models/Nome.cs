using Mateus.SistemaAcademico.Bussines;
using System.Text.RegularExpressions;
using Mateus.SistemaAcademico.Models.Objects_Value;

namespace Mateus.SistemaAcademico.Models
{
    public class Nome
    {
        public string Dados { get; set; }

        public bool ValidacaoNome(string Dados) 
        {
            if (Dados == null)
            {
                throw new CampoNullException();
            }
            else if (Regex.IsMatch(Dados, (@"[^a-zA-Z]")))
            {
                return false;
            }
            return true;
        }
    }
}