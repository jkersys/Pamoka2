using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_054_batu_parduotuve.Domain.Models
{
    [Table("Pardavimai")]
    public class Pardavimas
    {
        [Key]
        public int PardavimasId { get; set; }
        public int BatuDydisId { get; set; }
        public int Kiekis { get; set; }
        public virtual BatuDydis BatuDydis { get; set; }

        [NotMapped]
        public virtual decimal Isleista => BatuDydis.Batas.Kaina * Kiekis;

    }
}
