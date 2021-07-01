using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AkijFood.Models
{
    public class AkijFoodContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.\sqlexpress;Initial Catalog=dbAkijFood;Integrated Security=True");    
        }
        public DbSet<tblColdDrink> tblColdDrink { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblColdDrink>().HasData(
                new tblColdDrink { intColdDrinksId = 1, strColdDrinksName = "Clemon", numQuantity = 450, numUnitPrice = 20 },
                new tblColdDrink { intColdDrinksId = 2, strColdDrinksName = "Frutika", numQuantity = 500, numUnitPrice = 25 },
                new tblColdDrink { intColdDrinksId = 3, strColdDrinksName = "Speed", numQuantity = 600, numUnitPrice = 30 }
            );
        }
    }
}
