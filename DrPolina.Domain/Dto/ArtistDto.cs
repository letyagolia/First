using DrPolina.Domain.Entitties;
using System;
using System.Collections.Generic;
using System.Text;

namespace DrPolina.Domain.Dto
{
    public class ArtistDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<AlbumDto> Albums { get; set; } = new List<AlbumDto>(); 
    }
}
