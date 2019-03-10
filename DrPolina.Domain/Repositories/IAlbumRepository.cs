using DrPolina.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DrPolina.Domain.Repositories
{
    public interface IAlbumRepository // работа с бд
    {
        Task<List<AlbumDto>> GetAllAsync();
        Task<AlbumDto> GetByIdAsync(Guid id);
        Task<AlbumDto> CreateAsync(AlbumDto item);
        Task<bool> UpdateAsync(AlbumDto item);
        Task<bool> DeleteAsync(Guid id);
        Task<List<AlbumDto>> GetAlbumsByArtist(Guid id); //Поиск альбома по артисту
        
    }
}
