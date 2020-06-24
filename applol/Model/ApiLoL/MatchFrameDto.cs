using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Model.ApiLoL
{
    public class MatchFrameDto
    {
        public long timestamp { get; set; }
        public Dictionary<string, MatchParticipantFrameDto> participantFrames { get; set; }
        public List<MatchEventDto> events  { get; set;}
    }
}
