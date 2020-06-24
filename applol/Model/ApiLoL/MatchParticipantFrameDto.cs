using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Model.ApiLoL
{
    public class MatchParticipantFrameDto
    {
        public int totalGold { get; set; }
        public int teamScore { get; set; }
        public int participantId { get; set; }
        public int level { get; set; }
        public int currentGold { get; set; }
        public int minionsKilled { get; set; }
        public int dominionScore { get; set; }
        public int xp { get; set; }
        public int jungleMinionsKilled { get; set; }
        public MatchPositionDto position { get; set; }

    }
}
