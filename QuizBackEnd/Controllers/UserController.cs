using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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

            return Ok(new
            {
                Id = user.UserId,
                Username = user.UserName,
                Permission = user.Permission,
            });
        }

    }

}
