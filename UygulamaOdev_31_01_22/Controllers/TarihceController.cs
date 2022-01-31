using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UygulamaOdev_31_01_22.Models;
using UygulamaOdev_31_01_22.Models.DTO;

namespace UygulamaOdev_31_01_22.Controllers
{
    
    public class TarihceController : Controller
    {
        // GET: Tarihce
        sinavdbEntities4 db = new sinavdbEntities4();
        ModelDB mdb = new ModelDB();
        public ActionResult Tarihce()
        {

            List<TarihceDTO> tarihceList = db.Tarihces.Select(x => new TarihceDTO
            {
                Aciklama = x.Aciklama,
                Baslik = x.Baslik,
                Resim = x.Resim
            }).ToList();
            mdb.ozellikList = db.Ozelliks.Select(x => new OzellikDTO
            { 
              ButonRenk = x.ButonRenk,
               Icon = x.Icon,
                OzellikAciklama = x.Aciklama
            }).ToList();
            return View(tarihceList);
        }
    }
}