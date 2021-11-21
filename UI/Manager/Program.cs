using Models.Enums.Mind;
using Models.LifeFormModels;
using Models.LifeFormModels.Brain;
using Models.LifeFormModels.Senses;
using Models.WorldForms;
using System;
using System.Collections.Generic;
using WorldTrigger.Actions;

namespace Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            var object1 = new Body() { 
                Senses = new List<ISenses>() { 
                    new Touch(){ 
                        Message = "touch"
                    }
                }
            };
            var object2 = new Body() { 
                Senses = new List<ISenses>() { 
                    new Touch()
                }
            };
            Interaction.SentMessage(object1, object2, EnumSenses.touch);
            var x = 1;
        }
    }
}
