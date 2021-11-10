using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using SistemaWebVuelos.Models;
using SistemaWebVuelos.Admin;
using System.Data.Entity;
using SistemaWebVuelos.Filters;

namespace SistemaWebVuelos.Controllers
{
    [MyFilter]
    public class VueloController : Controller
    {
        // GET: Vuelo
        public ActionResult Index(string destino)
        {
            int des = String.IsNullOrEmpty(destino) ? 0 : 1;
            switch (des)
            {
                case 0:
                    return View(AdmVuelo.Listar());
                case 1:
                    return View(AdmVuelo.ListarDestino(destino));
                default:
                    return View();
            }
        }

        public ActionResult Create()
        {
            Vuelo vuelo = new Vuelo();
            return View("Create", vuelo);
        }

        [HttpPost]
        public ActionResult Create(Vuelo vuelo)
        {
            if (ModelState.IsValid)
            {
                AdmVuelo.Insertar(vuelo);
                return RedirectToAction("Index");
            }
            return View("Create", vuelo);

        }

        public ActionResult Details(int id)
        {
            Vuelo vuelo = AdmVuelo.TraerPorID(id);
            if (vuelo != null)
            {
                return View("Details", vuelo);
            }
            else
            {
                return HttpNotFound();

            }
        }

        public ActionResult Delete(int id)
        {
            Vuelo vuelo = AdmVuelo.TraerPorID(id);
            if (vuelo != null)
            {
                return View("Delete", vuelo);
            }
            else
            {
                return HttpNotFound();
            }
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Vuelo vuelo = AdmVuelo.TraerPorID(id);
            AdmVuelo.Eliminar(vuelo);
            return RedirectToAction("Index");
        }

        public ActionResult DetailByDestination(string destino)
        {
            if (destino == "Todas")
            {
                return RedirectToAction("Index");
            }
            return View("Index", AdmVuelo.ListarDestino(destino));
        }

        public ActionResult Edit(int id)
        {
            Vuelo vuelo = AdmVuelo.TraerPorID(id);
            if (vuelo != null)
            {
                return View("Edit");
            }
            else
            {
                return HttpNotFound();
            }
        }

        [HttpPost]
        public ActionResult Edit(Vuelo vuelo)
        {
            AdmVuelo.Editar(vuelo);
            return RedirectToAction("Index");
        }
    }
}