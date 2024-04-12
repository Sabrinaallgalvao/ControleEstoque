using Microsoft.AspNetCore.Mvc;

namespace ControleEstoque.Web.Controllers
{
    public class GraficosController : Controller
    {
        public IActionResult PerdaMes()
        {
            return View();
        }

        public IActionResult EntradaSaidaMensal()
        {
            return View();
        }
    }
}
