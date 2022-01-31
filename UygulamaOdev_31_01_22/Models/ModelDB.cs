using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UygulamaOdev_31_01_22.Models.DTO;

namespace UygulamaOdev_31_01_22.Models
{
    public class ModelDB
    {
        public List<TarihceDTO> tarihceList { get; set; }
        public Tarihce tarihce { get; set; }
        public List<OzellikDTO> ozellikList { get; set; }
        public Ozellik ozellik { get; set; }
    }
}