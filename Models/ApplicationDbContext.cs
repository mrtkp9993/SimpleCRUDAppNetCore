using Microsoft.EntityFrameworkCore;

namespace ToDo.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }
        
        public DbSet<ToDoItem> ToDoItems { get; set; }
    }
}