using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuizBackEnd.Data;
using QuizBackEnd.Interfaces;
using QuizBackEnd.Models;
using QuizBackEnd.Service;

namespace QuizBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ApplicationContext _context;
        private readonly IUserService _userService;



        public UserController(ApplicationContext context, UserService userService)
        {
            _context = context;
            _userService = userService;
        }
        
        // GET: api/User
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUser()
        {
            return await _context.User.ToListAsync();
        }
        

        [HttpPost("login")]
        public IActionResult Authenticate([FromBody] User model)
        {

            var user = _userService.Login(model.UserName, model.Password);
            
            if (user == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            var tokenString = _userService.CreateToken(user);

            return Ok(new {tokenString});

        }



        // POST: api/User
        [HttpPost("register")]
        public async Task<ActionResult<User>> AddUser([FromBody]User user)
        {
            _userService.Register(user);

            if (UserExists(user.UserName))
            {
                return BadRequest(new {message = "User Already Exists"});
            }

            _context.User.Add(user);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUser", new { id = user.UserId }, user);
        }

        // DELETE: api/UsersController/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<User>> DeleteUser(int id)
        {
            var user = await _context.User.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.User.Remove(user);
            await _context.SaveChangesAsync();

            return user;
        }

        private bool UserExists(string username)
        {
            username = username.ToLower();
            return _context.User.Any(e => e.UserName == username);
        }

    }

}
