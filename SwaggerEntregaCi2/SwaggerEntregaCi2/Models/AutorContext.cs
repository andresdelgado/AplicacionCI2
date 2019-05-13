using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerEntregaCi2.Models
{
    public class AutorContext : DbContext
    {
        public AutorContext(DbContextOptions<AutorContext> options) : base(options)
        {
        }

        public DbSet<Autor> autor { get; set; }
    }
}
