using System;
using System.Collections.Generic;
using System.Text;

namespace DrPolina.Domain.Entitties
{
    public class Album
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Guid ArtistId { get; set; }
        public List<Track> Tracks { get; set; } = new List<Track>();
    }
}
