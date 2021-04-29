using Microsoft.EntityFrameworkCore;

namespace Api
{
    public class SettingsStoreContext : DbContext
    {
        public SettingsStoreContext()
        {
        }

        public SettingsStoreContext(DbContextOptions options) : base(options)
        {
        }
        
        public DbSet<settings> Settings { get; set; }
    }
}