using System;
using System.Collections.Generic;
using DemoTest.Models;

namespace DemoTest.Services
{
    public class UserService : IUserService
    {
        public UserService()
        {
        }

        public List<User> getAllUsers()
        {
            List<User> result = new List<User>
            {
                new User{ Name = "Michael", Uid = "304497834"},
                new User{ Name = "Alex", Uid = "304493834"},
            };
            return result;
        }
    }
}
