using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace NetIdentity.Controllers
{
    public class JuegosController : Controller
    {
        [Authorize(Policy = "menoresEdad")]
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Policy = "menoresEdad")]
        [Authorize(Policy = "SoloMasculino")]
        public IActionResult JuegoEducativo()
        {
            return View();
        }

        [Authorize(Policy = "menoresEdad")]
        [Authorize(Policy = "SoloFemenino")]
        public IActionResult Aventuras()
        {
            return View();
        }
    }
}
