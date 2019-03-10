using DrPolina.Domain.Entitties;
using System;
using System.Collections.Generic;
using System.Text;

namespace DrPolina.Domain.Dto
{
    public class PlaylistDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public List<TrackDto> tracks { get; set; } = new List<TrackDto>();
    }
}
