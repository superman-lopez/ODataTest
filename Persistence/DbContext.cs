using Microsoft.EntityFrameworkCore;
using ODataTest.Core;

namespace ODataTest.Persistence
{
    public class ODataContext : DbContext
    {
		public ODataContext(DbContextOptions<ODataContext> options) : base(options) {}

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			modelBuilder.Seed();
		}
    }

}