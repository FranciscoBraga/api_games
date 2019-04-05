using System.Threading.Tasks;
using GamesFree.Domain;
using GamesFree.Repositoy.repositoryClass;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GamesFree.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesControllers: ControllerBase
    {
        private readonly IGameRepository _iGame;

        public GamesControllers(IGameRepository  iGame)
        {
            _iGame = iGame;
        }

        [HttpGet]
        public IActionResult FindAll(){
            try{
                var result = _iGame.FindAll();
                return Ok(result);
            }catch(System.Exception){
                return StatusCode(StatusCodes.Status500InternalServerError,"Error a buscar por games");
            }

           
        }

        [HttpPut("{id}")]
        public IActionResult FindByConditions(int id){
            try{
                var result = _iGame.FindByConditions(g => g.GameId == id);
                return Ok(result);
            }catch(System.Exception){
            
                return StatusCode(StatusCodes.Status500InternalServerError,"Error a buscar por games");
            }
        }

        //criando um game
        [HttpPost]
        public async Task<IActionResult> Create(Game game){
            try{
                 _iGame.Create(game);
                 var result = await _iGame.SaveAsync();
                 return Ok(result);

            }catch(System.Exception){
                return StatusCode(StatusCodes.Status500InternalServerError,"Error a Criar Game");
            }

            
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Game game, int id){
            try{
                var gameSeachrs =  _iGame.FindByConditions(x => x.GameId ==id);
                if(gameSeachrs == null) return NotFound();
                _iGame.Update(game);
                var result =  await _iGame.SaveAsync();
                return Ok(result);
            }catch(System.Exception){
                return StatusCode(StatusCodes.Status500InternalServerError,"Error ao Atualizar");
            }
        }

        [HttpDelete]
        public IActionResult Delete(Game game){
            try{
                _iGame.Delete(game);
                var result = _iGame.SaveAsync();
                return Ok(result);

            }catch(System.Exception){
                return StatusCode(StatusCodes.Status500InternalServerError,"Error ao deletar");
            }
        }   

   
    }
}