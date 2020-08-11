using System;

namespace Domain.Model.Models
{
    public class MoleculaModel
    {
        public int Id { get; set; }

        public decimal Rendimento { get; set; }
        public string FormulaMolecular { get; set; }
        public string TipoReacao { get; set; }
        public DateTime Lancamento { get; set; }

        public int AutorId { get; set; }
        public AutorModel Autor { get; set; }
    }
}
