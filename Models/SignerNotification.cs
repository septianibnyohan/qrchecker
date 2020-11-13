using System;
using System.Collections.Generic;

#nullable disable

namespace QRChecker.Models
{
    public partial class SignerNotification
    {
        public int Id { get; set; }
        public int? Users { get; set; }
        public string Type { get; set; }
        public DateTime? Time { get; set; }
        public string Message { get; set; }
    }
}
