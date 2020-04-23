using System.Data.Entity;

namespace CIAMTrial.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Center> Centers { get; set; }
        public DbSet<Donation> Donations { get; set; }
        public DbSet<DonationDetail> DonationDetails { get; set; }
        public DbSet<Donor> Donors { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<RequestDetail> RequestDetails { get; set; }

        public DataContext() : base("name=con")
        {

        }
    }
}
