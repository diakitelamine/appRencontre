using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
     [ApiController]
     [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
    
        private readonly DataContext _context;
         //Contructeur 
        public UsersController (DataContext context){
            _context = context;
           
        }
        
        // Recuperation des utilisateursb avec une methode asynchrone
        [HttpGet]
        public  async  Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            var users =await  _context.Users.ToListAsync();

            return users;
        }
        // Trouver un utilisateur 
        [HttpGet("{id}")]
        public async Task<ActionResult <AppUser>> GetUser(int id){

          return await _context.Users.FindAsync(id);

        }
    }
}