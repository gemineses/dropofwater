using Models.Models;
using System;
using WorldTrigger.Actions;

namespace Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            var object1 = new Body();
            var object2 = new Body();
            Interaction interaction = new Interaction(object1, object2);
            var x = 1;
        }
    }
}
