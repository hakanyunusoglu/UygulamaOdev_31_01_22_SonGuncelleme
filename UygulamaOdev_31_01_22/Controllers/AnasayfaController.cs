using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UygulamaOdev_31_01_22.Models;
using UygulamaOdev_31_01_22.Models.DTO;

namespace UygulamaOdev_31_01_22.Controllers
{
    public class AnasayfaController : Controller
    {
        // GET: Anasayfa
        sinavdbEntities4 db = new sinavdbEntities4();

        public ActionResult Anasayfa()
        {
            List<UrunDTO> urunList = db.Urunlers.Select(x => new UrunDTO
            {
                UrunID = x.UrunID,
                UrunAD = x.UrunAd,
                UrunResim = x.UrunResim,
                Aciklama = x.UrunAciklama,
                KategoriID = x.KategoriID,
                Fiyat = (decimal)x.Fiyat,
                KategoriADI = x.Kategori.KategoriAD
            }).ToList();
            return View(urunList);
        }
    }
}