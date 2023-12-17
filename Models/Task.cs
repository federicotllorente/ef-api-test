using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef_project.Models;

[Table("Task")]
public class Task {
  [Key]
  public Guid Id { get; set; }

  [ForeignKey("CategoryId")]
  public Guid CategoryId { get; set; }

  [Required]
  [MaxLength(150)]
  public string Title { get; set; }
  
  public string Description { get; set; }
  
  public Priority Priority { get; set; }
  
  public bool IsDone { get; set; }
  
  public DateTime CreatedAt { get; set; }
  
  public virtual Category Category { get; set; }

  public Task(Guid CategoryId, string Title, string Description) {
    this.CategoryId = CategoryId;
    this.Title = Title;
    this.Description = Description;
    this.Priority = Priority.Medium;
    this.Category = new("Category 1", "Some description");
  }
}

public enum Priority {
  Lowest = 4,
  Low = 3,
  Medium = 2,
  High = 1,
  Highest = 0
}
