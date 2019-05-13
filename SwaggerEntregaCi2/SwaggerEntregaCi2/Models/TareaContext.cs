using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerEntregaCi2.Models
{
    public class TareaContext : DbContext
    {
        public TareaContext(DbContextOptions<TareaContext> options) : base(options)
        {
        }

        public DbSet<Tarea> tarea { get; set; }

    }
}
