using Microsoft.AspNetCore.Mvc;

namespace ControleEstoque.Web.Controllers
{
    public class RelatoriosController : Controller
    {
        public IActionResult PosicaoEstoque()
        {
            return View();
        }

        public IActionResult ReabastecimentoEstoque()
        {
            return View();
        }
    }
}
