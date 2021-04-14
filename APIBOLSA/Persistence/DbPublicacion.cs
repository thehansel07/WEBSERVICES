using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence
{
    public class DbPublicacion:DbContext
    {
        public DbSet<Publicacion> Publicacion { get; set; }

        public DbPublicacion(DbContextOptions<DbPublicacion> options)
            : base(options)
        {
        }

        public DbSet<Publicacion> Publicaciones{ get; set; }
    }
}

