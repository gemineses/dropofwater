using Models.Enums.Mind;
using Models.Models.Brain;
using Models.WorldProperties;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Models.Senses
{
    public class Touch: ISenses
    {
        public EnumSenses Type { get; set; }
        public string Message { get; set; }
    }
}
