using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;
using SistemaWebVuelos.Models;

namespace SistemaWebVuelos.Data
{
    public class DbVueloInitializer : DropCreateDatabaseAlways<DbVueloContext>
    {
        protected override void Seed(DbVueloContext context)
        {
            var vuelos = new List<Vuelo> 
            { new Vuelo
            {
                dateTime= Convert.ToDateTime("12/05/2022"),
                Destino = "Londres",
                Origen="Buenos Aires",
                Matricula = 256
            }
                };
            vuelos.ForEach(i => context.Vuelos.Add(i));
            context.SaveChanges();
        }
    }
}