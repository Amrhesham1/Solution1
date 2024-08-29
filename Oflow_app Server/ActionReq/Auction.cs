namespace Oflow_app_Server.ActionReq
{// Models/User.cs
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
    }

    // Models/Auction.cs
    public class Auction
    {
        public int AuctionId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public ICollection<Bid> Bids { get; set; }
    }

    // Models/Bid.cs
    public class Bid
    {
        public int BidId { get; set; }
        public decimal Amount { get; set; }
        public DateTime BidTime { get; set; }
        public int AuctionId { get; set; }
        public Auction Auction { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }

    // Models/Product.cs
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}