using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Model.ApiLoL
{
    public class ParticipantIdentityDto
    {
        /// <summary>
        /// PlayerDto   Player information.
        /// </summary>
        public PlayerDto player { get; set; }
        public int participantId { get; set; }
    }
}
