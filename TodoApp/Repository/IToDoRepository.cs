using System.Collections.Generic;
using app.Models;
 
namespace app.Repository
{
    public interface IToDoRepository
    {
        void Add(ToDo item);
        IEnumerable<ToDo> GetAll();
        ToDo Find(int Id);
        void Remove(int Id);
        void Update(ToDo item);
    }
}