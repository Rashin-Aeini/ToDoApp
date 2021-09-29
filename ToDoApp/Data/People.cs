using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Models;

namespace ToDoApp.Data
{
    public static class People
    {
        private static Person[] personArray = new Person[0];

        public static int Size()
        {
            return personArray.Length;
        }
        public static Person[] FindAll()
        {
            return personArray;
        }
        public static Person FindById(int personId)
        {
            foreach (var item in personArray)
            {
                if (item.PersonId== personId)
                {
                    return item;
                }
            }
            return null;
        }


        public static void Add(Person entry)
        {

            Array.Resize(ref personArray, Size() + 1); // bozorg kardane yek araye
            personArray[Size() - 1] = entry; //shomare andis araye

        }

        public static bool Remove(int personId)
        {
            bool result = false;

            Person[] temporary = new Person[Size()];

            int counter = 0;
            foreach (Person item in personArray)
            {
                if (item.PersonId == personId)
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

            personArray = temporary;

            return result;
        }
        public static void Clear()
        {
            personArray = new Person[0];

        }
    }
}
