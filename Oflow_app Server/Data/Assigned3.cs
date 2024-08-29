using System;
using System.Collections.Generic;

namespace Oflow_app_Server.Data
{
    public partial class Assigned3
    {
        public Guid Id { get; set; }
        public string UserId { get; set; } = null!;
        public Guid ProductId { get; set; }
        public DateTime? AssignedDate { get; set; }

        public virtual Products1 Product { get; set; } = null!;
        public virtual AspNetUser User { get; set; } = null!;
    }
}
