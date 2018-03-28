using CmsAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CmsAPI.Data
{
    public class UCmsApiContext : DbContext
    {
        public UCmsApiContext(DbContextOptions<UCmsApiContext> opts) : base(opts)
        {

        }

        public DbSet<Page> Pages { get; set; }
        public DbSet<SideBar> SideBar { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
