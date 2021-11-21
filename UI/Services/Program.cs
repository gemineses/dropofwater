using Models.WorldForms;
using Services.World;
using System;

namespace Services
{
    class Program
    {
        static void Main(string[] args)
        {
            var world = new WorldGeneratorServices();
            var planet = world.CreatePlanet(new PlanetModel() { 
                seed = "123123",
                worldSize = 16
            });
            var x = 1;
        }
    }
}
