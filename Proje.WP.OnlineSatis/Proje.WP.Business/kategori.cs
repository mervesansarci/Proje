using System.Collections.Generic;
using System.Linq;

namespace Proje.WP.Business
{
    class kategori
    {
        public int kategoriID { get; set; }
        public string kategoriAdi { get; set; }
        public string kategoriAciklama { get; set; }

        public List<Proje.WP.DataAccess.kategori> Listele()
        {
            Proje.WP.DataAccess.onlineSatisEntities ent = new DataAccess.onlineSatisEntities();
            var sonuc = ent.kategori.ToList();
            return sonuc;
        }

        public string VeriEkleme(Proje.WP.DataAccess.kategori nesne)
        {

            Proje.WP.DataAccess.onlineSatisEntities ekleme = new DataAccess.onlineSatisEntities();
            Proje.WP.DataAccess.kategori yeni = new DataAccess.kategori();
            yeni.kategoriAdi = nesne.kategoriAdi;
            yeni.kategoriAciklama = nesne.kategoriAciklama;
            ekleme.kategori.Add(yeni);
            ekleme.SaveChanges();
            var verileriGetir = Listele();
            return "1";
        }

        public string VeriGuncelle(Proje.WP.DataAccess.kategori nesne)
        {
            Proje.WP.DataAccess.onlineSatisEntities ekleme = new DataAccess.onlineSatisEntities();
            Proje.WP.DataAccess.kategori yeni = new DataAccess.kategori();
            var aranan = ekleme.kategori.Where(p => p.kategoriID == kategoriID).FirstOrDefault();
            aranan.kategoriAdi = nesne.kategoriAdi;
            ekleme.kategori.Add(aranan);
            ekleme.SaveChanges();
            var verileriGetir = Listele();
            return "1";
        }

        public string VeriSil(Proje.WP.DataAccess.kategori nesne)
        {
            Proje.WP.DataAccess.onlineSatisEntities silme = new DataAccess.onlineSatisEntities();
            Proje.WP.DataAccess.kategori yeni = new DataAccess.kategori();
            var aranan = silme.kategori.Where(p => p.kategoriID == kategoriID).FirstOrDefault();
            aranan.kategoriAdi = nesne.kategoriAdi;
            silme.kategori.Remove(aranan);
            silme.SaveChanges();
            var verileriGetir = Listele();
            return "1";
        }
    }
}
