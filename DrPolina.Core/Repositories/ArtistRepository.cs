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
    public class ArtistRepository: IArtistRepository
    {
        private readonly MusicContext _context;

        public ArtistRepository(MusicContext context)
        {
            _context = context;
        }

        public async Task<List<ArtistDto>> GetAllAsync()
        {
            return ArtistConverter.Convert(await _context.Artists.ToListAsync());
        }

        public async Task<ArtistDto> GetByIdAsync (Guid id)
        {
            return ArtistConverter.Convert(await _context.Artists.FindAsync(id));
        }

        public async Task<ArtistDto> CreateAsync(ArtistDto item)
        {
            var result = _context.Artists.Add(ArtistConverter.Convert(item));
            await _context.SaveChangesAsync();
            return ArtistConverter.Convert(result.Entity);
        }

        public async Task<bool> UpdateAsync(ArtistDto item)
        {
            if (item == null)
                return false;
            _context.Artists.Update(ArtistConverter.Convert(item));
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var artist = await _context.Artists.FindAsync(id);
            if (artist == null)
                return false;
            _context.Artists.Remove(artist);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
