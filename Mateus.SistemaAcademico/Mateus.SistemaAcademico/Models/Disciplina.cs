using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Models
{
    public class Disciplina
    {
        public int IdDisciplina { get; set; }
        public float CargaHoraria { get; set; }
        public string Nome { get; set; }
        public List<Conteudo> Conteudo { get; set; }

        public Disciplina ()
        {

        }

        public Disciplina(int idDisciplina, float cargaHoraria, string nome, List<Conteudo> conteudo)
        {
            IdDisciplina = idDisciplina;
            CargaHoraria = cargaHoraria;
            Nome = nome;
            Conteudo = conteudo;
        }
    }
}