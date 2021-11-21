using Models.Enums.Mind;
using Models.LifeFormModels;
using Models.WorldForms;
using System;
using System.Collections.Generic;
using System.Text;

namespace WorldTrigger.Actions
{
    public static class Interaction
    {
        /// <summary>
        /// Check if the receptor can feel what the emisor sends
        /// </summary>
        /// <returns></returns>
        public static void SentMessage(ILifeForm emisor, ILifeForm receptor, EnumSenses emisorSenseTypeSent)
        {
            var emisorMessage = EmisorSendingMessage(emisor, emisorSenseTypeSent);
            if (!string.IsNullOrEmpty(emisorMessage)) {
                ReceptorGettingMessage(receptor, emisorSenseTypeSent, emisorMessage);
            }
        }

        /// <summary>
        /// validating if the emisor can sent the message
        /// </summary>
        /// <param name="emisorSenseTypeSent"></param>
        /// <returns></returns>
        private static string EmisorSendingMessage(ILifeForm emisor, EnumSenses emisorSenseTypeSent) {
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
        private static void ReceptorGettingMessage(ILifeForm receptor, EnumSenses emisorSenseTypeSent, string emisorMessage) {
            var receptorSense = receptor.Senses.Find(sense => sense.Type == emisorSenseTypeSent);
            if (receptorSense != null) {
                receptorSense.Message = emisorMessage;
            }
        }
    }
}
