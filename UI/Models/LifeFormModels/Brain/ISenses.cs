using Models.Enums.Mind;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.LifeFormModels.Brain
{
    public interface ISenses
    {
        public EnumSenses Type { get; }
        public string Message { get; set; }
    }
}
