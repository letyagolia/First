using DrPolina.Core.EF;
using DrPolina.Domain.Converters;
using DrPolina.Domain.Dto;
using DrPolina.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DrPolina.Core.Repositories
{
    public class PlaylistRepository
    {
        private readonly MusicContext _context;
        private readonly IPlaylistRepository _playRepo;

        public PlaylistRepository(MusicContext context, IPlaylistRepository playRepo)
        {
            _context = context;
            _playRepo = playRepo;
        }

        public async Task<List<PlaylistDto>> GetAllAsync()
        {
            return PlaylistConverter.Convert(await _context.Playlists.ToListAsync());
        }

        public async Task<PlaylistDto> GetByIdAsync(Guid id)
        {
            var playlist = PlaylistConverter.Convert(await _context.Playlists.FindAsync(id));
            return playlist;
        }

        public async Task<PlaylistDto> CreateAsync(PlaylistDto item)
        {
            var result = _context.Playlists.Add(PlaylistConverter.Convert(item));
            await _context.SaveChangesAsync();
            return PlaylistConverter.Convert(result.Entity);
        }

        public async Task<bool> UpdateAsync(PlaylistDto item)
        {
            if (item == null)
                return false;
            _context.Playlists.Update(PlaylistConverter.Convert(item));
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var playlist = await _context.Playlists.FindAsync(id);
            if (playlist == null)
                return false;
            _context.Playlists.Remove(playlist);
            _context.SaveChanges();
            return true;
        }
    }
}
