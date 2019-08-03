namespace Mateus.SistemaAcademico.Models
{
    public class Trabalho : EntityBase
    {
        public float NotaDoTrabalho { get; set; }

        public Trabalho()
        {

        }

        public Trabalho(float notaDoTrabalho)
        {
            NotaDoTrabalho = notaDoTrabalho;
        }
    }
}