using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRental.Model
{
    [Table("locacao")]
    public class Rental
    {
        [Column("id")]
        public int ID { get; set; }
        
        [Column("id_cliente")]
        public int ID_Cliente { get; set; }

        [Column("id_filme")]
        public int ID_Filme { get; set; }

        [Column("data_locacao")]
        public DateTime DataLocacao { get; set; }

        [Column("data_devolucao")]
        public DateTime DataDevolucao { get; set; }
    }
}
