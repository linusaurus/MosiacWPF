using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Database.Models;

namespace Database.Models
{
    public class NFRC
    {
        public int ID { get; set; }
        public string CPD { get; set; }
        public double? GroupID { get; set; }
        public string ManufacturerProductCode { get; set; }
        public string FrameSashType { get; set; }
        public double? Ufactor { get; set; }
        public double? SHGC { get; set; }
        public double? VT { get; set; }
        public double? CondensationResistance { get; set; }
        public double? GlazingLayers { get; set; }
        public string LowE { get; set; }
        public double? GapWidths { get; set; }
        public string Spacer { get; set; }
        public string GapFill { get; set; }
        public string Grid { get; set; }
        public double? Divider { get; set; }
        public string Tint { get; set; }
    }
}
