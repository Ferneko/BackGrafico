using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Model.ApiLoL
{
    public class MatchDto
    {
        /// <summary>
        /// Please refer to the Game Constants documentation.
        /// </summary>
        public int seasonId { get; set; }
        /// <summary>
        ///  int Please refer to the Game Constants documentation.
        /// </summary>
        public int queueId { get; set; }

        public long gameId { get; set; }
        /// <summary>
        ///  List[] Participant identity information.
        /// </summary>
        public List<ParticipantIdentityDto> participantIdentities { get; set; }

        /// <summary>
        /// The major.minor version typically indicates the patch the match was played on.
        /// </summary>
        public string gameVersion { get; set; }
        /// <summary>
        /// Platform where the match was played.
        /// </summary>
        public string platformId { get; set; }
        /// <summary>
        /// Please refer to the Game Constants documentation.
        /// </summary>
        public string gameMode { get; set; }

        /// <summary>
        /// int Please refer to the Game Constants documentation.
        /// </summary>
        public int mapId { get; set; }

        /// <summary>
        /// string Please refer to the Game Constants documentation.
        /// </summary>
        public string gameType { get; set; }
        /// <summary>
        /// List[]  Team information.
        /// </summary>
        public List<TeamStatsDto> teams { get; set; }
        /// <summary>
        /// Participant information.
        /// </summary>
        public List<ParticipantDto> participants { get; set; }
        /// <summary>
        ///  long Match duration in seconds.
        /// </summary>
        public long gameDuration { get; set; }
        /// <summary>
        /// long Designates the timestamp when champion select ended and the loading screen appeared, NOT when the game timer was at 0:00.
        /// </summary>
        public long gameCreation { get; set; }
    }
}
