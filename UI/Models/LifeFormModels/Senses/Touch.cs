using Models.Enums.Mind;
using Models.LifeFormModels.Brain;
using Models.WorldProperties;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.LifeFormModels.Senses
{
    public class Touch: ISenses
    {
        public EnumSenses Type { get => EnumSenses.touch; }
        public string Message { get; set; }
    }
}
