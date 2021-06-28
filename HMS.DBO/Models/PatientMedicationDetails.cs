using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HMS.DBO.Models
{
    public partial class PatientMedicationDetails
    {
        public int Id { get; set; }
        public string PatientId { get; set; }
        public DateTime? PhysicianCheckupDate { get; set; }
        public string Medication { get; set; }
        public string Dosage { get; set; }
        public string Dscription { get; set; }
        public string AppointmentId { get; set; }
        public string MedicationFrequency { get; set; }
        public string MedicationStrength { get; set; }
        public string PreRequisite { get; set; }

        public virtual Patient Patient { get; set; }
    }
}
