using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using app.Repository;
using app.Models;


namespace app.Controllers
{
    [Route("api/[controller]")]
    public class ToDoController : Controller
    {
        public IToDoRepository TodoRepository { get; set; }

        public ToDoController(IToDoRepository repository)
        {
            TodoRepository = repository;
        }

        // GET api/todo
        [HttpGet]
        public IEnumerable<ToDo> Get()
        {
            return TodoRepository.GetAll();
        }

        // GET api/todo/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var todo = TodoRepository.Find(id);
            if (todo == null) {
                return NotFound();
            }
            return new ObjectResult(todo);
        }

        // POST api/todo
        [HttpPost]
        public void Post([FromBody]ToDo todo)
        {
            TodoRepository.Add(todo);
        }

        // PUT api/todo/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]ToDo todo)
        {
            TodoRepository.Update(todo);
        }

        // DELETE api/todo/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            TodoRepository.Remove(id);
        }
    }
}
