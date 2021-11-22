using Manager.Interfaces;
using Models.LifeFormModels;
using System;
using System.Collections.Generic;
using System.Text;
using WorldTrigger.Interfaces;

namespace Manager.World
{
    public class GameRunningInteractions : IGameRunningInteractions
    {
        private IWorldInteraction _worldInteraction;
        public GameRunningInteractions(IWorldInteraction worldInteraction) {
            _worldInteraction = worldInteraction;
        }

        public void MoveEnvironment(List<ILifeForm> lifeForms)
        {
            lifeForms.ForEach(lifeForm =>
            {
                _worldInteraction.ApplyPhysicsToLifeForms(lifeForm);
                _worldInteraction.ExploreEnvironment(lifeForm);
            });
        }
    }
}
