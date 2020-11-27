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
    public partial class Form1 : Form
    {

        SiparisContext db = new SiparisContext();
        bool duzenlemeModu;
        public Form1()
        {
            InitializeComponent();
            dgvSiparisler.AutoGenerateColumns = false;
            PizzaCesidiListele();
            EkstraMalzemeListele();
            SiparisDetaylariListele();
        }

        private void SiparisDetaylariListele()
        {
            IQueryable<Siparis> siparisler = db.Siparisler; //(IQueryable --sorgulanabilir tür.)

            if (cbTeslimEdileniGizle.Checked == true)
                siparisler = siparisler.Where(x => x.TeslimDurumu == false);
            dgvSiparisler.DataSource = siparisler.ToList();
        }

        private void EkstraMalzemeListele()
        {
            clbEkstraMalzemeler.DataSource = db.EkstraMalzemeler.ToList();
            clbEkstraMalzemeler.DisplayMember = "MalzemeAdi";
        }

        private void PizzaCesidiListele()
        {
            cboPizzaCesidi.DataSource = db.PizzaCesitleri.ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string tamAd = txtAdSoyad.Text.Trim();
            string adres = txtAdres.Text.Trim();
            bool teslimDurumu = cbTeslimEdildi.Checked;
            Siparis siparis = new Siparis();
            if (tamAd == "")
            {
                MessageBox.Show("İsim Boş geçilemez");
                return;
            }
            if ((int)cboPizzaCesidi.SelectedValue == 0)
            {
                MessageBox.Show("Pizza seçimi boş geçilemez");
                return;
            }

            if (clbEkstraMalzemeler.CheckedItems == null)
            {
                MessageBox.Show("Ekstra malzeme istemiyorsanız İstemiyorum seçiniz.");
                return;
            }
            siparis.Malzemeler = clbEkstraMalzemeler.CheckedItems.OfType<EkstraMalzeme>().ToList();
            if (adres == "")
            {
                MessageBox.Show("Adres boş geçilemez");
                return;
            }

            siparis.Pizza = (PizzaCesidi)cboPizzaCesidi.SelectedItem;
            siparis.MusteriTamAd = tamAd;
            siparis.Adres = adres;
            siparis.TeslimDurumu = teslimDurumu;
            db.Siparisler.Add(siparis);
            db.SaveChanges();
            SiparisDetaylariListele();
            FormuTemizle();

        }

        private void btnSiparisSil_Click(object sender, EventArgs e)
        {
            if (dgvSiparisler.SelectedRows.Count < 0)
            {
                MessageBox.Show("Silmek için bir sipariş seçin");
                return;
            }

            Siparis siparis = (Siparis)dgvSiparisler.SelectedRows[0].DataBoundItem;
            db.Siparisler.Remove(siparis);
            db.SaveChanges();
            SiparisDetaylariListele();

        }

        private void btnSiparisDuzenle_Click(object sender, EventArgs e)
        {
            if (dgvSiparisler.SelectedRows.Count < 0)
            {
                MessageBox.Show("Düzenlemek için bir sipariş seçin");
                return;
            }

            //düzenleme modu
            duzenlemeModu = true;
            DuzenleModu();
        }

        private void DuzenleModu()
        {
            FormuTemizle();
            if (duzenlemeModu == true)
            {
                btnDuzenle.Visible = true;
                btnEkle.Visible = false;
                btnKaydet.Visible = true;
                if (dgvSiparisler.SelectedRows.Count <= 0)
                {
                    return;
                }
                Siparis DuzenlenenSiparis = (Siparis)dgvSiparisler.SelectedRows[0].DataBoundItem;
                txtAdSoyad.Text = DuzenlenenSiparis.MusteriTamAd;
                cboPizzaCesidi.SelectedItem = DuzenlenenSiparis.Pizza;
                for (int i = 0; i < clbEkstraMalzemeler.Items.Count; i++)
                {
                    EkstraMalzeme ekstraMalzeme = clbEkstraMalzemeler.Items[i] as EkstraMalzeme;
                    if (DuzenlenenSiparis.Malzemeler.Any(x => x.Id == ekstraMalzeme.Id))
                    {
                        clbEkstraMalzemeler.SetItemChecked(i, true);
                    }
                }
                txtAdres.Text = DuzenlenenSiparis.Adres;
                cbTeslimEdildi.Checked = DuzenlenenSiparis.TeslimDurumu;
            }
        }

        private void FormuTemizle()
        {
            txtAdSoyad.Text = "";
            txtAdres.Text = "";
            clbEkstraMalzemeler.ClearSelected();
            for (int i = 0; i < clbEkstraMalzemeler.Items.Count; i++)
            {
                clbEkstraMalzemeler.SetItemChecked(i, false);
            }
            cboPizzaCesidi.SelectedIndex = -1;
            cbTeslimEdildi.Checked = false;
        }

        private void dgvSiparisler_SelectionChanged(object sender, EventArgs e)
        {
            DuzenleModu();

        }

        private void btnPizzaCesidiDuzenle_Click(object sender, EventArgs e)
        {
            DuzenleYadaEkle duzenleYadaEkle = new DuzenleYadaEkle(db);
            duzenleYadaEkle.DegisiklikYapildi += DuzenleYadaEkle_DegisiklikYapildi;
            duzenleYadaEkle.ShowDialog();
        }

        private void DuzenleYadaEkle_DegisiklikYapildi(object sender, EventArgs e)
        {
            SiparisDetaylariListele();
            PizzaCesidiListele();
            EkstraMalzemeListele();
        }

        private void btnEkstraMalzemeDuzenle_Click(object sender, EventArgs e)
        {
            DuzenleYadaEkle duzenleYadaEkle = new DuzenleYadaEkle(db);
            duzenleYadaEkle.ShowDialog();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Siparis duzenlenenSiparis = (Siparis)dgvSiparisler.SelectedRows[0].DataBoundItem;

            duzenlenenSiparis.MusteriTamAd = txtAdSoyad.Text;
            duzenlenenSiparis.Adres = txtAdres.Text;
            duzenlenenSiparis.Pizza = (PizzaCesidi)cboPizzaCesidi.SelectedItem;

            duzenlenenSiparis.Malzemeler = clbEkstraMalzemeler.CheckedItems.OfType<EkstraMalzeme>().ToList();

            duzenlenenSiparis.TeslimDurumu = cbTeslimEdildi.Checked;

            db.SaveChanges();
            SiparisDetaylariListele();


        }

        private void btnİptal_Click(object sender, EventArgs e)
        {

            SiparisDetaylariListele();
            btnEkle.Visible = true;
            btnKaydet.Visible = false;
            btnDuzenle.Visible = false;
            FormuTemizle();
            btnKaydet.Visible = false;
        }

        private void cbTeslimEdileniGizle_CheckedChanged(object sender, EventArgs e)
        {
            SiparisDetaylariListele();
        }
    }
}
