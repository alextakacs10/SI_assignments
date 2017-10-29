using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Person
    {
        private String name;
        private String birthDate;
        private String gender;

        enum Genders {Male, Female};

        public Person()
        {

        }

        public Person(string name, string birthDate, string gender)
        {
            Name = name;
            BirthDate = birthDate;
            Gender = gender;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        public string Gender
        {
            get { return gender; }
            set {
                if (Enum.IsDefined(typeof(Genders), gender))
                {
                    Gender = value;
                }
                else
                {
                    Gender = "Error";
                }; }
        }

        public override string ToString()
        {
            return "Name: " + Name +
                ", BirthDate: " + BirthDate +
                ", Gender: " + Gender;
        }
    }
}
