﻿using System;
using System.Collections.Generic;

#nullable disable

namespace QRChecker.Models
{
    public partial class SignerMenu
    {
        public int Id { get; set; }
        public string Menu { get; set; }
        public string MenuRoles { get; set; }
        public string KeysRoles { get; set; }
    }
}
