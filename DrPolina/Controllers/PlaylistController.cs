using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrPolina.API.Controllers
{
    public class PlaylistController: Controller
    {
        private readonly IPlaylistRepository _playRepo;

        public PlaylistController(IPlaylistRepository playRepo)
        {
            _playRepo = playRepo;
        }

        [HttpGet]
        public async Task<IActionREsult> Get()
        {
            try
            {
                return Ok(await _playRepo.GetAllAsync());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }


        [HttpGet("{id}")]   //Поиск по id
        public async Task<IActionResult> Get(Guid id)
        {
            try
            {
                return Ok(await _playRepo.GetByIdAsync(id));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPost]  //Создание нового
        public async Task<IActionResult> Post([FromBody] PlaylistDto item)
        {
            try
            {
                return Ok(await _playRepo.CreateAsync(item));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPut]   //Изменение
        public async Task<IActionResult> Put([FromBody] PlaylistDto item)
        {
            try
            {
                return Ok(await _playRepo.UpdateAsync(item));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpDelete("{id}")]    //удаление по id
        public async Task<IActionResult> Delte(Guid id)
        {
            try
            {
                return Ok(await _playRepo.DeleteAsync(id));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}
