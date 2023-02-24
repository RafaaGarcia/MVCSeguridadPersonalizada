using Microsoft.AspNetCore.Mvc;

namespace MVCSeguridadPersonalizada.Controllers
using Microsoft.AspNetCore.Mvc;
using MvcSeguridadPersonalizada.Filters;
using MVCSeguridadPersonalizada.Filters;

namespace MvcSeguridadPersonalizada.Controllers
{
    public class UsuariosController : Controller
    {
        [AuthorizeUsers]
        public IActionResult Perfil()
        {
            return View();
        }
    }
}