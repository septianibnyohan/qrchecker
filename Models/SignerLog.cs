using System;
using System.Collections.Generic;

#nullable disable

namespace QRChecker.Models
{
    public partial class SignerLog
    {
        public string Activity { get; set; }
        public DateTime Time { get; set; }
        public string IpAddress { get; set; }
        public int? Users { get; set; }
        public string Uri { get; set; }
        public int Id { get; set; }
    }
}
