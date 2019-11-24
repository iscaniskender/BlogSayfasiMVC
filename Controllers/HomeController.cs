using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogMVC.Models;

namespace BlogMVC.Controllers
{
    public class HomeController : Controller
    {
        private Context context = new Context();
        // GET: Home
        public ActionResult Index()
        {
            var bloglar = context.Bloglar.
            Select(i => new blogmodel()
            {
                Id = i.Id,
                Baslik = i.Baslik.Length > 100 ? i.Baslik.Substring(0, 100) + "..." : i.Baslik,
                Aciklama = i.Aciklama,
                Resim = i.Resim,
                icerik=i.Icerik,
                EklenmeTarihi = i.EklenmeTarihi,
                Onay = i.Onay,
                Anasayfa = i.Anasayfa
            })
            .Where(i => i.Onay == true && i.Anasayfa == true);

            return View(bloglar);
        }
    }
}