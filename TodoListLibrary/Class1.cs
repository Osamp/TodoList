using System.ComponentModel.DataAnnotations;
namespace TodoListLibrary;

public class TodoItem
{ 
    [Key]
    public Guid Id { get; set; }

    public DateTime? DueDate { get; set; }

    public DateTime? CompleteDate { get; set; }
    
    public string Description { get; set; }
};
