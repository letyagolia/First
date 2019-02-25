using DrPolina.Domain.Dto;
using DrPolina.Domain.Entitties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DrPolina.Domain.Converters
{
    public static class TrackConverter
    {
        public static Track Convert(TrackDto track)
        {
            return new Track
            {
                Id = track.Id,
                Title = track.Title,
                AlbumId = track.AlbumId,
                ArtistId = track.ArtistId
            };
        }

        public static TrackDto Convert (Track track)
        {
            return new TrackDto
            {
                Id = track.Id,
                Title = track.Title,
                AlbumId = track.AlbumId,
                ArtistId = track.ArtistId
            };
        }

        public static List<Track> Convert(List<TrackDto> tracks)
        {
            return tracks.Select(a => Convert(a)).ToList();
        }

        public static List<TrackDto> Convert (List<Track> tracks)
        {
            return tracks.Select(a => Convert(a)).ToList();
        }
    }
}
