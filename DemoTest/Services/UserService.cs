using DemoTest.Core;
using DemoTest.Data;
using System;
using System.Collections.Generic;


namespace DemoTest.Services
{
    public class UserService : IUserService
    {
        private readonly IUserData userData;

        public UserService(IUserData userData)
        {
            this.userData = userData;
        }

        public List<User> getAllFakeUsers()
        {
            List<User> result = new List<User>
            {
                new User{ Name = "Michael"},
                new User{ Name = "Alex"},
            };
            return result;
        }

        public User saveUser(string name, int score) {
            Guid guid = Guid.NewGuid();
            var tmp = new User { Name = name, Uid = guid, Score = score};
            return userData.Add(tmp);
            
        }

        public User getUserByUid(Guid uid) {
            var user = userData.GetByUid(uid);
            return user;
        }
    }
}
