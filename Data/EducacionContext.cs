#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Educacion.Models;

namespace Educacion.Data
{
    public class EducacionContext : DbContext
    {
        public EducacionContext (DbContextOptions<EducacionContext> options)
            : base(options)
        {
        }

        public DbSet<Educacion.Models.Estudiante> Estudiante { get; set; }
    }
}
