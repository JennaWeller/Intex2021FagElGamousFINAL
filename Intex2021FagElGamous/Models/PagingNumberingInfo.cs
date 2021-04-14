using System;
using System.Collections.Generic;

namespace Intex2021FagElGamous.Models.ViewModels
{
    public class PageNumberingInfo
    {
        public int NumItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public int TotalNumItems { get; set; }

        //calculates the number of pages
        public int NumPages => (int)Math.Ceiling((float)TotalNumItems / NumItemsPerPage);

    }
}
