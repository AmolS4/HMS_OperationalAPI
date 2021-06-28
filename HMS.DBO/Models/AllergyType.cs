using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HMS.DBO.Models
{
    public partial class AllergyType
    {
        public int Id { get; set; }
        public string AllergyCode { get; set; }
        public string AllergyType1 { get; set; }
        public int AllergyId { get; set; }

        public virtual Allergy Allergy { get; set; }
    }
}
