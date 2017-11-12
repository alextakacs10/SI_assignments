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
        private Genders gender;

        public enum Genders {Male, Female};

        public Person()
        {

        }

        public Person(string name, string birthDate, Genders gender)
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

        public Genders Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public override string ToString()
        {
            return "Name: " + Name +
                ", BirthDate: " + BirthDate +
                ", Gender: " + Gender;
        }
    }
}
