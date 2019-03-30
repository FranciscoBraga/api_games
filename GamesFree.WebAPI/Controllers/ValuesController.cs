using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GamesFree.WebAPI.Data;
using GamesFree.WebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GamesFree.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        private readonly DataContext _dataContext;
        public ValuesController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
           try{
                var result =  await _dataContext.Games.ToListAsync();
                return Ok(result); 
           }catch(System.Exception){
               return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao acessar banco");
               
           }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try{
                var result = _dataContext.Games.FirstOrDefaultAsync(x => x.GameId == id);
                return Ok(result);
            }catch(System.Exception){
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao acessar banco");
            }
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
