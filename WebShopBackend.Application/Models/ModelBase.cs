namespace WebShopBackend.Application.Models
{
    public class ModelBase
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime ModifiedAt { get; set; }
        public string CreatedBy { get; set; } = null!;
    }
}
