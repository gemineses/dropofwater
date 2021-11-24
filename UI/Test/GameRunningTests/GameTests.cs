using Manager.Interfaces;
using Manager.World;
using Models.LifeFormModels;
using Models.LifeFormModels.Brain;
using Models.LifeFormModels.Senses;
using Models.WorldForms;
using NUnit.Framework;
using Services.World;
using Services.WorldInterfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Test.Util;
using WorldTrigger.Actions;
using WorldTrigger.Interfaces;

namespace Test.GameRunningTests
{
    [TestFixture]
    public class GameTests
    {
        private TestingGeneratorModels _generator = new TestingGeneratorModels();
        private IGame _gameEngineInstance = null;
        private IGameRunningInteractions _gameRunningInteractions = null;
        private IWorldGeneratorServices _worldGeneratorServices = null;
        private IWorldInteraction _worldInteraction = null;
        private IUniverseModel _universeModel = null;

        [SetUp]
        public void GameTest() {
            _worldGeneratorServices = new WorldGeneratorServices();
            _universeModel = _generator.GenerateUniverse();
            _worldInteraction = new WorldInteraction(_universeModel.PlanetModel[0]);
            _gameRunningInteractions = new GameRunningInteractions(_worldInteraction);
            _gameEngineInstance = new Game(_universeModel, _worldGeneratorServices, _gameRunningInteractions);
        }

        [Test]
        [TestCase(TestName = "Started new world")]
        public void RunGame() {
            //Arrange

            //Act
            _gameEngineInstance.StartGame();

            //Assert
            _gameEngineInstance.UpdateGame();
            Assert.IsNotNull(_universeModel.PlanetModel[0]);
            Assert.IsNotNull(_universeModel.PlanetModel[0]);
        }

        [Test]
        [TestCase(200, TestName = "Validate if the life forms are being created")]
        public void LifeFormInstances(int worldSize) {
            //Arrange

            //Act
            _gameEngineInstance.StartGame();
            _gameEngineInstance.UpdateGame();

            //Assert
        }
    }
}
