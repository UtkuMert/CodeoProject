using EntityFrameworkCore.EncryptColumn.Extension;
using EntityFrameworkCore.EncryptColumn.Interfaces;
using EntityFrameworkCore.EncryptColumn.Util;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDemo2.DAL
{
    public class UserDbContext : DbContext
    {
        private readonly IEncryptionProvider _provider;

        public UserDbContext()
            :base()
        {
            this._provider = new GenerateEncryptionProvider("example_encrypt_key");
        }
        public DbSet<User> Users { get; set; }
       

        public string path = @"D:\AutoCase Database.db";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite($"Data Source={path}");

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.UseEncryption(this._provider);
        //    base.OnModelCreating(modelBuilder);
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            EncryptionConvertor.Apply(modelBuilder, "b14ca5898a4e4133bbce2ea2315a1916");

        }
    }
}
