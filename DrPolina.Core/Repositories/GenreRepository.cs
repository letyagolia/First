using DrPolina.Core.EF;
using DrPolina.Domain.Converters;
using DrPolina.Domain.Dto;
using DrPolina.Domain.Entitties;
using DrPolina.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DrPolina.Core.Repositories
{
    public class GenreRepository: IGenreRepository
    {
        private readonly MusicContext _context;
        private readonly IGenreRepository _genreRepo;

        public GenreRepository(MusicContext context, IGenreRepository genreRepo)
        {
            _context = context;
            _genreRepo = genreRepo;
        }

        public async Task<List<GenreDto>> GetAllAsync()
        {
            return GenreConverter.Convert(await _context.Genres.ToListAsync());
        }

        public async Task<GenreDto> GetByIdAsync(Guid id)
        {
            var genre = GenreConverter.Convert(await _context.Genres.FindAsync(id));
            return genre;
        }

        public async Task<GenreDto> CreateAsync(GenreDto item)
        {
            var result = _context.Genres.Add(GenreConverter.Convert(item));
            await _context.SaveChangesAsync();
            return GenreConverter.Convert(result.Entity);
        }

        public async Task<bool> UpdateAsync(GenreDto item)
        {
            if (item == null)
                return false;
            _context.Genres.Update(GenreConverter.Convert(item));
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var genre = await _context.Genres.FindAsync(id);
            if (genre == null)
                return false;
            _context.Genres.Remove(genre);
            _context.SaveChanges();
            return true;

        }
    }
}
