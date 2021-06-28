using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HMS.DBO.Models
{
    public partial class Procedure
    {
        public int ProcedureId { get; set; }
        public string ProcedureCode { get; set; }
        public string ProcedureDescription { get; set; }
        public bool? ProcedureIsDepricated { get; set; }
    }
}
