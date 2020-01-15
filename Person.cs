using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corrected_Program
{
    class Person
    {
        private string name , surname, mood, marital_status;
        private int age;
        public Person()
        {
            name= "Not typed in";
            surname="Not typed in";
            age= 0;
            mood= "Not typed in";
            marital_status = "Married";
            

        }
        public int Age { get { return age; }set { age = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Surname { get { return surname; } set { surname = value; } }
        public string Mood { get { return mood; } set { mood = value; } }
        public string Marital_Status { get { return marital_status; } }
        public string Brace_yourself()
        {
            return name +" "+ surname +", "+ age +", "+mood+", "+marital_status; 
        }
    
    }
}
