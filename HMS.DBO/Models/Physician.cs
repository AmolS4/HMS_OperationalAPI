using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HMS.DBO.Models
{
    public partial class Physician
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string PhysicianName { get; set; }
        public string Ssn { get; set; }
        public string PhysicianId { get; set; }
        public string Title { get; set; }
        public DateTime? LastUpdatedOn { get; set; }

        public virtual Login PhysicianNavigation { get; set; }
    }
}
