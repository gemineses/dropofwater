using System;
using System.Collections.Generic;
using System.Text;

namespace Models.LifeFormModels.Brain
{
    public interface IMind
    {
        public List<Emotions> Emotion { get; set; }
        public List<ISenses> Senses { get; set; }
    }
}
