using PizzaKulesi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaKulesi
{
    public partial class DuzenleYadaEkle : Form
    {
        public event EventHandler DegisiklikYapildi;
        private readonly SiparisContext db;
        bool duzenlemeMod = false;
        public DuzenleYadaEkle(SiparisContext context)
        {
            db = context;
            InitializeComponent();
            PizzalarıListele();
            MalzemeleriListele();
        }

        private void MalzemeleriListele()
        {
            lstMalzemeler.DataSource = db.EkstraMalzemeler.ToList();
        }

        private void PizzalarıListele()
        {
            lstPizzalar.DataSource = db.PizzaCesitleri.ToList();
        }

        private void btnPizzaEkle_Click(object sender, EventArgs e)
        {
            string pizzaAdi = txtPizzaAdi.Text;
            PizzaCesidi yeniPizza = new PizzaCesidi()
            {
                CesitAdi = pizzaAdi
            };

            db.PizzaCesitleri.Add(yeniPizza);
            db.SaveChanges();
            PizzalarıListele();
            DegisiklikYapıldiginda(EventArgs.Empty);
        }
            private void DegisiklikYapıldiginda(EventArgs args)
            {
                //if (DegisiklikYapildi !=null)
                //{
                //    DegisiklikYapildi(this, args);
                //}
                DegisiklikYapildi?.Invoke(this, args);
            }

        private void btnMalzemeEkle_Click(object sender, EventArgs e)
        {
            string malzemeAdi = txtMalzemeAdi.Text;
            EkstraMalzeme yeniMalzeme = new EkstraMalzeme()
            {
                MalzemeAdi = malzemeAdi
            };

            db.EkstraMalzemeler.Add(yeniMalzeme);
            db.SaveChanges();
            MalzemeleriListele();
        }

        private void btnPizzaSil_Click(object sender, EventArgs e)
        {
            if (lstPizzalar.SelectedIndex < 0)
            {
                MessageBox.Show("Silmek için bir pizza seçin");
                return;
            }
            PizzaCesidi silinecekPizza = lstPizzalar.SelectedItem as PizzaCesidi;

            db.PizzaCesitleri.Remove(silinecekPizza);
            db.SaveChanges();
            PizzalarıListele();
            DegisiklikYapıldiginda(EventArgs.Empty);

        }

        private void btnMalzemeSil_Click(object sender, EventArgs e)
        {
            if (lstMalzemeler.SelectedIndex < 0 )
            {
                MessageBox.Show("Silmek için bir malzeme seçin");
                return;
            }
            EkstraMalzeme silinecekMalzeme = lstMalzemeler.SelectedItem as EkstraMalzeme;
            db.EkstraMalzemeler.Remove(silinecekMalzeme);
            db.SaveChanges();
            MalzemeleriListele();
            DegisiklikYapıldiginda(EventArgs.Empty);

        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            btnIptal.Visible = true;
            duzenlemeMod = true;
            btnDuzenle.Visible = false;
            btnKaydet.Visible = true;
            txtPizzaAdi.Text = lstPizzalar.SelectedItem.ToString();
            txtMalzemeAdi.Text = lstMalzemeler.SelectedItem.ToString();
        }

        private void lstMalzemeler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (duzenlemeMod == true)
            {
            txtMalzemeAdi.Text = lstMalzemeler.SelectedItem.ToString();
            }
        }

        private void lstPizzalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (duzenlemeMod == true)
            {
            txtPizzaAdi.Text = lstPizzalar.SelectedItem.ToString();
            }

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            PizzaCesidi pizza = (PizzaCesidi)lstPizzalar.SelectedItem;
            pizza.CesitAdi = txtPizzaAdi.Text;
            EkstraMalzeme malzeme = (EkstraMalzeme)lstMalzemeler.SelectedItem;
            malzeme.MalzemeAdi = txtMalzemeAdi.Text;

            db.SaveChanges();
            PizzalarıListele();
            MalzemeleriListele();
            DegisiklikYapıldiginda(EventArgs.Empty);
        
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            btnKaydet.Visible = false;
            btnDuzenle.Visible = true;
            duzenlemeMod = false;
            txtMalzemeAdi.Text = string.Empty;
            txtPizzaAdi.Text = string.Empty;
            lstMalzemeler.SelectedIndex = -1;
            lstPizzalar.SelectedIndex = -1;
            btnIptal.Visible = false;
        }
    }
}
