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

        public User Add(User newUser, UserMetadata userMetadata)
        {
            newUser.UserMetadata = userMetadata;
            
            db.Add(newUser);
            Commit();
            return newUser;
        }

        public int Commit()
        {
            return db.SaveChanges();
        }

        public User Delete(Guid uid)
        {
            /*
            var user = GetByUid(uid);
            if (user != null) {
                db.user.Remove(user);
            }
           
            return user;
            */
            return null;
        }

        public User GetByUid(Guid uid)
        {
            /*
            try
            {
                return db.user.Find(uid);
            }
            catch (Exception e) {
                return new User { Name = "Error" };
            }
            */
            return null;
        }

        public IEnumerable<User> GetUserByName(string name)
        {
            /*
             var query = from r in db.user
                         where r.Name.StartsWith(name) || string.IsNullOrEmpty(name)
                         orderby r.Name
                         select r;
             return query;
             */
            return null;    
        }

        public User Update(User updatedUser)
        {
            /*
            var entity = db.user.Attach(updatedUser);
            entity.State = EntityState.Modified;
            return updatedUser;
            */
            return null;
        }
    }
}
