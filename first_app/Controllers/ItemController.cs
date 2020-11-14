using System;
using first_app.Models;
using Microsoft.AspNetCore.Mvc;

namespace first_app.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class ItemController : Controller {
        public IActionResult Index() {
            return View();
        }

        [HttpPost("api/add")]
        public AddNewItemConfirmationViewModel Add(ItemModel item) {
            // TODO: Add to database

            var viewModel = new AddNewItemConfirmationViewModel {
                Id = 1,
                ItemName = item.Name
            };
            Console.Write("Attempt to add item : " + item);

            return viewModel;
        }
    }
}
