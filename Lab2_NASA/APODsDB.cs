using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_NASA
{
    internal class APODsDB : DbContext
    {
        public DbSet<APOD> APODs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=C:\\Users\\luksok3413\\source\\repos\\xdCranx\\dotNet\\Lab2_NASA\\apods.db");
        }
    }
}
