using System;
using System.Collections.Generic;
using System.Text;
using Models.WorldForms;

namespace WorldTrigger.Interfaces
{
    public interface IInteraction
    {
        ILifeForm emisor { get; set; }
        ILifeForm receptor { get; set; }

    }
}
