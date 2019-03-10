using System;
using System.Collections.Generic;
using System.Text;

namespace DrPolina.Domain.Entitties
{
    public class Playlist
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public List<Track> tracks { get; set; } = new List<Track>();
    }
}
