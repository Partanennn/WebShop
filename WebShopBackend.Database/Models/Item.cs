namespace WebShopBackend.Database.Models
{
    public class Item : ModelBase
    {
        public string Name { get; set; } = null!;
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string? Description { get; set; }
    }
}
