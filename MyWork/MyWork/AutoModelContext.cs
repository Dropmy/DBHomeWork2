using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyWork
{
    public class AutoModelContext : DbContext
    {
        public DbSet<Auto> Autos { get; set; } = null!;
        public DbSet<Mark> Marks { get; set; } = null!;
        public DbSet<Engine> Engines { get; set; } = null!;
        public DbSet<Wheel> Wheels { get; set; } = null!;
        public DbSet<CarNumber> CarNum { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Привязка контекста к существующей бд
            optionsBuilder.UseMySql("Server=MYSQL8001.site4now.net;Database=db_a8e04e_user090;Uid=a8e04e_user090;Pwd=qwerty5656;",
            new MySqlServerVersion(new Version(5, 0)));
        }
    }
}
