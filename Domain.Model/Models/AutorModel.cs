using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model.Models
{
    public class AutorModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Molecula { get; set; }
        public DateTime DataSintese { get; set; }
    }
}
