using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuizBackEnd.Common;
using QuizBackEnd.Data;
using QuizBackEnd.Interfaces;
using QuizBackEnd.Models;
using QuizBackEnd.Tests;

namespace QuizBackEnd.Service
{
    public class UserService : IUserService
    {

        private readonly ApplicationContext _context;


        public UserService(ApplicationContext context)
        {
            _context = context;
        }

        public User FindUserById(int id)
        {
            var user = _context.User.SingleOrDefault(x => x.UserId == id);

            return user;
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

       
    }
}
