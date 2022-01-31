using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UygulamaOdev_31_01_22.Models.DTO
{
    public class TarihceDTO
    {
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public string Resim { get; set; }

        public List<OzellikDTO> ozellikList { get; set; }


    }
}