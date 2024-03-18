using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDemo.DAL
{
    public class UserDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public string path = @"D:\AutoCase Database.db";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
            => optionsBuilder.UseSqlite($"Data Source={path}");

    }
}
