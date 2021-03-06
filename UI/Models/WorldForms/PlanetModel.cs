using System;
using System.Collections.Generic;
using System.Text;

namespace Models.WorldForms
{
    public class PlanetModel : IPlanetModel
    {
        public int worldSize { get; set; }
        public string seed { get; set; }
        public List<List<TerrainModel>> world { get; set; }
    }
}
