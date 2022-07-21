using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class RetCarContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-7K06ESJ; database=ReCapProject; Trusted_Connection=true");
        }

        public DbSet<Car> Car{ get; set; }
        public DbSet<Brand> Brand{ get; set; }
        public DbSet<Color> Color{ get; set; }
    }
}
