using System;
using System.Collections.Generic;
using System.Text;

namespace DrPolina.Domain.Entitties
{
    public class Track
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Guid AlbumId { get; set; }
        public Guid ArtistId { get; set; }
    }
}
