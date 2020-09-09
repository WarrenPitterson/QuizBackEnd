//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.EntityFrameworkCore;
//using NUnit.Framework;
//using NUnit.Framework.Internal;
//using QuizBackEnd.Common;
//using QuizBackEnd.Data;
//using QuizBackEnd.Interfaces;
//using QuizBackEnd.Models;
//using QuizBackEnd.Service;

//namespace QuizBackEnd.Tests
//{
//    [TestFixture]
//    public class UserTests
//    {
        
//        UserService _userService;
        

//        private ApplicationContext _context;
//        private readonly ApplicationContext context;

//        [SetUp]
//        public void Setup()
//        {
//            _context = context;
        
//        }


//        [Test]
//        public void Find_User_By_Id()
//        {
//            _userService = new UserService(_context);

//            var userId = 2;
//            var test = _userService.FindUserById(userId);


//            Assert.AreEqual(userId, test);


//        }

//    }
//}
