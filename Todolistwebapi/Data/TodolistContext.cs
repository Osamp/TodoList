using Microsoft.EntityFrameworkCore;
using TodoListLibrary;

namespace TodoListLibrary.Data;

public class TodoListContext : DbContext
{

    public TodoListContext(DbContextOptions<TodoListContext> options)
    : base(options)

    {

    }
    public DbSet<TodoItem> TodoItems { get; set; }
};
