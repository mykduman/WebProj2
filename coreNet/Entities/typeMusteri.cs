using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace coreNet.Entities
{
    public class typeMusteri
    {
        public int Id { get; set; }
        public string musteriAd { get; set; }
        public string musteriSoyad { get; set; }
        public string musteriMail { get; set; }
        public string musteriMesaj { get; set; }
        public string musteriIlce { get; set; }

        public int musteriTel { get; set; }

        public string musteriAtikTuru { get; set; }

        public decimal musteriMiktar { get; set; }
    }
}