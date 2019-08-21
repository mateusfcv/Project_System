using System;
using System.ComponentModel.DataAnnotations;

namespace Mateus.SistemaAcademico.Models
{
    public class Trabalho : EntityBase
    {
        [Required]
        public float NotaDoTrabalho { get; set; }
        // data em que o professor lançou o trabalho
        [Required]
        [DataType(DataType.Date)]
        public DateTime DataDeInicio { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DataDaEntrega { get; set; }

        public Trabalho()
        {

        }

        public Trabalho(float notaDoTrabalho, DateTime dataDeInicio, DateTime dataDaEntrega)
        {
            NotaDoTrabalho = notaDoTrabalho;
            DataDeInicio = dataDeInicio;
            DataDaEntrega = dataDaEntrega;
        }
    }
}