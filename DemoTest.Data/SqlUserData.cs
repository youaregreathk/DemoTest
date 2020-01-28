using DemoTest.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace DemoTest.Data
{
    public class SqlUserData : IUserData
    {
        private readonly DemoTestDbContext db;

        public SqlUserData(DemoTestDbContext db) {
            this.db = db;
        }

        public User Add(User newUser)
        {
            db.Add(newUser);
            return newUser;
        }

        public int Commit()
        {
            return db.SaveChanges();
        }

        public User Delete(Guid uid)
        {
            var user = GetByUid(uid);
            if (user != null) {
                db.Users.Remove(user);
            }
            return user;
        }

        public User GetByUid(Guid uid)
        {
            try
            {
                return db.Users.Find(uid);
            }
            catch (Exception e) {
                return new User { Name = "Error" };
            }
        }

        public IEnumerable<User> GetUserByName(string name)
        {
            var query = from r in db.Users
                        where r.Name.StartsWith(name) || string.IsNullOrEmpty(name)
                        orderby r.Name
                        select r;
            return query;
                
        }

        public User Update(User updatedUser)
        {
            var entity = db.Users.Attach(updatedUser);
            entity.State = EntityState.Modified;
            return updatedUser;
        }
    }
}
