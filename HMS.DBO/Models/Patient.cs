using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HMS.DBO.Models
{
    public partial class Patient
    {
        public Patient()
        {
            PatientMedicationDetails = new HashSet<PatientMedicationDetails>();
            PatientVisitDignosisDetails = new HashSet<PatientVisitDignosisDetails>();
            PatientVisitProcedureDetails = new HashSet<PatientVisitProcedureDetails>();
        }

        public int Id { get; set; }
        public string PatientId { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public DateTime? Dob { get; set; }
        public int? Age { get; set; }
        public string Gender { get; set; }
        public string Race { get; set; }
        public string Ethinicity { get; set; }
        public string LanguagesKnown { get; set; }
        public string Email { get; set; }
        public string HomeAddress { get; set; }
        public string ContactNumber { get; set; }
        public string EmergencyFname { get; set; }
        public string EmergencyLname { get; set; }
        public string Relationship { get; set; }
        public string EmergencyEmail { get; set; }
        public string EmergencyAddress { get; set; }
        public string EmergencyMobileNo { get; set; }
        public string AccessFlag { get; set; }
        public string TypeofAllergies { get; set; }
        public bool? IsAllergyFatal { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public string Ssn { get; set; }
        public string Title { get; set; }

        public virtual Login PatientNavigation { get; set; }
        public virtual ICollection<PatientMedicationDetails> PatientMedicationDetails { get; set; }
        public virtual ICollection<PatientVisitDignosisDetails> PatientVisitDignosisDetails { get; set; }
        public virtual ICollection<PatientVisitProcedureDetails> PatientVisitProcedureDetails { get; set; }
    }
}
