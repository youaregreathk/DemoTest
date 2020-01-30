using DemoTest.Core;
using System;
using System.Collections.Generic;


namespace DemoTest.Services
{
    public interface IUserService
    {
        List<User> getAllFakeUsers();

        User saveUser(string name, int score);

        User getUserByUid(Guid uid);

    }
}
