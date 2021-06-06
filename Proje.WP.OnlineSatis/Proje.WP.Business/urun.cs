using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.WP.Business
{
    public class urun
    {
        public int urunID { get; set; }
        public string urunAdi { get; set; }
        public decimal urunFiyati { get; set; }
        public System.DateTime urunEklenmeTarihi { get; set; }
        public int KategoriID { get; set; }
        public int MarkaID { get; set; }
        public string urunAciklama { get; set; }
        public int urunKDV { get; set; }
        public int urunStok { get; set; }
        public bool isActive { get; set; }

        public List<Proje.WP.DataAccess.urun> Listele()
        {
            Proje.WP.DataAccess.onlineSatisEntities ent = new DataAccess.onlineSatisEntities();
            var sonuc = ent.urun.ToList();
            return sonuc;
        }

        public string VeriEkleme(Proje.WP.DataAccess.urun nesne)
        {

            Proje.WP.DataAccess.onlineSatisEntities ekleme = new DataAccess.onlineSatisEntities();
            Proje.WP.DataAccess.urun yeni = new DataAccess.urun();
            yeni.urunAdi = nesne.urunAdi;
            yeni.urunFiyati = nesne.urunFiyati;
            yeni.urunEklenmeTarihi = dateTimePicker1.Value;
            yeni.urunAciklama = nesne.urunAciklama;
            yeni.urunKDV = nesne.urunKDV;
            yeni.urunStok = nesne.urunStok;
            yeni.isActive = nesne.urunStok;
            ekleme.urun.Add(yeni);
            ekleme.SaveChanges();
            var verileriGetir = Listele();
            return "1";
        }
        public string VeriGuncelle(Proje.WP.DataAccess.urun nesne)
        {
            Proje.WP.DataAccess.onlineSatisEntities ekleme = new DataAccess.onlineSatisEntities();
            Proje.WP.DataAccess.urun yeni = new DataAccess.urun();
            var aranan = ekleme.urun.Where(p => p.urunID == urunID).FirstOrDefault();
            aranan.urunAdi = nesne.urunAdi;
            aranan.urunFiyati = nesne.urunFiyati;
            //aranan.urunEklenmeTarihi = dateTimePicker1.Value;
            aranan.urunAciklama = nesne.urunAciklama;
            aranan.urunKDV = nesne.urunKDV;
            aranan.urunStok = nesne.urunStok;
            //yeni.isActive = nesne.urunStok;
            ekleme.urun.Add(aranan);
            ekleme.SaveChanges();
            var verileriGetir = Listele();
            return "1";
        }
        public string VeriSil(Proje.WP.DataAccess.urun nesne)
        {
            Proje.WP.DataAccess.onlineSatisEntities silme = new DataAccess.onlineSatisEntities();
            Proje.WP.DataAccess.urun yeni = new DataAccess.urun();
            var aranan = silme.urun.Where(p => p.urunID == urunID).FirstOrDefault();
            aranan.urunAdi = nesne.urunAdi;
            silme.urun.Remove(aranan);
            silme.SaveChanges();
            var verileriGetir = Listele();
            return "1";
        }
    }
}
