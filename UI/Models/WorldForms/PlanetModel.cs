using System;
using System.Collections.Generic;
using System.Text;

namespace Models.WorldForms
{
    public class PlanetModel
    {
        /// <summary>
        /// Always must be more than 4
        /// </summary>
        public int worldSize { get; set; }

        public string seed { get; set; }
        public List<List<TerrainModel>> world { get; set; }

        
    }
}
