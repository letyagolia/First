using System;
using System.Collections.Generic;
using System.Text;

namespace DrPolina.Domain.Dto
{
    public class TrackDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Guid AlbumId { get; set; }
        public string AlbumName { get; set; }
        public Guid ArtistId { get; set; }
        public string ArtistName { get; set; }
    }
}
