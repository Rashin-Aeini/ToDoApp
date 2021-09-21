using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Models;
using Xunit;

namespace ToDoAppTest
{
    public class TodoTest
    {
        [Fact]
       public void TestId()
        {
            Todo todo = new Todo(1,"");
            Assert.Equal(1, todo.TodoId);
        }


        [Fact]
        public void TestDes()
        {
            Todo todoDes = new Todo(1,"clean");
            Assert.Equal("clean",todoDes.Description);
        }

       
        [Fact]
        public void TestDoneWithFact()
        {
            Todo todoDes = new Todo(1, string.Empty);
            todoDes.Done = false;
            Assert.Equal(false, todoDes.Done);
        }
    }

}
