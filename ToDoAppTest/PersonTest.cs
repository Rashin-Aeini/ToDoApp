using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Models;
using Xunit;

namespace ToDoAppTest
{
    public class PersonTest
    {
        [Fact]
        public void TestId()
        {
            Person person = new Person(10);
            Assert.Equal(10, person.PersonId);

        }
        [Fact]
        public void TestName()
        {
            Person name = new Person(5);
            name.FirstName = "Rashin";
            Assert.Equal("Rashin", name.FirstName);
        }
        [Fact]
        public void TestLastName()
        {
            Person lastName = new Person(2);
            lastName.LastName = "Aeini";
            Assert.Equal("Aeini", lastName.LastName);
        }
    }
}
