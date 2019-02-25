using DrPolina.Domain.Dto;
using DrPolina.Domain.Entitties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DrPolina.Domain.Converters
{
    public static class ArtistConverter
    {
        public static Artist Convert (ArtistDto artist)
        {
            return new Artist
            {
                Name = artist.Name,
                Id = artist.Id
            };
        }

        public static ArtistDto Convert(Artist artist)
        {
            return new ArtistDto
            {
                Name = artist.Name,
                Id = artist.Id
            };
        }

        public static List<Artist> Convert(List<ArtistDto> artists)
        {
            return artists.Select(a => Convert(a)).ToList();
        }

        public static List<ArtistDto> Convert(List<Artist> artists)
        {
            return artists.Select(a => Convert(a)).ToList();
        }
    }
}
