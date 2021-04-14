using System;
using System.Collections.Generic;
using Intex2021FagElGamous.Models.ViewModels;

namespace Intex2021FagElGamous.Models
{

    public class ViewBurialsViewModel
    {
        public List<ViewBurialsBurialModel> Burials { get; set; }
        public PageNumberingInfo PageNumberingInfo { get; set; }
        public ViewBurialsFilteringInfo Filter { get; set; }
    }

    public class ViewBurialsFilteringInfo
    {
        public string HasImage { get; set; }

        public string NS { get; set; }
        public int NSTop { get; set; }
        public int NSBottom { get; set; }
        public string EW { get; set; }
        public int EWTop { get; set; }
        public int EWBottom { get; set; }
        public string Quadrant { get; set; }

        public double BurialwesttoheadMin { get; set; }
        public double BurialwesttoheadMax { get; set; }
        public double BurialwesttofeetMin { get; set; }
        public double BurialwesttofeetMax { get; set; }
        public double BurialsouthtoheadMin { get; set; }
        public double BurialsouthtoheadMax { get; set; }
        public double BurialsouthtofeetMin { get; set; }
        public double BurialsouthtofeetMax { get; set; }
        public double BurialdepthMin { get; set; }
        public double BurialdepthMax { get; set; }
        public string Goods { get; set; }
        public string GenderCode { get; set; }
        public int YearonskullMin { get; set; }
        public int YearonskullMax { get; set; }
        public string Byusample { get; set; }
        public long? BurialNumber { get; set; }
        public string BodyAnalysis { get; set; }
        public string SkullatMagazine { get; set; }
        public string SexSkull2018 { get; set; }
        public string AgeSkull2018 { get; set; }
        public string SkullTrauma { get; set; }
        public string PostcraniaTrauma { get; set; }
        public string CribraOrbitala { get; set; }
        public string PoroticHyperostosis { get; set; }
        public string PoroticHyperostosisLocations { get; set; }
        public string MetopicSuture { get; set; }
        public string ButtonOsteoma { get; set; }
        public string Osteologyunknowncomment { get; set; }
        public string TemporalMandibularJointOsteoarthritisTmjoa { get; set; }
        public string LinearHypoplasiaEnamel { get; set; }
        public string Yearexcav { get; set; }
        public string MonthExcavated { get; set; }
        public string DateExcavated { get; set; }
        public string Burialpreservation { get; set; }
        public string Burialwrapping { get; set; }
        public string Burialadultchild { get; set; }
        public string Burialgendermethod { get; set; }
        public string BurialDirection { get; set; }
        public string Burialageatdeath { get; set; }
        public string Burialagemethod { get; set; }
        public string HairColorCode { get; set; }
        public string Burialsampletaken { get; set; }
        public string LengthM { get; set; }
        public string Cluster { get; set; }
        public string FaceBundle { get; set; }
        public string OsteologyNotes { get; set; }

    }

    public class ViewBurialsBurialModel
    {
        public string HasImage { get; set; }
        public string NS { get; set; }
        public int NSTop { get; set; }
        public int NSBottom { get; set; }
        public string EW { get; set; }
        public int EWTop { get; set; }
        public int EWBottom { get; set; }
        public string Quadrant { get; set; }
        public string Burialwesttohead { get; set; }
        public string Burialwesttofeet { get; set; }
        public string Burialsouthtohead { get; set; }
        public string Burialsouthtofeet { get; set; }
        public string Burialdepth { get; set; }
        public string Length { get; set; }
        public string Goods { get; set; }
        public string GenderCode { get; set; }
        public int BurialSiteId { get; set; }
        public int BurialNumber { get; set; }
        public string OsteologyNotes { get; set; }
    }


}