using System;
using System.Collections.Generic;
using System.Text;

namespace Models.WorldProperties
{
    public interface IWorldPosition
    {
        /// <summary>
        /// Width position of the world
        /// </summary>
        public int Latitude { get; set; }
        /// <summary>
        /// Height position of the world
        /// </summary>
        public int Longitude { get; set; }
        /// <summary>
        /// Elevation position of the world
        /// </summary>
        public int Rise { get; set; }
    }
}
