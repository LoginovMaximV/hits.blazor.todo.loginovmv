using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TodoServerApp.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public virtual DbSet<TaskItem> TaskItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<TaskItem>().HasData([
                new TaskItem { Id = 1, Title = "������ 1", Description = "�������� 1", CreatedDate = DateTime.Now},
                new TaskItem { Id = 2, Title = "������ 2", Description = "�������� 2", CreatedDate = DateTime.Now},
                new TaskItem { Id = 3, Title = "������ 3", Description = "�������� 3", CreatedDate = DateTime.Now},
                new TaskItem { Id = 4, Title = "������ 4", Description = "�������� 4", CreatedDate = DateTime.Now},
                new TaskItem { Id = 5, Title = "������ 5", Description = "�������� 5", CreatedDate = DateTime.Now},
                new TaskItem { Id = 6, Title = "������ 6", Description = "�������� 6", CreatedDate = DateTime.Now},
                ]);
        }
    }
}
