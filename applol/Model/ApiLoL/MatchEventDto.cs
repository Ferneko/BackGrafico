using Api.Model.ApiLoL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Model.ApiLoL
{
    public class MatchEventDto
    {   /// <summary>
        /// string (Legal values: CHAMPION_KILL, WARD_PLACED, WARD_KILL, BUILDING_KILL, ELITE_MONSTER_KILL, ITEM_PURCHASED, ITEM_SOLD, ITEM_DESTROYED, ITEM_UNDO, SKILL_LEVEL_UP, ASCENDED_EVENT, CAPTURE_POINT, PORO_KING_SUMMON)
        /// </summary>
        public string type { get; set; }
        public string eventType { get; set; }
        public string towerType { get; set; }
        public int teamId { get; set; }
        public string ascendedType { get; set; }
        public int killerId { get; set; }
        public string levelUpType { get; set; }
        public string pointCaptured { get; set; }
        public List<int> assistingParticipantIds { get; set; }
        public string wardType { get; set; }
        public string monsterType { get; set; }
        public int skillSlot { get; set; }
        public int victimId { get; set; }
        public long timestamp { get; set; }
        public int afterId { get; set; }
        public string monsterSubType { get; set; }
        public string laneType { get; set; }
        public int itemId { get; set; }
        public int participantId { get; set; }
        public string buildingType { get; set; }
        public int creatorId { get; set; }
        public MatchPositionDto position { get; set; }
        public int beforeId { get; set; }
    }
}
