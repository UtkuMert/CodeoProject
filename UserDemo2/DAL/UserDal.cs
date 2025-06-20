﻿using Microsoft.EntityFrameworkCore;
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

        public static ObservableCollection<User> GetAll()
        {
            using (UserDbContext db = new UserDbContext())
            {
                return new ObservableCollection<User>(db.Users.ToList());
            }
        }

        public static User GetUserByName(string username)
        {
            using (UserDbContext db = new UserDbContext())
            {
                return db.Users.FirstOrDefault(x => x.Name == username);
            }

        }
        public static User GetUserById(int id)
        {
            using (UserDbContext db = new UserDbContext())
            {
                return db.Users.FirstOrDefault(x => x.Id == id);
            }

        }


        public static void Add(User user)
        {
            using (UserDbContext db = new UserDbContext())
            {
                
                db.Users.AddAsync(user);
                db.SaveChangesAsync();  
            }
        }

        public static void Update(User user)
        {
            using (UserDbContext db = new UserDbContext())
            {
               
                var entity = db.Entry(user);
                entity.State = EntityState.Modified;
                db.SaveChangesAsync();
            }
        }

        public static void Delete(User user)
        {
            using (UserDbContext db = new UserDbContext())
            {
                var entity = db.Entry(user);
                entity.State = EntityState.Deleted;
                db.SaveChangesAsync();
            }
        }
    }
}
