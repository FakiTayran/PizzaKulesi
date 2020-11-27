using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaKulesi.Models
{
    public class MyInitializationStrategy :CreateDatabaseIfNotExists<SiparisContext>
    {
        protected override void Seed(SiparisContext context)
        {

            PizzaCesidi pizza1 = new PizzaCesidi { CesitAdi = "Karışık"};
            PizzaCesidi pizza2 = new PizzaCesidi { CesitAdi = "Alaturca"};
            PizzaCesidi pizza3 = new PizzaCesidi { CesitAdi = "Margarita" };
            PizzaCesidi pizza4 = new PizzaCesidi { CesitAdi = "Tavuklu" };
            EkstraMalzeme malzeme = new EkstraMalzeme { MalzemeAdi = "İstemiyorum" };
            EkstraMalzeme malzeme1 = new EkstraMalzeme { MalzemeAdi = "Mısır" };
            EkstraMalzeme malzeme2 = new EkstraMalzeme { MalzemeAdi = "Soğan"};
            EkstraMalzeme malzeme3 = new EkstraMalzeme { MalzemeAdi = "Zeytin" };
            EkstraMalzeme malzeme4 = new EkstraMalzeme { MalzemeAdi = "Biber" };

            Siparis siparis1 = new Siparis()
            {
                TeslimDurumu = false,
                MusteriTamAd = "Tayran Arıduru",
                Adres = "Keçiören 102/16",
                Pizza = pizza1,
                Malzemeler = new List<EkstraMalzeme>(){malzeme1,malzeme3},
            };
            Siparis siparis2 = new Siparis()
            {
                TeslimDurumu = true,
                MusteriTamAd = "Hilal Demirden",
                Adres = "Yalvaç Isparta",
                Pizza = pizza2,
                Malzemeler = new List<EkstraMalzeme>() { malzeme2, malzeme4 },
            };

            context.PizzaCesitleri.AddRange(new PizzaCesidi[] { pizza1, pizza2,pizza3,pizza4});
            context.EkstraMalzemeler.AddRange(new EkstraMalzeme[] {malzeme,malzeme1, malzeme2,malzeme3,malzeme4});
            context.Siparisler.AddRange(new Siparis[] { siparis1, siparis2});
            
        }
    }
}
