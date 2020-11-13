using System;
using System.Collections.Generic;

#nullable disable

namespace QRChecker.Models
{
    public partial class ViewWorkflowById
    {
        public int RequestId { get; set; }
        public string RequestorEmail { get; set; }
        public string RequestorNote { get; set; }
        public string Filename { get; set; }
    }
}
