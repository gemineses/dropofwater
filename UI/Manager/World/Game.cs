using Manager.Interfaces;
using Models.LifeFormModels;
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
        private IGameRunningInteractions _gameRunningInteractions = null;
        private IUniverseModel _universeModel = null;
        
        public Game(IUniverseModel universeModel, IWorldGeneratorServices worldGeneratorServices, IGameRunningInteractions gameRunningInteractions) {
            _gameRunningInteractions = gameRunningInteractions;
            _universeModel = universeModel;
            _worldGeneratorServices = worldGeneratorServices;
        }

        public void StartGame()
        {
            _universeModel.PlanetModel[0] = _worldGeneratorServices.CreatePlanet(_universeModel.PlanetModel[0]);
        }

        public void UpdateGame()
        {
            _gameRunningInteractions.MoveEnvironment(_universeModel.lifeForms);
        }
    }
}
