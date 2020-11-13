﻿using System;
using System.Collections.Generic;

#nullable disable

namespace QRChecker.Models
{
    public partial class SignerWorkflow
    {
        public int WorkflowId { get; set; }
        public int? RequestId { get; set; }
        public int? EmployeeId { get; set; }
        public string Document { get; set; }
        public string SigningKey { get; set; }
        public string Positions { get; set; }
        public string ChainPositions { get; set; }
        public string ChainEmails { get; set; }
        public string SenderNote { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }
        public int? UpdatedBy { get; set; }
        public int? OrderBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string FaceAuthId { get; set; }
        public string FaceAuthStatus { get; set; }
        public string FaceAuthPayload { get; set; }
    }
}
