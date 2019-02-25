using DrPolina.Domain.Dto;
using DrPolina.Domain.Entitties;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DrPolina.Domain.Repositories
{
    public interface ITrackRepository
    {
        Task<List<Track>> GetAllAsync();
        Task<TrackDto> GetByIdAsync(Guid id);
        Task<TrackDto> CreateAsync(TrackDto item);
        Task<bool> UpdateAsync(TrackDto item);
        Task<bool> DeleteAsync(Guid id);
    }
}
