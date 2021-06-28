using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HMS.DBO.Models
{
    public partial class PatientAllergyDetails
    {
        public int Id { get; set; }
        public string PatientId { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public int? AllergyId { get; set; }
        public string AllergyType { get; set; }

        public virtual Allergy Allergy { get; set; }
    }
}
