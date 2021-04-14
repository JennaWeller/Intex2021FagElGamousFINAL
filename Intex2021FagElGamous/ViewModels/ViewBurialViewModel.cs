using System;
using System.Collections.Generic;
using Intex2021FagElGamous.Models;

namespace Intex2021FagElGamous.ViewModels
{
    public class ViewBurialViewModel
    {
        public Burial Burial { get; set; }
        public BurialSite BurialSite { get; set; }

       // public List<datum> C14Data { get; set; }
        public List<CranialMain> CranialMains { get; set; }
        public List<FieldBook> FieldBooks { get; set; }
    }
}
