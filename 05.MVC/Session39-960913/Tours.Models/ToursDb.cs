namespace Tours.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ToursDb : DbContext
    {
        public ToursDb()
            //:base("server=.;database=ToursDb;uid=sa;pwd=developer;")
            : base("ToursDb")
        {
        }
        public DbSet<Person> People { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<TourPackage> TourPackages { get; set; }
        public DbSet<Attachment> Attachments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Person>()
            //    .Property(p => p.Name)
            //    .HasColumnName("FirstName");

            modelBuilder.Entity<TourPackage>()
                .HasMany(tp => tp.Passengers)
                .WithMany(p => p.TourPackages)
                .Map(m => m.ToTable("TourPackage_Passenger", "Tours"));
        }
    }

}