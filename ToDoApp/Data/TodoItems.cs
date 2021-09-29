using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Models;

namespace ToDoApp.Data
{
    public static class TodoItems
    {
        private static Todo[] todoArray = new Todo[0];


        public static int Size()
        {
            return todoArray.Length;
        }
        public static Todo[] FindAll()
        {
            return todoArray;
        }
        public static Todo FindById(int todoId)
        {
            foreach (var item in todoArray)
            {
                if (item.TodoId == todoId)
                {
                    return item;
                }
            }
            return null;
        }


        public static void Add(Todo entry)
        {

            Array.Resize(ref todoArray, Size() + 1); 
            todoArray[Size() - 1] = entry; 

        }


        public static void Clear()
        {
            todoArray = new Todo[0];

        }

        public static Todo[] FindByDoneStatus(bool doneStatus)
        {

            Todo[] result = new Todo[0];

            foreach (var item in todoArray)
            {
                if (item.Done == doneStatus)
                {
                    Array.Resize(ref result, result.Length + 1);//afzayesh tool araye
                    result[result.Length - 1] = item;//andis
                }
            }

            return result;
        }
        public static Todo[] FindByAssignee(int personId)
        {
            Todo[] result = new Todo[0];
            foreach (var item in todoArray)
            {
                if (item.Assignee.PersonId== personId)
                {
                    Array.Resize(ref result, result.Length + 1);
                    result[result.Length - 1] = item;
                }
            }

            return result;
        }
        public static Todo[] FindByAssignee(Person assignee)
        {
           
            return FindByAssignee(assignee.PersonId);

        }

        public static bool Remove(int todoId)
        {
            bool result = false;

            Todo[] temporary = new Todo[Size()];

            int counter = 0;
            foreach (Todo item in todoArray)
            {
                if (item.TodoId == todoId)
                {
                    result = true;
                    continue;
                }

                if (Size() > counter)
                {
                    temporary[counter] = item;
                    counter++;
                }
            }

            if (result)
            {
                Array.Resize(ref temporary, Size() - 1);
            }

            todoArray = temporary;

            return result;
        }


    
    public  static Todo[] FindUnassignedTodoItems()
        {
            Todo[] result = new Todo[0];

            foreach (var item in todoArray)
            {
                if (item.Assignee == null)
                {
                    Array.Resize(ref result, result.Length + 1);
                    result[result.Length - 1] = item;
                }
            }

            return result;

        }


    }

}

