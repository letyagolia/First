using DrPolina.Domain.Dto;
using DrPolina.Domain.Entitties;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DrPolina.Domain.Repositories
{
    public interface IGenreRepository
    {
        Task<List<GenreDto>> GetAllAsync();
        Task<GenreDto> GetByIdAsync(Guid id);
        Task<GenreDto> CreateAsync(GenreDto item);
        Task<bool> UpdateAsync(GenreDto item);
        Task<bool> DeleteAsync(Guid id);
    }
}
