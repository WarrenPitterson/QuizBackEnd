using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

            // check if username exists
            if (user == null)
                return null;

            // check if password is correct
            if (password != user.Password)
                return null;

            // authentication successful
            return user;
        }
    }
}
