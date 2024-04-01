using Microsoft.AspNetCore.Mvc;
using WebShopBackend.Database.Models;

namespace WebShopBackend.Application.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private List<Item> _items =
        [
            new Item()
            {
                CreatedBy = "Aleksi Partanen",
                Description = "A great mug",
                Name = "Mug",
                Price = 10.99,
                Quantity = 3,
            }
        ];

        [HttpGet("")]
        public ActionResult<List<Item>> GetItems() 
        {
            return _items;
        }

        [HttpPost("add")]
        public ActionResult<Item> AddItem(Item newItem)
        {
            _items.Add(newItem);
            return newItem;
        }
    }
}
