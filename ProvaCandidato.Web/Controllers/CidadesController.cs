using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using ProvaCandidato.Data;


namespace ProvaCandidato.Web.Controllers
{
    public class CidadesController : Controller
    {


        // GET: Cidade
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetCidades()
        {

            return View();
        }
    }
}