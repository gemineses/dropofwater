using Models.WorldForms;
using System;
using System.Collections.Generic;
using System.Text;

namespace Manager.Interfaces
{
    public interface IGame
    {
        void StartGame(PlanetModel planetModel);
        void UpdateGame();
    }
}
