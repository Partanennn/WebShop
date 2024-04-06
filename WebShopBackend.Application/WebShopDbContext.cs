using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebShopBackend.Application.Models;

namespace WebShopBackend.Application
{
    public class WebShopDbContext : IdentityDbContext<User>
    {
        public WebShopDbContext(DbContextOptions<WebShopDbContext> options) : base(options) {}

        public DbSet<Item> Items { get; set; }
        public DbSet<ItemType> ItemTypes { get; set; }
    }
}
