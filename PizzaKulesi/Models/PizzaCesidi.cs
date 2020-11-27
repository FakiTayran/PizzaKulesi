using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaKulesi.Models
{
    [Table("PizzaCesitleri")]
    public class PizzaCesidi
    {
        public int Id { get; set; }

        [Required]
        public string CesitAdi { get; set; }

        public virtual ICollection<Siparis> Siparisler { get; set; }

        public override string ToString()
        {
            return CesitAdi;
        }

    }
}
