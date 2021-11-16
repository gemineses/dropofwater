using Models.WorldProperties;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Models
{
    public class Matter : IHardness
    {
        public int HardnessLevel { get; set; }
    }
}
