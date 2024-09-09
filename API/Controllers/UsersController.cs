using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController(DataContext dataContext) : ControllerBase
    {
        // [HttpGet]
        // public ActionResult<IEnumerable<AppUser>> GetUsers(){
        //     var users = dataContext.Users.ToList();
        //     return Ok(users);
        // }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers(){
            var users = await dataContext.Users.ToListAsync();
            return Ok(users);
        }



        // [HttpGet("{id:int}")]
        // public ActionResult<AppUser> GetUser( int id){
        //     var user = dataContext.Users.Find(id);

        //     if(user == null) return NotFound();

        //     return Ok(user);
        // }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<AppUser>> GetUser( int id){
            var user = await dataContext.Users.FindAsync(id);

            if(user == null) return NotFound();

            return Ok(user);
        }
    }
}
