using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Model.ApiLoL
{
    public class ParticipantTimelineDto
    {
        public string lane { get; set; }                //string Participant's calculated lane. MID and BOT are legacy values. (Legal values: MID, MIDDLE, TOP, JUNGLE, BOT, BOTTOM)
        public int participantId { get; set; }
        public object csDiffPerMinDeltas { get; set; }//[String, double] Creep score difference versus the calculated lane opponent(s) for a specified period.
        public object goldPerMinDeltas { get; set; }//[String, double] Gold for a specified period.
        public object xpDiffPerMinDeltas { get; set; }//[String, double] Experience difference versus the calculated lane opponent(s) for a specified period.
        public object creepsPerMinDeltas { get; set; }//[String, double] Creeps for a specified period.
        public object xpPerMinDeltas { get; set; }       //Map [String, double] Experience change for a specified period.
        public string role { get; set; }                //Participant's calculated role. (Legal values: DUO, NONE, SOLO, DUO_CARRY, DUO_SUPPORT)
        public object damageTakenDiffPerMinDeltas { get; set; } // Damage taken difference versus the calculated lane opponent(s) for a specified period.
        public object damageTakenPerMinDeltas { get; set; } //Map [String, double] Damage taken for a specified period.
    }
}
