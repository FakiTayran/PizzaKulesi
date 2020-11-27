using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaKulesi.Models
{
    [Table("Siparisler")]
    public class Siparis
    {
        public int Id { get; set; }
        public int PizzaCesitId { get; set; }
        public bool TeslimDurumu { get; set; }

        [Required,MaxLength(50)]
        public string MusteriTamAd { get; set; }

        [Required, MaxLength(200)]
        public string Adres { get; set; }
        public string MalzemeIsimleri { get { return $"{Malzemeler.Select(x => x.MalzemeAdi).Virgulle()}"; } }
        public string TeslimString { get { return TeslimDurumu ? "Teslim Edildi" : "Teslim Edilmedi" ; } }
        public PizzaCesidi Pizza { get; set; }
        public virtual ICollection<EkstraMalzeme>Malzemeler { get; set; }

    }
}
