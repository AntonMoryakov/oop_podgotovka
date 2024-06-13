using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace exzoop10
{
    public class KeyValue
    {
        public int Id { get; set; }
        public string  Name { get; set; }
    }

    public class MyDbContext : DbContext
    {
        public DbSet<KeyValue> KeyValues { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ACERPASHA\\MSSQLSERVER1;Database=exzoopDatabase10;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new MyDbContext())
            {
                var item = new KeyValue { Name = "Pavel" };
                db.KeyValues.Add(item);
                db.SaveChanges();
            }
        }
    }
}
