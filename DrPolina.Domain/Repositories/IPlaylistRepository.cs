using DrPolina.Domain.Dto;
using DrPolina.Domain.Entitties;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DrPolina.Domain.Repositories
{
    public interface IPlaylistRepository
    {
        Task<List<Playlist>> GetALlAsync();
        Task<PlaylistDto> GetByIdAsync(Guid id);
        Task<PlaylistDto> CreateAsync(PlaylistDto item);
        Task<bool> UpdateAsync(PlaylistDto item);
        Task<bool> DeleteAsync(Guid id);
    }
}
