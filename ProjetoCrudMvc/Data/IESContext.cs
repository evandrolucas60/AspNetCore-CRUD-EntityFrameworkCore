using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoCrudMvc.Models;

namespace ProjetoCrudMvc.Data
{
    public class IESContext : DbContext
    {
        public IESContext(DbContextOptions options) : base(options)
        {
        }

        
        public DbSet<Institution> institutions { get; set; }
    }
}
