using Models.LifeFormModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.WorldForms
{
    public class UniverseModel : IUniverseModel
    {
        public List<PlanetModel> PlanetModel { get; set; }
        public List<ILifeForm> lifeForms { get; set; }
    }
}
