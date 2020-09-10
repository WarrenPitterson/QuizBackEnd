using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using QuizBackEnd.Common;
using NUnit;
using NUnit.Framework;

namespace QuizBackEnd.Tests
{
    [TestFixture]
    public class HashTests
    {
        [Test]
        public void Untampered_hash_matches_the_text()
        {
            //Arrange
            var message = "passw0rd";
            var salt = Salt.Create();
            var hash = Hash.Create(message, salt);

            //Act
            var match = Hash.Validate(message, salt, hash);

            //Assert
            Assert.True(match);
        }

        [Test]
        public void Tampered_hash_does_not_match_the_text()
        {
            // Arrange  
            var message = "passw0rd";
            var salt = Salt.Create();
            var hash = "blahblahblah";

            // Act  
            var match = Hash.Validate(message, salt, hash);

            // Assert  
            Assert.False(match);
        }

        [Test]
        public void Hash_of_two_different_messages_does_not_match()
        {
            // Arrange  
            var message1 = "passw0rd";
            var message2 = "password";
            var salt = Salt.Create();

            // Act  
            var hash1 = Hash.Create(message1, salt);
            var hash2 = Hash.Create(message2, salt);

            // Assert  
            Assert.AreNotEqual(hash1, hash2);
        }

        [Test]
        public void Hash_of_same_messages_does_not_match()
        {
            // Arrange  
            var message1 = "password";
            var message2 = "password";
            var salt = Salt.Create();

            // Act  
            var hash1 = Hash.Create(message1, salt);
            var hash2 = Hash.Create(message2, salt);

            // Assert  
            Assert.AreEqual(hash1, hash2);
        }

        [Test]
        public void login_test()
        {
            //Arrange
            var message = "1234567";
            var salt = "whhRBnRlMEz6gl95lzqzQw==";
            var hash = Hash.Create(message, salt);

            //Act
            var match = Hash.Validate(message, salt, hash);

            //Assert
            Assert.True(match);
        }
    }
}



