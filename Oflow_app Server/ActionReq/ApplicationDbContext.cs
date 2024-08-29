namespace Oflow_app_Server.ActionReq
{
    // Data/ApplicationDbContext.cs
    using Microsoft.EntityFrameworkCore;
   // using Oflow_app_Server.Models;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Auction> Auctions { get; set; }
        public DbSet<Bid> Bids { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
