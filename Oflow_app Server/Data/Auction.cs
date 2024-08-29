using System;
using System.Collections.Generic;

namespace Oflow_app_Server.Data
{
    public partial class Auction
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
