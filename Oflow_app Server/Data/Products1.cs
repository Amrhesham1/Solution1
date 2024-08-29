using System;
using System.Collections.Generic;

namespace Oflow_app_Server.Data
{
    public partial class Products1
    {
        public Products1()
        {
            Assigned3s = new HashSet<Assigned3>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public Guid StatusId { get; set; }
        public Guid CategoryId { get; set; }
        public int YearsOfUsage { get; set; }
        public string StartingPrice { get; set; } = null!;
        public DateTime CreationDate { get; set; }

        public virtual Category1 Category { get; set; } = null!;
        public virtual Status1 Status { get; set; } = null!;
        public virtual ICollection<Assigned3> Assigned3s { get; set; }
    }
}
