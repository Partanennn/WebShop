using WebShopBackend.Application.Enums;

namespace WebShopBackend.Application.Models
{
    public class ItemType : ModelBase
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public int CategoryId { get; set; }
        public ItemTypeCategory Cateogry { get; set; }

    }
}
