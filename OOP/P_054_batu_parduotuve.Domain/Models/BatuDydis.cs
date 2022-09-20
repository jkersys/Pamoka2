using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_054_batu_parduotuve.Domain.Models
{
    public class BatuDydis
    {
        [Key]
        public int Id { get; set; }
        public int Dydis { get; set; }
        public int Kiekis { get; set; }
        public int BatasId { get; set; }
        public virtual Batas Batas { get; set; }
    }
}
