using Models.Enums.Mind;
using Models.LifeFormModels.Brain;
using Models.WorldProperties;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.LifeFormModels.Senses
{
    public class Vision : ISenses
    {
        public EnumSenses Type { get => EnumSenses.sight; }

        public string Message { get; set; }

        List<IMass> MassesDetected { get; set; }
    }
}
