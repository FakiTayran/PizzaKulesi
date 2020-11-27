using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaKulesi.Models
{
    public class SiparisContext :DbContext
    {
        public SiparisContext() :base("name=SiparisContext")
        {
            Database.SetInitializer(new MyInitializationStrategy());
        }
        public DbSet <PizzaCesidi> PizzaCesitleri { get; set; }
        public DbSet <EkstraMalzeme> EkstraMalzemeler { get; set; }

        public DbSet <Siparis> Siparisler { get; set; }
    }
}
