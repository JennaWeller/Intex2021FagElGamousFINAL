using System;
using System.Collections.Generic;

#nullable disable

namespace Intex2021FagElGamous.Models
{
    public partial class BurialSite
    {
        public string BurialSiteId { get; set; }
        public string NS { get; set; }
        public string Nstop { get; set; }
        public string Nsbottom { get; set; }
        public string EW { get; set; }
        public string Ewtop { get; set; }
        public string Ewbottom { get; set; }
        public string Quadrant { get; set; }
    }
}
