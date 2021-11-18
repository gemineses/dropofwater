using System;
using System.Collections.Generic;
using System.Text;

namespace Models.WorldProperties
{
    public interface IWorldPosition
    {
        public int Latitude { get; set; }
        public int Longitude { get; set; }
        public int Rise { get; set; }
    }
}
