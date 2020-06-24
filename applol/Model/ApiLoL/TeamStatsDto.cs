using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Model.ApiLoL
{
    public class TeamStatsDto
    {
        /// <summary>
        /// boolean Flag indicating whether or not the team scored the first Dragon kill.
        /// </summary>
        public bool firstDragon { get; set; }
        /// <summary>
        ///  boolean Flag indicating whether or not the team destroyed the first inhibitor.
        /// </summary>
        public bool firstInhibitor { get; set; }
        /// <summary>
        /// List[TeamBansDto]   If match queueId has a draft, contains banned champion data, otherwise empty.
        /// </summary>
        public List<TeamBansDto> bans { get; set; }
        /// <summary>
        /// int Number of times the team killed Baron.
        /// </summary>
        public int baronKills { get; set; }
        /// <summary>
        /// boolean Flag indicating whether or not the team scored the first Rift Herald kill.
        /// </summary>
        public bool firstRiftHerald { get; set; }
        /// <summary>
        /// boolean Flag indicating whether or not the team scored the first Baron kill.
        /// </summary>
        public bool firstBaron { get; set; }
        /// <summary>
        /// int Number of times the team killed Rift Herald.
        /// </summary>
        public int riftHeraldKills { get; set; }
        /// <summary>
        /// boolean Flag indicating whether or not the team scored the first blood.
        /// </summary>
        public bool firstBlood { get; set; }
        /// <summary>
        /// int 100 for blue side. 200 for red side.
        /// </summary>
        public int teamId { get; set; }
        /// <summary>
        /// boolean Flag indicating whether or not the team destroyed the first tower.
        /// </summary>
        public bool firstTower { get; set; }
        /// <summary>
        /// int Number of times the team killed Vilemaw.
        /// </summary>
        public int vilemawKills { get; set; }
        /// <summary>
        /// int Number of inhibitors the team destroyed.
        /// </summary>
        public int inhibitorKills { get; set; }
        /// <summary>
        /// int Number of towers the team destroyed.
        /// </summary>
        public int towerKills { get; set; }
        /// <summary>
        /// int For Dominion matches, specifies the points the team had at game end.
        /// </summary>
        public int dominionVictoryScore { get; set; }
        /// <summary>
        /// string String indicating whether or not the team won.There are only two values visibile in public match history. (Legal values: Fail, Win)
        /// </summary>
        public string win { get; set; }
        /// <summary>
        /// int Number of times the team killed Dragon.
        /// </summary>
        public int dragonKills { get; set; }
    }
}
