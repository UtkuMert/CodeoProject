using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDemo.DAL
{
    public class UserDal
    {
        public List<User> GetAll()
        {
            using(UserDbContext db = new UserDbContext())
            {
                return db.Users.ToList();
            }
        } 


        public void Add(User user)
        {
            using (UserDbContext db = new UserDbContext())
            {
                db.Add(user);
                db.SaveChanges();
            }
        }
    }
}
