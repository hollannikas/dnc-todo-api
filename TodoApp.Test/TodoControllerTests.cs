using Xunit;
using Moq;
using System.Collections.Generic;
using System.Linq;
using app.Repository;
using app.Controllers;
using app.Models;

namespace TodoApp
{
    public class TodoControllerTests
    {
        [Fact]
        public void GetReturnsAllToDosInRepository()
        {
            var mockRepository = new Mock<IToDoRepository>();
            mockRepository.Setup(repo => repo.GetAll()).Returns(GetTestTodos());
            var controller = new ToDoController(mockRepository.Object);

            var result = controller.Get();

            Assert.Collection(result, 
                item => Assert.Equal(1, item.Id),
                item => Assert.Equal(2, item.Id),
                item => Assert.Equal(3, item.Id)
                );
        }

        private List<ToDo> GetTestTodos()
        {
            var toDos = new List<ToDo>();
            toDos.Add(new ToDo() { Id = 1, Description = "blabla1", Done = false});
            toDos.Add(new ToDo() { Id = 2, Description = "blabla2", Done = false});
            toDos.Add(new ToDo() { Id = 3, Description = "blabla3", Done = false});
            return toDos;
        }
    }
}