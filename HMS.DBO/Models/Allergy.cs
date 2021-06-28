using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HMS.DBO.Models
{
    public partial class Allergy
    {
        public Allergy()
        {
            PatientAllergyDetails = new HashSet<PatientAllergyDetails>();
        }

        public int Id { get; set; }
        public int AllergyId { get; set; }
        public string AllergyType { get; set; }
        public string AllergyName { get; set; }
        public string AllergyDescription { get; set; }
        public string AllergyClinicalInformation { get; set; }

        public virtual AllergyType AllergyTypeNavigation { get; set; }
        public virtual ICollection<PatientAllergyDetails> PatientAllergyDetails { get; set; }
    }
}
