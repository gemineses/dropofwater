using Models.Enums.Mind;
using Models.LifeFormModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace WorldTrigger.Interfaces
{
    public interface IWorldInteraction
    {
        public void SentMessage(ILifeForm emisor, ILifeForm receptor, EnumSenses emisorSenseTypeSent);
    }
}
