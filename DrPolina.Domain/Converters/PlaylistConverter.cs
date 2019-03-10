using DrPolina.Domain.Dto;
using DrPolina.Domain.Entitties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DrPolina.Domain.Converters
{
    public static class PlaylistConverter
    {
        public static Playlist Convert(PlaylistDto playlist)
        {
            return new Playlist
            {
                Id = playlist.Id,
                Title = playlist.Title
            };
        }

        public static PlaylistDto Convert(Playlist playlist)
        {
            return new PlaylistDto
            {
                Id = playlist.Id,
                Title = playlist.Title
            };
        }

        public static List<Playlist> Convert(List<PlaylistDto> playlists)
        {
            return playlists.Select(a => Convert(a)).ToList();
        }

        public static List<PlaylistDto> Convert (List<Playlist> playlists)
        {
            return playlists.Select(a => Convert(a)).ToList();
        }
    }
}
