using Manager.Interfaces;
using Models.WorldForms;
using Services.World;
using Services.WorldInterfaces;
using System;
using System.Collections.Generic;
using System.Text;
using WorldTrigger.Actions;
using WorldTrigger.Interfaces;

namespace Manager.World
{
    public class Game : IGame
    {
        private IWorldGeneratorServices _worldGeneratorServices = null;
        private IWorldInteraction _worldInteraction = null;
        public Game(IWorldGeneratorServices worldGeneratorServices, IWorldInteraction worldInteraction) {
            _worldGeneratorServices = worldGeneratorServices;
            _worldInteraction = worldInteraction;
        }

        public void StartGame(PlanetModel planetModel)
        {
            planetModel = _worldGeneratorServices.CreatePlanet(planetModel);
            
        }

        public void UpdateGame()
        {
            
        }
    }
}
