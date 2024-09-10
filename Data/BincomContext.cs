using Ebele;
using Microsoft.EntityFrameworkCore;

namespace Bincom_MVC_App.Data
{
    public class BincomContext : DbContext
    {
        public BincomContext(DbContextOptions<BincomContext> options)
            : base(options)
        {
        }

        public DbSet<Property> Properties { get; set; }
    }
}
