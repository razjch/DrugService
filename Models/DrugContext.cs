using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrugsAPI.Models
{
    public class DrugContext : DbContext
    {
        public DrugContext(DbContextOptions<DrugContext> options) :base(options)
        {
            Database.EnsureCreated();
        }


        public DbSet<Drug> Drugs { get; set; }
    }

}
