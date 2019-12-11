using System.ComponentModel.DataAnnotations;

namespace ToDo.Models
{
    public class ToDoItem
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Title { get; set; }
        
        public bool Completed { get; set; } 
    }
}