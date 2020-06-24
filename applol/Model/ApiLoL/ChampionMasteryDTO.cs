using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Model.ApiLoL
{
    /// <summary>
    /// Classe responsável por trazer as informações dos campeões do invocador ordenado por maestria
    /// </summary>
    public class ChampionMasteryDTO
    {
        /// <summary>
        /// boolean Is chest granted for this champion or not in current season.
        /// </summary>
        public bool chestGranted { get; set; }
        /// <summary>
        /// int Champion level for specified player and champion combination.
        /// </summary>
        public int championLevel { get; set; }
        /// <summary>
        /// int Total number of champion points for this player and champion combination - they are used to determine championLevel.
        /// </summary>
        public int championPoints { get; set; }
        /// <summary>
        /// long Champion ID for this entry.
        /// </summary>
        public long championId { get; set; }
        /// <summary>
        /// long Number of points needed to achieve next level.Zero if player reached maximum champion level for this champion.
        /// </summary>
        public long championPointsUntilNextLevel { get; set; }

        /// <summary>
        /// long Last time this champion was played by this player - in Unix milliseconds time format.
        /// </summary>
        public long lastPlayTime { get; set; }
        /// <summary>
        /// int The token earned for this champion to levelup.
        /// </summary>
        public int tokensEarned { get; set; }
        /// <summary>
        /// long Number of points earned since current level has been achieved.
        /// </summary>
        public long championPointsSinceLastLevel { get; set; }
        /// <summary>
        /// string Summoner ID for this entry. (Encrypted)
        /// </summary>
        public string summonerId { get; set; }
    }
}
