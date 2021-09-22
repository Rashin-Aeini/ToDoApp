using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Data;
using Xunit;

namespace ToDoAppTest
{

    public class TodoSequencerTest
    {
        [Fact]
        public void TodoIdTest()
        {
            for (int i = 0; i < 9; i++)
            {
                TodoSequencer.nextTodoId();
            }

            Assert.Equal(10, TodoSequencer.nextTodoId());

        }
        [Fact]
        public void ResetTest()
        {
            for (int i = 0; i < 9; i++)
            {
                TodoSequencer.nextTodoId();

            }
            TodoSequencer.reset();
            Assert.Equal(1, TodoSequencer.nextTodoId());

        }
    }
}

