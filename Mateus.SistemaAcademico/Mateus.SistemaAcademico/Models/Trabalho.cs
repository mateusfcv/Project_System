namespace Mateus.SistemaAcademico.Models
{
    public class Trabalho : EntityBase
    {
        public Nota Nota { get; set; }
        public int Valor { get; set; }

        public Trabalho()
        {

        }

        public Trabalho(Nota nota, int valor)
        {
            Nota = nota;
            Valor = valor;
        }
    }
}