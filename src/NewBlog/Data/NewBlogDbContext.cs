using Microsoft.EntityFrameworkCore;
using NewBlog.Entities;

namespace NewBlog.Data;

public class NewBlogDbContext : DbContext
{
    public NewBlogDbContext(DbContextOptions<NewBlogDbContext> options) : base(options)
    {
    }

    public DbSet<Post> Posts { get; set; }

    public DbSet<User> Users { get; set; }
}
