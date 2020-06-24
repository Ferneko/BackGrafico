using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Model.ApiLoL
{
    public class PlayerDto
    {
        public string currentPlatformId { get; set; }
        public string summonerName { get; set; }
        public string matchHistoryUri { get; set; }
        /// <summary>
        /// string Original platformId.
        /// </summary>
        public string platformId { get; set; }
        /// <summary>
        /// string Player's current accountId (Encrypted)
        /// </summary>
        public string currentAccountId { get; set; }
        public string profileIcon { get; set; }
        /// <summary>
        /// string Player's summonerId (Encrypted)
        /// </summary>
        public string summonerId { get; set; }
        /// <summary>
        /// string Player's original accountId (Encrypted)
        /// </summary>
        public string accountId { get; set; }
    }
}
