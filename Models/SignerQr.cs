using System;
using System.Collections.Generic;

#nullable disable

namespace QRChecker.Models
{
    public partial class SignerQr
    {
        public int Id { get; set; }
        public int? RequestId { get; set; }
        public string Positions { get; set; }
        public string Url { get; set; }
    }
}
