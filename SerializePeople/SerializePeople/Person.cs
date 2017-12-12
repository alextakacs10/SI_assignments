using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace SerializePeople
{
    [Serializable]
    class Person
    {
        private String Name { get; set; }
        private DateTime BirthDate { get; set; }
        private Genders Gender { get; set; }
        private int Age
        {
            get { return DateTime.Today.Year - BirthDate.Year; }
            set { Age = value; }
        }

        public enum Genders { Male, Female };

        public Person()
        {

        }

        public Person(string name, DateTime birthDate, Genders gender)
        {
            Name = name;
            BirthDate = birthDate;
            Gender = gender;
        }

        public override string ToString()
        {
            return "Name: " + Name +
                ", BirthDate: " + BirthDate +
                ", Gender: " + Gender;
        }

        public void Serialize(string fileName)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, this);
            stream.Close();
        }

        public static Person Deserialize(string fileName)
        {
            Person person;
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(fileName, FileMode.Open);
            person = (Person) formatter.Deserialize(stream);
            stream.Close();
            return person;

        }
    }
}
