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
   public class PersonSequencerTest
    {
        [Fact]
        public void PersonIdTest()
        {
            for (int i = 0; i < 9; i++)
            {
                PersonSequencer.nextPersonId();
            }

            Assert.Equal(10, PersonSequencer.nextPersonId());
           
        }
        [Fact]
        public void ResetTest()
        {
            for(int i = 0; i < 9; i++)
            {
                PersonSequencer.nextPersonId();

            }
            PersonSequencer.reset();
            Assert.Equal(1, PersonSequencer.nextPersonId());

        }
    }
}
