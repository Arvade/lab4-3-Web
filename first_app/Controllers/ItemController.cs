using System.Collections.Generic;
using System.Linq;
using first_app.Database;
using first_app.Entities;
using first_app.Models;
using Microsoft.AspNetCore.Mvc;

namespace first_app.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class ItemController : Controller {
        private readonly ExchangesDbContext dbContext;

        public ItemController(ExchangesDbContext dbContext) {
            this.dbContext = dbContext;
        }

        public IActionResult Index() {
            return View();
        }

        [HttpGet("api/get-all")]
        public List<ItemModel> GetItems() {
            return dbContext.Items.Select(item => (new ItemModel {
                Name = item.Name,
                Description = item.Description,
                IsVisible = item.IsVisible
            })).ToList();
        }


        [HttpPost("api/add")]
        public AddNewItemConfirmationViewModel Add(ItemModel item) {
            var entity = new ItemEntity {
                Name = item.Name,
                Description = item.Description,
                IsVisible = item.IsVisible,
            };

            dbContext.Items.Add(entity);
            dbContext.SaveChanges();

            var viewModel = new AddNewItemConfirmationViewModel {
                Id = 1,
                ItemName = item.Name
            };
            return viewModel;
        }
    }
}
