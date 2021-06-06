using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Proje.Web.Api.Controllers
{
    public class HomeController : ApiController
    {
        //[HttpGet]
        //public string Test()
        //{
        //    return "APİ ÇALIŞIYOR - MERVE";
        //}

        [HttpGet]
        public List<Proje.WP.DataAccess.kategori> Listele()
        {
            Proje.WP.DataAccess.onlineSatisEntities ent = new WP.DataAccess.onlineSatisEntities();
            var sonuc = ent.kategori.ToList();

            return sonuc;
        }
    }
}
