using DrPolina.Domain.Dto;
using DrPolina.Domain.Entitties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DrPolina.Domain.Converters
{
    public static class AlbumConverter
    {
        public static Album Convert(AlbumDto album)
        {
            return new Album {
                Title = album.Title,
                Id = album.Id,
                ArtistId = album.ArtistId
            };

        }
        public static AlbumDto Convert(Album album)
        {
            return new AlbumDto
            {
                Title = album.Title,
                Id = album.Id,
                ArtistId = album.ArtistId
            };

        }
        public static List<Album> Convert(List<AlbumDto> albums)
        {
            return albums.Select(a => Convert(a)).ToList();
        }
        public static List<AlbumDto> Convert(List<Album> albums)
        {
            return albums.Select(a => Convert(a)).ToList();
        }
    }
}
