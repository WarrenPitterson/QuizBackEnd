using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using QuizBackEnd.Common;
using QuizBackEnd.Data;
using QuizBackEnd.Interfaces;
using QuizBackEnd.Models;

namespace QuizBackEnd.Service
{
    public class UserService : IUserService
    {

        private readonly ApplicationContext _context;


        public UserService(ApplicationContext context)
        {
            _context = context;
        }


        public User Login(string userName, string password)
        {
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
                return null;

            var user = _context.User.SingleOrDefault(x => x.UserName == userName);
            var userValidation = Hash.Validate(password, user.Salt, user. Password);
         
            if (!userValidation) { return null; }

            return user;
        }

        public User Register(User user)
        {
            var passwordSalt = Salt.Create();
            var hashPassword = Hash.Create(user.Password, passwordSalt);

            user.Password = hashPassword;
            user.Salt = passwordSalt;
            

            return user;

        }

        public string CreateToken(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes("test key with a longer length");
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.NameIdentifier, user.UserId.ToString()),
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(ClaimTypes.Role, user.Permission.ToString()),
                }),
                Expires = DateTime.Now.AddMinutes(30),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha512Signature)
            };

            var token = tokenHandler.CreateToken((tokenDescriptor));
            var tokenString = tokenHandler.WriteToken(token);

            return tokenString;
        }
    }
}
