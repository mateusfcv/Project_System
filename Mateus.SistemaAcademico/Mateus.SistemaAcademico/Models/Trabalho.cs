namespace Mateus.SistemaAcademico.Models
{
    public class Trabalho : EntityBase
    {
        public Nota Nota { get; set; }
        public float NotaDoTrabalho { get; set; }

        public Trabalho()
        {

        }

        public Trabalho(Nota nota, float notaDoTrabalho)
        {
            Nota = nota;
            NotaDoTrabalho = notaDoTrabalho;
        }
    }
}