using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ControleEstoque.Web.Controllers
{
    public class CadastroController : Controller
    {
        [Authorize]
        public IActionResult GrupoProduto()
        {
            return View();
        }
        [Authorize]
        public IActionResult MarcaProduto()
        {
            return View();
        }
        [Authorize]
        public IActionResult LocalProduto()
        {
            return View();
        }
        [Authorize]
        public IActionResult UnidadeMedida()
        {
            return View();
        }
        [Authorize]
        public IActionResult Produto()
        {
            return View();
        }
        [Authorize]
        public IActionResult Pais()
        {
            return View();
        }
        [Authorize]
        public IActionResult Estado()
        {
            return View();
        }
        [Authorize]
        public IActionResult Cidade()
        {
            return View();
        }
        [Authorize]
        public IActionResult Fornecedor()
        {
            return View();
        }
        [Authorize]
        public IActionResult PerfilUsuario()
        {
            return View();
        }
        [Authorize]
        public IActionResult Usuario()
        {
            return View();
        }

    }
}
