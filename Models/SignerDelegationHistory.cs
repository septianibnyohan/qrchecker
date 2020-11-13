using System;
using System.Collections.Generic;

#nullable disable

namespace QRChecker.Models
{
    public partial class SignerDelegationHistory
    {
        public int Id { get; set; }
        public int UserOrigin { get; set; }
        public int? UserDelegated { get; set; }
        public string Reason { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
