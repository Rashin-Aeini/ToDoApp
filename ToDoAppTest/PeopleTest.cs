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
    public class PeopleTest
    {
        [Fact]
        public void FindbyIdTest()
        {
            People.Clear();
            People.Add(new Person(1));
            People.Add(new Person(2));
            People.Add(new Person(3));
            People.Add(new Person(4));
            People.Add(new Person(5));
            Person find = People.FindById(1);
            Assert.Equal(1, find.PersonId);

        }
        [Fact]
        public void RemoveTest()
        {
            People.Clear();
            People.Add(new Person(1));
            People.Add(new Person(2));
            People.Add(new Person(3));
            People.Add(new Person(4));
            People.Add(new Person(5));
            Assert.Equal(true, People.Remove(1));
            Assert.Equal(4, People.Size());
        }

        [Fact]
        public void ClearTest()
        {
            People.Add(new Person(1));
            People.Clear();
            Assert.Equal(0 ,People.Size() );

        }
        [Fact]
        public void AddTest()
        {
            People.Clear();
            People.Add(new Person(1));
            Assert.Equal(true,People.Remove(1));
            People.Add(new Person(1));
            Assert.Equal(1, People.Size());

        }

    }
}
