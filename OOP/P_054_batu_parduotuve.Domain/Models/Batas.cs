using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_054_batu_parduotuve.Domain.Models
{
    public class Batas
    {
        [Key]
        public int BatasId { get; set; }

        [Required]
        public string Pavadinimas { get; set; }

        [Required]
        public string Tipas { get; set; }

        public decimal Kaina { get; set; }

        public virtual ICollection<BatuDydis> Dydziai { get; set; } = new HashSet<BatuDydis>();

    }
}
