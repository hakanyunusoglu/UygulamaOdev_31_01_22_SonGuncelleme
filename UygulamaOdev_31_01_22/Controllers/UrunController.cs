using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UygulamaOdev_31_01_22.Models;
using UygulamaOdev_31_01_22.Models.DTO;

namespace UygulamaOdev_31_01_22.Controllers
{
    public class UrunController : Controller
    {
        // GET: Urun
        sinavdbEntities4 db = new sinavdbEntities4();
        UrunDTO model = new UrunDTO();
        public ActionResult Detay(int id)
        {
            model.urunler = db.Urunlers.Find(id);
            return View(model);
        }
    }
}