using System;
using System.Collections.Generic;
using System.Linq;

namespace Proje.WP.Business
{
   public class musteri
    {
        public int musteriID { get; set; }
        public string musteriAdi { get; set; }
        public string musteriSoyadi { get; set; }
        public string email { get; set; }
        public Nullable<int> telefon { get; set; }
        public string sifre { get; set; }

        public string GuvenlikKontrol(string m_ad, string m_sifre)
        {
            Proje.WP.DataAccess.onlineSatisEntities ekleme = new DataAccess.onlineSatisEntities();

            var ara = ekleme.musteri.FirstOrDefault(item => item.musteriAdi == m_ad && item.sifre == m_sifre);

            if (ara != null)
                return "tamam";
            else
                return "yanlış kullanıcı";
        }

        public List<Proje.WP.DataAccess.urun> Listele()
        {
            Proje.WP.DataAccess.onlineSatisEntities ent = new DataAccess.onlineSatisEntities();
            var sonuc = ent.urun.ToList();

            return sonuc;
        }

        public string VeriEkleme(Proje.WP.DataAccess.musteri nesne)
        {

            Proje.WP.DataAccess.onlineSatisEntities ekleme = new DataAccess.onlineSatisEntities();
            Proje.WP.DataAccess.musteri yeni = new DataAccess.musteri();
            yeni.musteriAdi = nesne.musteriAdi;
            yeni.musteriSoyadi = nesne.musteriSoyadi;
            yeni.email = nesne.email;
            yeni.telefon = nesne.telefon;
            yeni.sifre = nesne.sifre;
            ekleme.musteri.Add(yeni);
            ekleme.SaveChanges();
            var verileriGetir = Listele();
            return "1";
        }
        public string VeriGuncelle(Proje.WP.DataAccess.musteri nesne)
        {
            Proje.WP.DataAccess.onlineSatisEntities ekleme = new DataAccess.onlineSatisEntities();
            Proje.WP.DataAccess.musteri yeni = new DataAccess.musteri();
            var aranan = ekleme.musteri.Where(p => p.musteriID == musteriID).FirstOrDefault();
            aranan.musteriAdi = nesne.musteriAdi;
            aranan.musteriSoyadi = nesne.musteriSoyadi;
            aranan.email = nesne.email;
            aranan.telefon = nesne.telefon;
            aranan.sifre = nesne.sifre;
            ekleme.musteri.Add(aranan);
            ekleme.SaveChanges();
            var verileriGetir = Listele();
            return "1";
        }
        public string VeriSil(Proje.WP.DataAccess.musteri nesne)
        {
            Proje.WP.DataAccess.onlineSatisEntities silme = new DataAccess.onlineSatisEntities();
            Proje.WP.DataAccess.musteri yeni = new DataAccess.musteri();
            var aranan = silme.musteri.Where(p => p.musteriID == musteriID).FirstOrDefault();
            aranan.musteriID = nesne.musteriID;
            silme.musteri.Remove(aranan);
            silme.SaveChanges();
            var verileriGetir = Listele();
            return "1";
        }
    }
}
