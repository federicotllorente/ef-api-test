using Microsoft.EntityFrameworkCore;
using ef_project.Models;

namespace ef_project;

public class TasksContext: DbContext {
  public DbSet<Category> Categories { get; set; }
  public DbSet<Models.Task> Tasks { get; set; }
  
  public TasksContext(DbContextOptions<TasksContext> options) :base(options) {}
}
