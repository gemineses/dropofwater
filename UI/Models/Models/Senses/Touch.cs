using Models.Enums.Mind;
using Models.Models.Brain;
using Models.WorldProperties;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Models.Senses
{
    public class Touch : ISenses, IHardness, ITemperature
    {
        public EnumSenses Type { get; set; }
        //public int Presion { get; set; }//To add presion types
        public int Temperature { get; set; }
        //public int Texture { get; set; }//To add textures types
        public int HardnessLevel { get; set; }
    }
}
