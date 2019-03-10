using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrPolina.API.Controllers
{
    public class GenreController: Controller
    {
        private readonly IGenreRepository _genRepo;

        public GenreController (IGenreRepository genRepo)
        {
            _genRepo = genRepo;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok(await _genRepo.GetAllAsync());
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet("{id}")]   //Поиск по id
        public async Task<IActionResult> Get(Guid id)
        {
            try
            {
                return Ok(await _genRepo.GetByIdAsync(id));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPost]  //Создание нового
        public async Task<IActionResult> Post([FromBody] GenreDto item)
        {
            try
            {
                return Ok(await _genRepo.CreateAsync(item));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPut]   //Изменение
        public async Task<IActionResult> Put([FromBody] GenreDto item)
        {
            try
            {
                return Ok(await _genRepo.UpdateAsync(item));
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
                return Ok(await _genRepo.DeleteAsync(id));
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}
