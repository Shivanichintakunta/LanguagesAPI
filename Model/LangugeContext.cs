using Microsoft.EntityFrameworkCore;
namespace Languages_Types.Model
{
    public class LangugeContext:DbContext
    {
        public LangugeContext() { }
        public LangugeContext(DbContextOptions<LangugeContext> options):base(options) { }
        static string connection= @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Languages_DB;Integrated Security=True";
        public DbSet<Language> Languages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connection);
        }
    }
}
