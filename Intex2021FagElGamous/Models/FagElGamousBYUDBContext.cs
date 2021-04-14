using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Intex2021FagElGamous.Models
{
    public partial class FagElGamousBYUDBContext : DbContext
    {
        public FagElGamousBYUDBContext()
        {
        }

        public FagElGamousBYUDBContext(DbContextOptions<FagElGamousBYUDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BiologicalSample> BiologicalSamples { get; set; }
        public virtual DbSet<Burial> Burials { get; set; }
        public virtual DbSet<BurialSite> BurialSites { get; set; }
        public virtual DbSet<C14datum> C14data { get; set; }
        public virtual DbSet<CranialMain> CranialMains { get; set; }
        public virtual DbSet<FieldBook> FieldBooks { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=FagElGamousBYUDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<BiologicalSample>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BioSampleId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Burial)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Burial #");

                entity.Property(e => e.BurialSiteId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cluster)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Cluster #");

                entity.Property(e => e.Date)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Initials)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PreviouslySampled)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Previously Sampled");

                entity.Property(e => e.RackBag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Rack Bag");

                entity.Property(e => e.RackBagNum)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Rack BagNum");
            });

            modelBuilder.Entity<Burial>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Burial");

                entity.Property(e => e.AgeCodeSingle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Age Code SINGLE");

                entity.Property(e => e.AgeSkull2018)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("\"Age  (Skull;  2018)\"");

                entity.Property(e => e.BodyAnalysis)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Body Analysis");

                entity.Property(e => e.BurialAdultChild)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("burial adult child");

                entity.Property(e => e.BurialDepth)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("burial depth");

                entity.Property(e => e.BurialDirection)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Burial Direction");

                entity.Property(e => e.BurialKeyId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BurialKeyID");

                entity.Property(e => e.BurialNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Burial Number");

                entity.Property(e => e.BurialPreservation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("burial preservation");

                entity.Property(e => e.BurialSiteId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BurialSiteID");

                entity.Property(e => e.BurialSouthToFeet)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("burial south to feet");

                entity.Property(e => e.BurialSouthToHead)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("burial south to head");

                entity.Property(e => e.BurialWestToFeet)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("burial west to feet");

                entity.Property(e => e.BurialWestToHead)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("burial west to head");

                entity.Property(e => e.BurialWrapping)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("burial wrapping");

                entity.Property(e => e.Burialageatdeath)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("burialageatdeath");

                entity.Property(e => e.Burialagemethod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("burialagemethod");

                entity.Property(e => e.Burialgendermethod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("burialgendermethod");

                entity.Property(e => e.Burialsampletaken)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("burialsampletaken");

                entity.Property(e => e.ButtonOsteoma)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Button Osteoma");

                entity.Property(e => e.ByuSample)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BYU Sample");

                entity.Property(e => e.Cluster)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CribraOrbitala)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Cribra Orbitala");

                entity.Property(e => e.DateExcavated)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Date Excavated");

                entity.Property(e => e.DateOnSkull)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Date on Skull");

                entity.Property(e => e.FaceBundle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Face Bundle");

                entity.Property(e => e.Gamous)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GAMOUS");

                entity.Property(e => e.GenderCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Gender Code");

                entity.Property(e => e.Goods)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HairColorCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Hair Color Code");

                entity.Property(e => e.ImagesYn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ImagesYN");

                entity.Property(e => e.InitialsOfDataEntryChecker)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Initials of Data Entry Checker");

                entity.Property(e => e.InitialsOfDataEntryExpert)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Initials of Data Entry Expert");

                entity.Property(e => e.Length)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("length");

                entity.Property(e => e.LengthM)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("length(M)");

                entity.Property(e => e.LinearHypoplasiaEnamel)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Linear Hypoplasia Enamel");

                entity.Property(e => e.MetopicSuture)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Metopic Suture");

                entity.Property(e => e.MonthExcavated)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Month Excavated");

                entity.Property(e => e.MonthOnSkull)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Month on skull");

                entity.Property(e => e.OsteologyNotes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Osteology Notes");

                entity.Property(e => e.OsteologyUnknownComment)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Osteology unknown comment");

                entity.Property(e => e.PoroticHyperostosis)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Porotic Hyperostosis");

                entity.Property(e => e.PoroticHyperostosisLocations)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Porotic Hyperostosis (LOCATIONS)");

                entity.Property(e => e.PostcraniaAtMagazine)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Postcrania at Magazine");

                entity.Property(e => e.PostcraniaTrauma)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Postcrania Trauma");

                entity.Property(e => e.RackAndShelf)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Rack and Shelf");

                entity.Property(e => e.SexSkull2018)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("\"Sex  (Skull; 2018)\"");

                entity.Property(e => e.SkullAtMagazine)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Skull at Magazine");

                entity.Property(e => e.SkullTrauma)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Skull Trauma");

                entity.Property(e => e.TemporalMandibularJointOsteoarthritisTmjOa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Temporal Mandibular Joint Osteoarthritis (TMJ OA)");

                entity.Property(e => e.ToBeConfirmed)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TO BE CONFIRMED");

                entity.Property(e => e.YearExcav)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("year excav");

                entity.Property(e => e.YearOnSkull)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Year on skull");
            });

            modelBuilder.Entity<BurialSite>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BurialSite");

                entity.Property(e => e.BurialSiteId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BurialSiteID");

                entity.Property(e => e.EW)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("E W");

                entity.Property(e => e.Ewbottom)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EWBottom");

                entity.Property(e => e.Ewtop)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EWTop");

                entity.Property(e => e.NS)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("N S");

                entity.Property(e => e.Nsbottom)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NSBottom");

                entity.Property(e => e.Nstop)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NSTop");

                entity.Property(e => e.Quadrant)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<C14datum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("C14Data");

                entity.Property(e => e.Area)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AREA");

                entity.Property(e => e.Burial)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Burial#");

                entity.Property(e => e.BurialSiteId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.C14Sample2017)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("C14 Sample 2017");

                entity.Property(e => e.C14id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("C14Id");

                entity.Property(e => e.Calibrated95CalendarDateAvg)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Calibrated 95% Calendar Date AVG");

                entity.Property(e => e.Calibrated95CalendarDateMax)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Calibrated 95% Calendar Date MAX");

                entity.Property(e => e.Calibrated95CalendarDateMin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Calibrated 95% Calendar Date MIN");

                entity.Property(e => e.Calibrated95CalendarDateSpan)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Calibrated 95% Calendar Date SPAN");

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Column12)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Column 12");

                entity.Property(e => e.Conventional14cAgeBp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Conventional 14C age BP");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Foci)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocationNotes)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionS)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Question(s)");

                entity.Property(e => e.Rack)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SizeMl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Size (ml)");

                entity.Property(e => e.Tubenum)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TUBENum");

                entity.Property(e => e._14cCalendarDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("14C Calendar Date");
            });

            modelBuilder.Entity<CranialMain>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CranialMain");

                entity.Property(e => e.BasionBregmaHeight)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Basion-Bregma Height");

                entity.Property(e => e.BasionNasion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Basion-Nasion");

                entity.Property(e => e.BasionProsthionLength)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Basion-Prosthion Length");

                entity.Property(e => e.BizygomaticDiameter)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Bizygomatic Diameter");

                entity.Property(e => e.BodyGender)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BurialArtifactDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Burial  Artifact Description");

                entity.Property(e => e.BurialDepth)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Burial Depth");

                entity.Property(e => e.BurialNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Burial Number");

                entity.Property(e => e.BurialSiteId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BuriedWithArtifacts)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Buried with Artifacts");

                entity.Property(e => e.GilesGender)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InterorbitalBreadth)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Interorbital Breadth");

                entity.Property(e => e.MaximumCranialBreadth)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Maximum Cranial Breadth");

                entity.Property(e => e.MaximumCranialLength)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Maximum Cranial Length");

                entity.Property(e => e.MaximumNasalBreadth)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Maximum Nasal Breadth");

                entity.Property(e => e.NasionProsthion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Nasion-Prosthion");

                entity.Property(e => e.SampleNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Sample Number");
            });

            modelBuilder.Entity<FieldBook>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BurialNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Burial Number");

                entity.Property(e => e.BurialSiteId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BurialSiteID");

                entity.Property(e => e.FieldBook1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Field Book");

                entity.Property(e => e.FieldBookPageNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Field Book Page Number");

                entity.Property(e => e.FieldBooksId)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Image>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Image");

                entity.Property(e => e.BurialNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BurialSiteId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImageId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ImageID");

                entity.Property(e => e.Url)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("URL");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("firstName");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lastName");

                entity.Property(e => e.PassHash)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("passHash");

                entity.Property(e => e.PassIterations)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("passIterations");

                entity.Property(e => e.PassSalt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("passSalt");

                entity.Property(e => e.Role)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("role");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
