using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuizBackEnd.Models;

namespace QuizBackEnd.Interfaces
{
    public interface IUserService
    {

        User Login(string userName, string password);

    }
}
