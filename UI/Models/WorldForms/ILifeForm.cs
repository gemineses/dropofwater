using Models.Models.Brain;
using Models.WorldProperties;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.WorldForms
{
    /// <summary>
    /// Everything in the world is a form
    /// </summary>
    public interface ILifeForm: IMass, IMind
    {
        public string ID { get; set; }
    }
}
