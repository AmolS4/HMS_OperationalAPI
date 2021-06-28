using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HMS.DBO.Models
{
    public partial class Login
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public string EncryPassword { get; set; }
        public DateTime? CreationDate { get; set; }
        public string DefaultRole { get; set; }
        public string AdditionalRole { get; set; }
        public string OtpRequired { get; set; }
        public bool? IsEnabled { get; set; }

        public virtual Nurse Nurse { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual Physician Physician { get; set; }
    }
}
