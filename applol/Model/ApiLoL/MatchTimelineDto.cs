using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Model.ApiLoL
{
    public class MatchTimelineDto
    {
        public List<MatchFrameDto> frames { get; set; }
        public long frameInterval { get; set; }
    }
}
