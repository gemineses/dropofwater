﻿using Models.Enums.Mind;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Models.Brain
{
    public interface ISenses
    {
        public EnumSenses Type { get; set; }
        public string Message { get; set; }
    }
}
