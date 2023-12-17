using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef_project.Models;

[Table("Category")]
public class Category {
  [Key]
  public Guid Id { get; set; }

  private string _Name;

  [Required]
  [MaxLength(150)]
  public string Name {
    get {
      return _Name;
    }
    set {
      _Name = value.Trim();
    }
  }

  public string Description { get; set; }

  public virtual ICollection<Task> Tasks { get; set; }

  public Category(string Name, string Description) {
    this.Name = Name;
    this.Description = Description;
  }
}
