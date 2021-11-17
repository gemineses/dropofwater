using Models.WorldForms;
using System;
using System.Collections.Generic;
using System.Text;
using WorldTrigger.Interfaces;

namespace WorldTrigger.Actions
{
    public class Interaction : IInteraction
    {
        public ILifeForm emisor { get; set; }
        public ILifeForm receptor { get; set; }
        public Interaction(ILifeForm from, ILifeForm to) {
            emisor = from;
            receptor = to;
        }
    }
}
