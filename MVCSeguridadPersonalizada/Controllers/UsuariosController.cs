﻿using Microsoft.AspNetCore.Mvc;

namespace MVCSeguridadPersonalizada.Controllers
{
    public class UsuariosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
