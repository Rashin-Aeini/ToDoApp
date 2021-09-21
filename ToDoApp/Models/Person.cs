using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Models
{
    public class Person
    {
        private readonly int personId;
        private string firstName;
        private string lastName;


        public int PersonId { get { return personId; } }
        public string FirstName { get { return firstName; } set {firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }

        public Person(int id)
        {
            personId = id;
            
        }
    }
}
