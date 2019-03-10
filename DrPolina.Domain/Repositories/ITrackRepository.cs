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
        Task<List<AlbumDto>> GetByArtist(Guid id);     //Поиск альбомов исполнителя
        Task<List<TrackDto>> GetTracksByAlbum(Guid id);    //Вывод трэков альбома
        Task<TrackDto> CreateAsync(TrackDto item);
        Task<bool> UpdateAsync(TrackDto item);
        Task<bool> DeleteAsync(Guid id);
    }
}
