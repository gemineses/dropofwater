using Models.LifeFormModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Manager.Interfaces
{
    public interface IGameRunningInteractions
    {
        public void MoveEnvironment(List<ILifeForm> lifeForms);
    }
}
