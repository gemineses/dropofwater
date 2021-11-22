using Models.Enums.Mind;
using Models.LifeFormModels;
using Models.LifeFormModels.Brain;
using Models.WorldForms;
using System;
using System.Collections.Generic;
using System.Text;
using WorldTrigger.Interfaces;

namespace WorldTrigger.Actions
{
    public class WorldInteraction: IWorldInteraction
    {
        private IPlanetModel _planet = null;
        public WorldInteraction(IPlanetModel planet) {
            _planet = planet;
        }

        public void ExploreEnvironment(ILifeForm lifeForm)
        {
            var notValidMessage = "";
            var emotions = new List<Emotions>();
            if (EmisorSendingMessage(lifeForm, EnumSenses.touch) != notValidMessage) {
                emotions.Add(new Emotions()
                {
                    Level = 1,
                    Type = EnumPrimitiveEmotions.joy
                });
            }
            if (EmisorSendingMessage(lifeForm, EnumSenses.sounds) != notValidMessage)
            {
                emotions.Add(new Emotions()
                {
                    Level = 1,
                    Type = EnumPrimitiveEmotions.joy
                });
            }
            if (EmisorSendingMessage(lifeForm, EnumSenses.sight) != notValidMessage)
            {
                emotions.Add(new Emotions()
                {
                    Level = 1,
                    Type = EnumPrimitiveEmotions.joy
                });
            }
            if (EmisorSendingMessage(lifeForm, EnumSenses.smell) != notValidMessage)
            {
                emotions.Add(new Emotions()
                {
                    Level = 1,
                    Type = EnumPrimitiveEmotions.joy
                });
            }
            if (EmisorSendingMessage(lifeForm, EnumSenses.taste) != notValidMessage)
            {
                emotions.Add(new Emotions()
                {
                    Level = 1,
                    Type = EnumPrimitiveEmotions.joy
                });
            }

            lifeForm.Emotion = emotions;
        }

        public void ApplyPhysicsToLifeForms(ILifeForm lifeForm)
        {
            ReturnLifeFormToPlanet(lifeForm);
        }

        /// <summary>
        /// Return the life form to the map if this get outside
        /// </summary>
        /// <param name="lifeForm"></param>
        private void ReturnLifeFormToPlanet(ILifeForm lifeForm) {
            lifeForm.Latitude = (lifeForm.Latitude < 0 || lifeForm.Latitude > _planet.worldSize) ?
                _planet.worldSize / 2 : lifeForm.Latitude;

            lifeForm.Longitude = (lifeForm.Longitude < 0 || lifeForm.Longitude > _planet.worldSize) ?
                _planet.worldSize / 2 : lifeForm.Longitude;

            //For now all the life forms has to be set at ground level
            lifeForm.Rise = 1;
        }

        /// <summary>
        /// Check if the receptor can feel what the emisor sends
        /// </summary>
        /// <returns></returns>
        public void SentMessage(ILifeForm emisor, ILifeForm receptor, EnumSenses emisorSenseTypeSent)
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
        private string EmisorSendingMessage(ILifeForm emisor, EnumSenses emisorSenseTypeSent) {
            if (emisor.Senses == null) throw new Exception("All life forms has to had at least one sense");
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
        private void ReceptorGettingMessage(ILifeForm receptor, EnumSenses emisorSenseTypeSent, string emisorMessage) {
            var receptorSense = receptor.Senses.Find(sense => sense.Type == emisorSenseTypeSent);
            if (receptorSense != null) {
                receptorSense.Message = emisorMessage;
            }
        }
    }
}
