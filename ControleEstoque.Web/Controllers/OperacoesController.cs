using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ControleEstoque.Web.Controllers
{
    public class OperacoesController : Controller
    {
        [Authorize]
        public IActionResult EntradaEstoque()
        {
            return View();
        }
        [Authorize]
        public IActionResult SaidaEstoque()
        {
            return View();
        }
        [Authorize]
        public IActionResult LancPerdaProduto()
        {
            return View();
        }
        [Authorize]
        public IActionResult Inventario()
        {
            return View();
        }

    }
}
