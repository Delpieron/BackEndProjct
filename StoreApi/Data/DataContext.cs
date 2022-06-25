using Microsoft.EntityFrameworkCore;

using StoreApi;

namespace StoreApi
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }
        public DbSet<User> user { get; set; }
    }
}
