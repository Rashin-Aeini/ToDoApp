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
            Person find = People.FindById(1);
            Assert.Equal(null,find );

        }

    }
}
