using Microsoft.VisualBasic;
using Models.Enums.Mind;
using Models.LifeFormModels;
using Models.LifeFormModels.Brain;
using Models.LifeFormModels.Senses;
using System;
using System.Collections.Generic;
using WorldTrigger.Actions;

namespace Manager
{
    class Program
    {
        public static void Main(string[] args)
        {
            var object1 = new Body()
            {
                Senses = new List<ISenses>() {
                    new Touch(){
                        Message = "touch"
                    }
                }
            };
            var object2 = new Body()
            {
                Senses = new List<ISenses>() {
                    new Touch()
                }
            };
            var interaction = new WorldInteraction();
            interaction.SentMessage(object1, object2, EnumSenses.touch);
        }
    }
}
