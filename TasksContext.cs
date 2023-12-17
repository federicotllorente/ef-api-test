using Microsoft.EntityFrameworkCore;
using ef_project.Models;
using Task = ef_project.Models.Task;

namespace ef_project;

public class TasksContext: DbContext {
  public DbSet<Category> Categories { get; set; }
  public DbSet<Task> Tasks { get; set; }
  
  public TasksContext(DbContextOptions<TasksContext> options) :base(options) {}

  protected override void OnModelCreating(ModelBuilder modelBuilder) {
    modelBuilder.Entity<Category>(category => {
      category.ToTable("Category");
      category.HasKey(p => p.Id);
      category.Property(p => p.Name).IsRequired().HasMaxLength(150);
      category.Property(p => p.Description);
    });

    modelBuilder.Entity<Task>(task => {
      task.ToTable("Task");
      task.HasKey(p => p.Id);
      task.HasOne(p => p.Category).WithMany(p => p.Tasks).HasForeignKey(p => p.CategoryId);
      task.Property(p => p.Title).IsRequired().HasMaxLength(150);
      task.Property(p => p.Description);
      task.Property(p => p.Priority);
      task.Property(p => p.IsDone);
      task.Property(p => p.CreatedAt);
    });
  }
}
