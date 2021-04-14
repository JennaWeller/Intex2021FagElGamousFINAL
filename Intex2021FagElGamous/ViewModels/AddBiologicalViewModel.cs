using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Intex2021FagElGamous.ViewModels
{
    public class AddBiologicalViewModel
    {
        public long? BioSampleId { get; set; }
        public string RackBag { get; set; }
        public long? RackBagNum { get; set; }
        public long? BurialSiteId { get; set; }
        public long? Burial { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/dd/MM}")]
        public string Date { get; set; }
        public string PreviouslySampled { get; set; }
        public string Notes { get; set; }
        public string Initials { get; set; }
        public string Cluster { get; set; }
        public string NS { get; set; }
        public long? Nstop { get; set; }
        public long? Nsbottom { get; set; }
        public string EW { get; set; }
        public long? Ewtop { get; set; }
        public long? Ewbottom { get; set; }
        public string Quadrant { get; set; }

    }
}