using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HMS.DBO.Models
{
    public partial class PatientVitalDetails
    {
        public int Id { get; set; }
        public string PatientId { get; set; }
        public decimal? Height { get; set; }
        public decimal? Weight { get; set; }
        public string Bp { get; set; }
        public decimal? BodyTemp { get; set; }
        public decimal? RespirationRate { get; set; }
        public DateTime? RecordedDate { get; set; }
        public string AppointmentId { get; set; }

        public virtual Appointment Appointment { get; set; }
    }
}
