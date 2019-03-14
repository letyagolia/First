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
        Task<List<TrackDto>> GetAllAsync();
        Task<TrackDto> GetByIdAsync(Guid id);
        Task<List<TrackDto>> GetByArtist(Guid id);     //Поиск трэков по исполнителю
        Task<List<TrackDto>> GetTracksByAlbum(Guid id);    //Поиск по альбому
        Task<TrackDto> CreateAsync(TrackDto item);
        Task<bool> UpdateAsync(TrackDto item);
        Task<bool> DeleteAsync(Guid id);
    }
}
