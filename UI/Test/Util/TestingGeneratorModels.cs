using Models.LifeFormModels;
using Models.LifeFormModels.Brain;
using Models.LifeFormModels.Senses;
using Models.WorldForms;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Util
{
    public class TestingGeneratorModels
    {

        public IUniverseModel GenerateUniverse()
        {
            return new UniverseModel()
            {
                lifeForms = new List<ILifeForm>(),
                PlanetModel = new List<PlanetModel>() {
                    new PlanetModel(){
                        worldSize = 200
                    }
                }
            };
        }
    }
}
