namespace ef_project.Models;

public class Category {
  public Guid Id { get; set; }

  private string _Name;

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
