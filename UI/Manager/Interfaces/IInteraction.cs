using System;
using System.Collections.Generic;
using System.Text;
using Models.Enums.Mind;
using Models.Models.Brain;
using Models.WorldForms;

namespace WorldTrigger.Interfaces
{
    public interface IInteraction
    {
        ILifeForm emisor { get; set; }
        ILifeForm receptor { get; set; }
        void SentMessage(EnumSenses emisorSenseTypeSent);
        int Distance { get; set; }
    }
}
