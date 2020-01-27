using System;
using System.Collections.Generic;
using DemoTest.Models;

namespace DemoTest.Services
{
    public interface IUserService
    {
        List<User> getAllUsers();
    }
}
