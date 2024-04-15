using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ControleEstoque.Web.Controllers
{
    public class GraficosController : Controller
    {
        [Authorize]
        public IActionResult PerdaMes()
        {
            return View();
        }
        [Authorize]
        public IActionResult EntradaSaidaMensal()
        {
            return View();
        }
    }
}
