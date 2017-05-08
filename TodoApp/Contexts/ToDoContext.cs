
using app.Models;
using Microsoft.EntityFrameworkCore;
 
namespace app.Contexts
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options)
            :base(options) { }
        public ToDoContext(){ }
        public DbSet<ToDo> ToDos { get; set; }
    }
}