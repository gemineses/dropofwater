using Models.WorldForms;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.WorldInterfaces
{
    public interface IWorldGeneratorServices
    {
        PlanetModel CreatePlanet(PlanetModel planet);
    }
}
