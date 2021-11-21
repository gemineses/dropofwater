using System;
using System.Collections.Generic;
using System.Text;
using Models.LifeFormModels.Brain;
using Models.LifeFormModels.Senses;
using Models.WorldForms;

namespace Models.LifeFormModels
{
    public class Body: ILifeForm
    {
        /// <summary>
        /// From  ID
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// Body Properties
        /// </summary>
        public int Latitude { get; set; }
        public int Longitude { get; set; }
        public int Rise { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int Temperature { get; set; }
        public int HardnessLevel { get; set; }
        public List<Emotions> Emotion { get; set; }
        public List<ISenses> Senses { get; set; }
    }
}
