using Microsoft.EntityFrameworkCore;
using PubApi.Data.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubApi.Data.Contexto
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base()
        {

        }
        public DbSet<Cliente> MyProperty { get; set; }
    }
}
