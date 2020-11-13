using System;
using System.Collections.Generic;

#nullable disable

namespace QRChecker.Models
{
    public partial class CertificatePfx
    {
        public int CertId { get; set; }
        public string EmployeeId { get; set; }
        public string CertFile { get; set; }
        public string CertPassword { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? ExpiredFrom { get; set; }
        public DateTime? ExpiredTo { get; set; }
    }
}
