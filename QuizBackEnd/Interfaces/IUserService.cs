using QuizBackEnd.Models;

namespace QuizBackEnd.Interfaces
{
    public interface IUserService
    {

        User Login(string userName, string password);
        User Register(User user);

        string CreateToken(User user);
    }
}
