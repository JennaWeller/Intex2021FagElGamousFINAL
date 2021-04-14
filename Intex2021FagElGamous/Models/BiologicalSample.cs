using System;
using System.Collections.Generic;

#nullable disable

namespace Intex2021FagElGamous.Models
{
    public partial class BiologicalSample
    {
        public string BioSampleId { get; set; }
        public string RackBag { get; set; }
        public string RackBagNum { get; set; }
        public string BurialSiteId { get; set; }
        public string Burial { get; set; }
        public string Date { get; set; }
        public string PreviouslySampled { get; set; }
        public string Notes { get; set; }
        public string Initials { get; set; }
        public string Cluster { get; set; }
    }
}
