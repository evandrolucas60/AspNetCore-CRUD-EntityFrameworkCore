using Microsoft.EntityFrameworkCore;
using ProjetoCrudMvc.Models;

namespace ProjetoCrudMvc.Data
{
    public class IESContext : DbContext
    {
        public IESContext(DbContextOptions options) : base(options)
        {
        }

        
        public DbSet<Department> Departments { get; set; }
        public DbSet<Institution> Institutions { get; set; }
    }
}
