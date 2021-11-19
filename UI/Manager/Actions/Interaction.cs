using Models.Enums.Mind;
using Models.Models.Brain;
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
        public int Distance { get; set; }

        public Interaction(ILifeForm from, ILifeForm to) {
            emisor = from;
            receptor = to;
            
        }

        /// <summary>
        /// Check if the receptor can feel what the emisor sends
        /// </summary>
        /// <returns></returns>
        public void SentMessage(EnumSenses emisorSenseTypeSent)
        {
            var emisorMessage = EmisorSendingMessage(emisorSenseTypeSent);
            if (!string.IsNullOrEmpty(emisorMessage)) {
                ReceptorGettingMessage(emisorSenseTypeSent, emisorMessage);
            }
        }

        /// <summary>
        /// validating if the emisor can sent the message
        /// </summary>
        /// <param name="emisorSenseTypeSent"></param>
        /// <returns></returns>
        private string EmisorSendingMessage(EnumSenses emisorSenseTypeSent) {
            var emisorSense = emisor.Senses.Find(sense => sense.Type == emisorSenseTypeSent);
            if (emisorSense == null) {
                return string.Empty;
            }
            return emisorSense.Message;
        }

        /// <summary>
        /// validating if the receptor can catch the message
        /// </summary>
        /// <param name="emisorSenseTypeSent"></param>
        /// <returns></returns>
        private void ReceptorGettingMessage(EnumSenses emisorSenseTypeSent, string emisorMessage) {
            var receptorSense = receptor.Senses.Find(sense => sense.Type == emisorSenseTypeSent);
            if (receptorSense != null) {
                receptorSense.Message = emisorMessage;
            }
        }
    }
}
