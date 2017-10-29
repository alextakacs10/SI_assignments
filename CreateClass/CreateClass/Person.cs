using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Person
    {
        String Name;
        String BirthDate;
        public String Gender { get; set; }

        enum Genders {Male, Female};

        public Person(string name, String birthDate, string gender)
        {
            Name = name;
            BirthDate = birthDate;
            if (Enum.IsDefined(typeof(Genders), gender))
            {
                Gender = gender;
            } else
            {
                Gender = "Error";
            }
            
        }

        public override string ToString()
        {
            return "Name: " + Name + ", BirthDate: " + BirthDate + ", Gender: " + Gender;
        }
    }
}
