using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZadatakEnergodata.Models
{
    public class RadnikModel
    {
        public int id { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public double plata { get; set; }
        public DateTime datumPlate { get; set; }
    }
}