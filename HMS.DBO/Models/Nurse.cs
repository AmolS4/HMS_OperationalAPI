using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HMS.DBO.Models
{
    public partial class Nurse
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string NurseId { get; set; }
        public string NurseName { get; set; }
        public string Ssn { get; set; }
        public DateTime? LastUpdatedOn { get; set; }

        public virtual Login NurseNavigation { get; set; }
    }
}
