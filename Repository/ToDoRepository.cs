using System.Collections.Generic;
using System.Linq;
using app.Models;
using app.Contexts;
 
namespace app.Repository
{
    public class ToDoRepository : IToDoRepository
    {
        ToDoContext _context;

        public ToDoRepository(ToDoContext context)
        {
            _context = context;
        }        
 
        public void Add(ToDo item)
        {
            _context.ToDos.Add(item);
            _context.SaveChanges();
        }
 
		public IEnumerable<ToDo> GetAll()
        {
            return _context.ToDos.ToList();
        }

        public ToDo Find(int Id)
        {
            return _context.ToDos.Find(Id);
        }
        public void Remove(int Id) 
        {
            var todo = Find(Id);
            _context.ToDos.Remove(todo);
            _context.SaveChanges();
        }
        public void Update(ToDo item) {
            _context.ToDos.Update(item);
            _context.SaveChanges();
        }
    }
}