using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    
    public class DataContext : DbContext
    { 
        //constructeur instance la class, ce contructeur a un parametre qui nous permettra de configurer la base donnée
        public DataContext(DbContextOptions options) : base(options)
        {  

        }

        public DbSet<AppUser> Users { get; set; }
    }
}