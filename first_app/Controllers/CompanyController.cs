using first_app.Models;
using first_app.Models.Company;
using Microsoft.AspNetCore.Mvc;

namespace first_app.Controllers {
    public class CompanyController : Controller {
        public IActionResult Index() {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CompanyModel company) {
            var viewModel = new CompanyAddedViewModel {
                NumberOfCharsInName = company.Name.Length,
                NumberOfCharsInDescription = company.Description.Length,
                IsHidden = !company.IsVisible
            };

            return View("CompanyAdded", viewModel);
        }
    }
}