using builders_Project.Models;
using license.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace DataLayer.Models
{
    internal class Context:DbContext
	{
        
       
         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
            if (!optionsBuilder.IsConfigured)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

                optionsBuilder.UseSqlServer(connectionString);

                base.OnConfiguring(optionsBuilder);
            }
        }

        public DbSet<Place>? places { get; set; }  
        public DbSet<clsssification>? clsssifications { get; set; }
        public DbSet<User>? users { get; set; }
        public DbSet<FileDocument>? files { get; set; }
    }
}
