using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HMS.DBO.Models
{
    public partial class Appointment
    {
        public int Id { get; set; }
        public string Ssn { get; set; }
        public string PatientId { get; set; }
        public string AppointmentId { get; set; }
        public string NurseId { get; set; }
        public string PhysicianId { get; set; }
        public DateTime? AppointmentDate { get; set; }
        public string MeetingTitle { get; set; }
        public string AppointmentStatus { get; set; }
        public TimeSpan? ScheduledTime { get; set; }
        public DateTime? ScheduledDate { get; set; }
        public string Description { get; set; }
        public string StatusReason { get; set; }
        public string Comment { get; set; }

        public virtual PatientVitalDetails PatientVitalDetails { get; set; }
    }
}
