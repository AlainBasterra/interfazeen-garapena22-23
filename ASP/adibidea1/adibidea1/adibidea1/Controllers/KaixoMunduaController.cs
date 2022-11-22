using Microsoft.AspNetCore.Mvc;
using System.Web;

namespace adibidea1.Controllers
{
    public class KaixoMunduaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string OngiEtorri(string izena, int zenbat = 4)
        {
            return HttpUtility.HtmlEncode("Kaixo" + izena + ", zenbat da:" + zenbat);
        }
    }
}
