using Microsoft.AspNetCore.Mvc;

namespace first_app.Controllers {
    public class ExchangesController : Controller {
        // GET
        public IActionResult Index() {
            return View();
        }
    }
}