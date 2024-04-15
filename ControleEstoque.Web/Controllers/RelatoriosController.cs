using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ControleEstoque.Web.Controllers
{
    public class RelatoriosController : Controller
    {
        [Authorize]
        public IActionResult PosicaoEstoque()
        {
            return View();
        }
        [Authorize]
        public IActionResult ReabastecimentoEstoque()
        {
            return View();
        }
    }
}
