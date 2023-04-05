using Microsoft.AspNetCore.Mvc;

namespace angular_dotnet_crud.Controllers
{
    public class ItemsController : Controller
    {
        public IActionResult Index() {
            return View();
        }
    }
}
