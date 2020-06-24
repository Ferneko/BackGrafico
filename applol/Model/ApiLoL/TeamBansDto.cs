using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Model.ApiLoL
{
    public class TeamBansDto
    {
        /// <summary>
        /// int Turn during which the champion was banned.
        /// </summary>
        public int pickTurn { get; set; }
        /// <summary>
        /// int Banned championId.
        /// </summary>
        public int championId { get; set; }
    }
}
