using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrPolina.API.Controllers
{
    public class TrackController: Controller
    {
        private readonly ITrackRepository _repo;

        public TrackController(ITrackRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]   //Поиск
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok(await _repo.GetAllAsync());
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
                return Ok(await _repo.GetByIdAsync(id));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet("{id}")]   //поиск трэков по исполнителю
        public async Task<IActionResult> GetTracks(Guid id)
        {
            try
            {
                return Ok(await _repo.GetByArtist(id));
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet("{id}")]   //Поиск трэков по альбому
        public async Task<IActionResult> GetTrack(Guid id)
        {
            try
            {
                return Ok(await _repo.GetTracksByAlbum(id));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }


        [HttpPost]  //Создание нового
        public async Task<IActionResult> Post([FromBody] TrackDto item)
        {
            try
            {
                return Ok(await _repo.CreateAsync(item));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPut]   //Изменение старого
        public async Task<IActionResult> Put([FromBody] TrackDto item)
        {
            try
            {
                return Ok(await _repo.UpdateAsync(item));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpDelete("{id}")]    //Удаление 
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                return Ok(await _repo.DeleteAsync(id));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}

