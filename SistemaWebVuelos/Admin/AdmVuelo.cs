using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;
using SistemaWebVuelos.Models;
using SistemaWebVuelos.Data;

namespace SistemaWebVuelos.Admin
{
    static public class AdmVuelo
    {
        static DbVueloContext context = new DbVueloContext();

        public static List<Vuelo> Listar()
        {
            return context.Vuelos.ToList();
        }

        public static void Insertar(Vuelo vuelo)
        {
            context.Vuelos.Add(vuelo);
            context.SaveChanges();
        }

        public static Vuelo TraerPorID(int id)
        {
            Vuelo vuelo = context.Vuelos.Find(id);
            context.Entry(vuelo).State = EntityState.Detached;
            return vuelo;
        }

        public static void Eliminar(Vuelo vuelo)
        {
            if (!context.Vuelos.Local.Contains(vuelo))
            {
                context.Vuelos.Attach(vuelo);
                context.Vuelos.Remove(vuelo);
                context.SaveChanges();
            }
        }

        public static List<Vuelo> ListarDestino(string destino)
        {
            var vuelos = (from v in context.Vuelos
                            where v.Destino == destino
                            select v).ToList();
            return vuelos;
        }

        public static void Editar(Vuelo vuelo)
        {
            context.Vuelos.Attach(vuelo);
            context.Entry(vuelo).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}