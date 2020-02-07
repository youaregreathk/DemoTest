using DemoTest.Core;
using DemoTest.Core.Models;
using DemoTest.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Numerics;

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
            /*
            List<User> result = new List<User>
            {
                new User{ Name = "Michael"},
                new User{ Name = "Alex"},
            };
            return result;
            */
            return null;
        }

        public User saveUser(string name, int score) {
            /*
            Guid guid = Guid.NewGuid();
            var tmp = new User { Name = name, Uid = guid, Score = score};
            return userData.Add(tmp);
            */
            return null;
        }

        public User getUserByUid(Guid uid) {
            var user = userData.GetByUid(uid);
            return user;
        }

        public User createADemoUser() {
            UserMetaDataModel model = new UserMetaDataModel {
                FirstName = "Hellen",
                LastName = "Brown",
                Dob = DateTime.Now,
                StreetAddressLine1 = "10811 AshtonAve",
                StreetAddressLine2 = "",
                State = "CA",
                ZipCode = "90424",
                Income = BigInteger.Parse("140000"),
                Occupation = "Engineer"
            };

            UserMetadata userMetadata = new UserMetadata
            {
                Uid = "304-497-354"
            };

            userMetadata.UserMetaDataModel = model;

            User user1 = new User 
            { 
                Uid = "304-497-354",
            };

            return userData.Add(user1, userMetadata);

        }

    }
}

