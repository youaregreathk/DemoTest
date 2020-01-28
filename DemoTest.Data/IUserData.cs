using DemoTest.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoTest.Data
{
    public interface IUserData
    {
        IEnumerable<User> GetUserByName(string name);

        User GetByUid(Guid uid);

        User Update(User updatedUser);

        User Add(User user);

        User Delete(Guid uid);

        int Commit();
    }


}
