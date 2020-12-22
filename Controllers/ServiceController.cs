using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WS_Cliente_MVC_Lizarraga.ServiceReference;
using System.Web.Mvc;

namespace WS_Cliente_MVC_Lizarraga.Controllers
{
    public class ServiceController : Controller
    {
        WebServiceSoapClient servicio = new WebServiceSoapClient();

        // GET: Service
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult HolaMundo()
        {
            ViewBag.HolaMundo = servicio.HolaMundo();
            return View();
        }

        public ActionResult AdiosMundo()
        {
            ViewBag.AdiosMundo = servicio.Adios();
            return View();
        }

        public ActionResult Suma(Double numero1, Double numero2)
        {
            ViewBag.Suma = servicio.Sumar(numero1, numero2);
            return View();
        }

        public ActionResult Tabla(Double numero)
        {
            ViewBag.Tabla = servicio.Tabla(numero);
            return View();
        }

        public ActionResult Bisiesto(int fechainicial, int fechafinal)
        {
            ViewBag.Bisiesto = servicio.Bisiestos(fechainicial, fechafinal);
            return View();
        }

        public ActionResult Tipo(Double numero1, Double numero2)
        {
            int tipo = Convert.ToInt32(Request.Form["Tipo"]);
            ViewBag.Operaciones = servicio.Operaciones(tipo, numero1, numero2);
            return View();
        }
    }
}