using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HMS.DBO.Models
{
    public partial class ExceptionLog
    {
        public int Id { get; set; }
        public string ExeptionMsg { get; set; }
        public string Source { get; set; }
        public DateTime? LoggedOn { get; set; }
    }
}
