using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Model.ApiLoL
{
    public class SummonerDTO
    {
        /// <summary>
        /// ID of the summoner icon associated with the summoner.
        /// </summary>
        public int profileIconId { get; set; }

        /// <summary>
        /// Summoner name.
        /// </summary>
        public string name { get; set; }
        /// <summary>
        ///  Encrypted PUUID.Exact length of 78 characters.
        /// </summary>
        public string puuid { get; set; }
        /// <summary>
        /// Summoner level associated with the summoner.
        /// </summary>
        public long summonerLevel { get; set; }
        /// <summary>
        /// Date summoner was last modified specified as epoch milliseconds. The following events will update this timestamp: profile icon change, playing the tutorial or advanced tutorial, finishing a game, summoner name change
        /// </summary>
        public long revisionDate { get; set; }
        /// <summary>
        /// Encrypted summoner ID. Max length 63 characters.
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// Encrypted account ID. Max length 56 characters.
        /// </summary>
        public string accountId { get; set; }
    }
}
