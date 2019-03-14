using DrPolina.Core.EF;
using DrPolina.Domain.Converters;
using DrPolina.Domain.Dto;
using DrPolina.Domain.Entitties;
using DrPolina.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrPolina.Core.Repositories
{
    public class TrackRepository
    {
        private readonly MusicContext _context;
        private readonly IAlbumRepository _albumRepo;
        private readonly IArtistRepository _artistRepo;

        public TrackRepository (MusicContext context, IAlbumRepository albumRepo, IArtistRepository artistRepo)
        {
            _context = context;
            _albumRepo = albumRepo;
            _artistRepo = artistRepo;
        }

        public async Task<List<TrackDto>> GetAllAsync()
        {
            return TrackConverter.Convert(await _context.Tracks.ToListAsync());
        }

        public async Task<TrackDto> GetByIdAsync(Guid id)
        {
            var track = TrackConverter.Convert(await _context.Tracks.FindAsync(id));
            track.AlbumName = _albumRepo.GetByIdAsync(id).Result.Title;
            track.ArtistName = _artistRepo.GetByIdAsync(id).Result.Name;
            return track;
        }

        public async Task<List<TrackDto>> GetByArtist(Guid id)     //Поиск трэков по исполнителю
        {
            var artist = ArtistConverter.Convert(await _context.Artists.FindAsync(id));
            List<TrackDto> tracks = new List<TrackDto>();
            var track = TrackConverter.Convert(await _context.Tracks.FindAsync(id));
            tracks = TrackConverter.Convert(_context.Tracks.Where(x => x.ArtistId == artist.Id).ToList());
            return tracks;
        }

        public async Task<List<TrackDto>> GetTracksByAlbum(Guid id)    //Поиск трэков по альбому
        {
            var album = AlbumConverter.Convert(await _context.Albums.FindAsync(id));
            return album.Tracks;
        }


        public async Task<TrackDto> CreateAsync(TrackDto item)
        {
            var result = _context.Tracks.Add(TrackConverter.Convert(item));
            await _context.SaveChangesAsync();
            return TrackConverter.Convert(result.Entity);
        }

        public async Task<bool> UpdateAsync(TrackDto item)
        {
            if (item == null)
                return false;
            _context.Tracks.Update(TrackConverter.Convert(item));
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var track = await _context.Tracks.FindAsync(id);
            if (track == null)
                return false;
            _context.Tracks.Remove(track);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
