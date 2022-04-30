using System;
using Microsoft.EntityFrameworkCore;

namespace satis_db.models
{
    public class SatisDbContext : DbContext
    {
        public SatisDbContext(DbContextOptions<SatisDbContext> options)
            : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Comment> Comments { get; set; }
    }
}
