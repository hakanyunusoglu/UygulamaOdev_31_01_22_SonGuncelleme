using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UygulamaOdev_31_01_22.Models;
using UygulamaOdev_31_01_22.Models.DTO;

namespace UygulamaOdev_31_01_22.Controllers
{
    public class HakkimizdaController : Controller
    {
        sinavdbEntities4 db = new sinavdbEntities4();
        public ActionResult Index()
        {
            List<HakkimizdaDTO> hakkimizdaList = db.Hakkimizdas.Select(x => new HakkimizdaDTO
            {
                 isim = x.isim,
                  aciklama = x.aciklama,
                   gorev = x.gorev,
                    resim = x.resim
            }).ToList();
            return View(hakkimizdaList);
        }
    }
}