﻿using System;
using System.Collections.Generic;
using System.Text;
using Models.Models.Brain;
using Models.Models.Senses;

namespace Models.Models
{
    public class Body
    {
        /// <summary>
        /// Average of adding right and left side of the emotions
        /// </summary>
        public Emotions Brain { get; set; }
        /// <summary>
        /// Body Properties
        /// </summary>
        public Matter BodyType { get; set; }
        public Touch TouchReceptor { get; set; }
        

    }
}
