using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Data
{
    public static class TodoSequencer
    {
        private static int todoId;
        public static int nextTodoId()
        {
            return ++todoId;
        }
        public static void reset()
        {
            todoId = 0;
        }

    }
}
