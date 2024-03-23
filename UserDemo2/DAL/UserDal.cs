using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace UserDemo2.DAL
{
    public static class UserDal
    {
        //public static List<User> GetAll()
        //{
        //    using (UserDbContext db = new UserDbContext())
        //    {
        //        return db.Users.ToList();
        //    }
        //}

        public static ObservableCollection<User> GetAll()
        {
            using (UserDbContext db = new UserDbContext())
            {
                return new ObservableCollection<User>(db.Users.ToList());
            }
        }


        public static void Add(User user)
        {
            using (UserDbContext db = new UserDbContext())
            {
                
                db.Add(user);
                db.SaveChanges();
            }
        }

        public static void Update(User user)
        {
            using (UserDbContext db = new UserDbContext())
            {
               
                var entity = db.Entry(user);
                entity.State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public static void Delete(User user)
        {
            using (UserDbContext db = new UserDbContext())
            {
                var entity = db.Entry(user);
                entity.State = EntityState.Deleted;
                db.SaveChanges();
            }
        }
    }
}
