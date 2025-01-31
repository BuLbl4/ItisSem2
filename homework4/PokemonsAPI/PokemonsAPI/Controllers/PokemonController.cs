using Microsoft.AspNetCore.Mvc;
using PokemonAPI.Core.Entity;
using PokemonAPI.Core.Inrerfaces;
using PokemonAPI.Core.Models;


namespace PokemonsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private readonly IPokeService _pokeService;
        private readonly ILogger<PokemonController> _logger;
    
        public PokemonController(IPokeService pokeApiService, ILogger<PokemonController> logger)
        {
            _pokeService = pokeApiService;
            _logger = logger;
        }
        
        /// <summary>
        /// Получить покемона по Id
        /// </summary>
        /// <param name="id">ID покемона</param>
        /// <returns>Покемона по Id</returns>
        
        [HttpGet("ById/{id}")]
        public Task<Pokemon> GetPokemonById([FromRoute]Guid id)
        {
            return _pokeService.GetById(id);
        }
        
        
        /// <summary>
        /// Получить покемона по имени
        /// </summary>
        /// <param name="name">Имя покемона</param>
        /// <returns>Покемон по имени</returns>
        [HttpGet("ByName/{name}")]
        public async Task<PokemonFullInfo> GetPokemonByName([FromRoute]string name)
        {
            return await _pokeService.GetByName(name);
        }
        
        
        /// <summary>
        /// Фильтрация покемонов по стрингу
        /// </summary>
        /// <param name="name">часть или полное имя покемона</param>
        /// <returns>Отфильтрованный список покемонов</returns>
        [HttpGet("Filter/{name}")]
        public async Task<List<PokemonWithTypesResponse>> GetByFilter([FromRoute] string name, CancellationToken cancellationToken)
        {
           var filteredPokemons = await _pokeService.Filter(name, cancellationToken);
           return filteredPokemons;
        }

        [HttpGet("[action]")]
        public async Task<List<Types>> GetType()
        {
            return await _pokeService.GetTypes();
        }
        
        
        /// <summary>
        /// Получить несколько покемонов 
        /// </summary>
        /// <param name="offset">кол-во покемонов</param>
        /// <returns>Список Покемонов</returns>
        
        [HttpGet("Pagination")]
        public async Task<List<PokemonWithTypesResponse>> Pagination([FromQuery]int offset, int limit)
        {
            return await _pokeService.ForPaginashion(offset, limit);
        }
        
        /// <summary>
        /// Получить всех покемонов
        /// </summary>
        /// <returns>массив покемонов</returns>
        [HttpGet("[action]")]
        public Task<List<Pokemon>> GetAllPokemons()
        {
            return _pokeService.GetAllPokemons();
        }
        
        
    }
}
