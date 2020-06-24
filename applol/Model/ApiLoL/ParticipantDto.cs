using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Model.ApiLoL
{
    public class ParticipantDto
    {
        /// <summary>
        ///  Participant statistics.
        /// </summary>
        public ParticipantStatsDto stats { get; set; }
        public int participantId { get; set; }
        /// <summary>
        /// List[RuneDto] List of legacy Rune information. Not included for matches played with Runes Reforged.
        /// </summary>
        public List<RuneDto> runes { get; set; }
        /// <summary>
        /// Participant timeline data.
        /// </summary>
        public ParticipantTimelineDto timeline { get; set; }
        /// <summary>
        /// int 100 for blue side. 200 for red side.
        /// </summary>
        public int teamId { get; set; }
        /// <summary>
        /// int Second Summoner Spell id.
        /// </summary>
        public int spell2Id { get; set; }
        /// <summary>
        /// List[MasteryDto]    List of legacy Mastery information.Not included for matches played with Runes Reforged.
        /// </summary>
        public List<MasteryDto> masteries { get; set; }
        /// <summary>
        /// string Highest ranked tier achieved for the previous season in a specific subset of queueIds, if any, otherwise null. Used to display border in game loading screen.Please refer to the Ranked Info documentation. (Legal values: CHALLENGER, MASTER, DIAMOND, PLATINUM, GOLD, SILVER, BRONZE, UNRANKED)
        /// </summary>
        public string highestAchievedSeasonTier { get; set; }
        /// <summary>
        /// int First Summoner Spell id.
        /// </summary>
        public int spell1Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int championId { get; set; }
    }
}
