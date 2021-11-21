using Models.Enums.GroundTypes;
using Models.WorldForms;
using Services.WorldInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.World
{
    public class WorldGeneratorServices: IWorldGeneratorServices
    {
        public PlanetModel CreatePlanet(PlanetModel planet)
        {
            if (planet.worldSize < 4) throw new Exception("world can't be less than 4 of size");
            int averageWorldSpace = CalculateAverageWorldSpace(planet.worldSize);
            return GenerateTerrain(planet, averageWorldSpace);
        }

        private PlanetModel GenerateTerrain(PlanetModel planet, int averageWorldSpace)
        {
            var world = new List<List<TerrainModel>>();
            if (averageWorldSpace == 1) {
                world = GenerateDirtyTerrain(planet.worldSize, averageWorldSpace);   
            }

            planet.world = world;
            return planet;
        }

        private List<List<TerrainModel>> GenerateDirtyTerrain(int worldSize, int averageWorldSpace)
        {
            var world = new List<List<TerrainModel>>();
            for (int height = 0; height < worldSize; height++)
            {
                var worldWith = new List<TerrainModel>();
                for (int width = 0; width < worldSize; width++)
                {
                    worldWith.Add(new TerrainModel()
                    {
                        enumGroundTypes = EnumGroundType.dirt
                    });
                }
                world.Add(worldWith);
            }
            return world;
        }



        /// <summary>
        /// Calculate space recomended to change terrain models
        /// </summary>
        /// <param name="worldSize"></param>
        /// <returns></returns>
        private int CalculateAverageWorldSpace(int worldSize) {
            if (worldSize < 16) {
                return SetWorldToSmall();
            }
            return 1;
        }

        private int SetWorldToSmall() {
            return 1;
        }
    }
}
