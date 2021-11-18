using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Models.Brain
{
    public interface IMind
    {
        public List<Emotions> Emotion { get; set; }
        public List<ISenses> Senses { get; set; }
    }
}
