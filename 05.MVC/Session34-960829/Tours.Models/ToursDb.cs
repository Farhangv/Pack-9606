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
    }

}