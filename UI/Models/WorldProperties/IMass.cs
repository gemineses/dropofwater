using System;
using System.Collections.Generic;
using System.Text;

namespace Models.WorldProperties
{
    public interface IMass:ITemperature, IHardness, IWorldPosition
    {
        public int Height { get; set; }
        public int Width { get; set; }
    }
}
