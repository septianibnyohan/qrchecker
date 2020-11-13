using System;
using System.Collections.Generic;

#nullable disable

namespace QRChecker.Models
{
    public partial class SignerPayload
    {
        public int Id { get; set; }
        public string TrxCode { get; set; }
        public DateTime? TrxDate { get; set; }
        public string TrxStatus { get; set; }
        public string TrxBodyRequest { get; set; }
        public string TrxReferenceId { get; set; }
    }
}
