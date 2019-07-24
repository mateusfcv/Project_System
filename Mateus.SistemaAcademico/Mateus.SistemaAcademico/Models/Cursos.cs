using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Models
{
    public class Cursos
    {
        public string Nome;

        public float Duracao;

        public Professor Coordenador;

        public TipoCurso Tipo;
    }
}