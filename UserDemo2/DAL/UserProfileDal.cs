using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDemo2.DAL
{
    class UserProfileDal
    {
        public static ObservableCollection<UserProfile> GetAll()
        {
            using (UserDbContext db = new UserDbContext())
            {
                return new ObservableCollection<UserProfile>(db.UserProfiles.ToList());
            }
        }

        public static UserProfile GetUserProfileByName(string name)
        {
            using (UserDbContext db = new UserDbContext())
            {
                return db.UserProfiles.FirstOrDefault(x => x.RoleName == name);
            }
        }

        public static UserProfile GetUserProfileById(int id)
        {
            using (UserDbContext db = new UserDbContext())
            {
                return db.UserProfiles.FirstOrDefault(x => x.Id == id);
            }
        }


        public static void Add(UserProfile userProfile)
        {
            using (UserDbContext db = new UserDbContext())
            {

                db.UserProfiles.AddAsync(userProfile);
                db.SaveChangesAsync();
            }
        }

        public static void Update(UserProfile userProfile)
        {
            using (UserDbContext db = new UserDbContext())
            {

                var entity = db.Entry(userProfile);
                entity.State = EntityState.Modified;
                db.SaveChangesAsync();
            }
        }

        public static void Delete(UserProfile userProfile)
        {
            using (UserDbContext db = new UserDbContext())
            {
                var entity = db.Entry(userProfile);
                entity.State = EntityState.Deleted;
                db.SaveChangesAsync();
            }
        }
    }
}
