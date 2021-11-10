using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;
using SistemaWebVuelos.Models;

namespace SistemaWebVuelos.Data
{
    public class DbVueloContext:DbContext
    {
        public DbVueloContext() : base("KeyDB") { }
        public DbSet<Vuelo> Vuelos { get; set; }
    }
}