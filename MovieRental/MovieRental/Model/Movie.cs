using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRental.Model
{
    public class Movie
    {
        public int ID { get; set; }
        public string Titulo { get; set; }
        public int ClassificacaoIndicativa { get; set; }
        public string Lancamento { get; set; }
    }
}
