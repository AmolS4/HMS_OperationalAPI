using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HMS.DBO.Models
{
    public partial class Dashboard
    {
        public int? EmployeeId { get; set; }
        public string CountOfPatientDiagnosed { get; set; }
        public int? PendingCount { get; set; }
        public DateTime? LastUpdatedOn { get; set; }
    }
}
