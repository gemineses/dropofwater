using Manager.Interfaces;
using Manager.World;
using Models.WorldForms;
using NUnit.Framework;
using Services.World;
using Services.WorldInterfaces;
using System;
using System.Collections.Generic;
using System.Text;
using WorldTrigger.Actions;
using WorldTrigger.Interfaces;

namespace Test.GameRunningTests
{
    [TestFixture]
    public class GameTests
    {
        private IGame _gameEngineInstance = null;
        private IWorldGeneratorServices _worldGeneratorServices = null;
        private IWorldInteraction _worldInteraction = null;

        [SetUp]
        public void GameTest() {
            _worldGeneratorServices = new WorldGeneratorServices();
            _worldInteraction = new WorldInteraction();
            _gameEngineInstance = new Game(_worldGeneratorServices, _worldInteraction);
        }

        [Test]
        [TestCase(200, TestName = "Started new world")]
        public void RunGame(int worldSize) {
            //Arrange
            var planetModel = new PlanetModel();
            planetModel.worldSize = worldSize;

            //Act
            _gameEngineInstance.StartGame(planetModel);

            //Assert
            _gameEngineInstance.UpdateGame();
        }
    }
}
