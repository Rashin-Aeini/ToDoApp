using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Data;
using ToDoApp.Models;
using Xunit;

namespace ToDoAppTest
{
    public class TodoItemTest
    {
        [Fact]
        public void sizeTest()
        {
            TodoItems.Clear();
            Assert.Equal(0, TodoItems.Size());
        }

        [Fact]
        public void UnassignedTest()
        {
            TodoItems.Clear();
            TodoItems.Add(new Todo(0, ""));
            Assert.Equal(1, TodoItems.FindUnassignedTodoItems().Length);

        }

        [Fact]
        public void ClearTest()
        {
            TodoItems.Add(new Todo(1,""));
            TodoItems.Clear();
            Assert.Equal(0, TodoItems.Size());

        }
        [Fact]
        public void AddTest()
        {
            TodoItems.Clear();
            TodoItems.Add(new Todo(1,""));
            Assert.Equal(true, TodoItems.Remove(1));
            TodoItems.Add(new Todo(1,""));
            Assert.Equal(1, TodoItems.Size());

        }
        [Fact]
        public void RemoveTest()
        {
            TodoItems.Clear();
            TodoItems.Add(new Todo(5, string.Empty));
            Assert.Equal(false, TodoItems.Remove(4));
        }
    }
}
