using Microsoft.EntityFrameworkCore;
using TodoApi.Controllers.Models;

namespace TodoApi.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options) 
        {
        
        }
        public DbSet<TodoItem> todoItems { get; set; } = null!;

    }
}
