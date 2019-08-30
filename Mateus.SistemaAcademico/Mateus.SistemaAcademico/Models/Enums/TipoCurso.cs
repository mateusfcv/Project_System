using System.ComponentModel.DataAnnotations;

namespace Mateus.SistemaAcademico.Models.Enums
{
    public enum TipoCurso
    {
        Licenciatura,
        Bacharelado,
        [Display(Name = "Tecnólogo")]
        Tecnologo
    }
}