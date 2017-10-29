using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Employee : Person
    {
        private int salary;
        private string profession;
        private Room room;

        public Employee(string Name, string BirthDate, string Gender, int salary, string profession, Room room)
            :base(Name, BirthDate, Gender)
        {
            Salary = salary;
            Profession = profession;
            Room = room;
        }

        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public string Profession
        {
            get { return profession; }
            set { profession = value; }
        }

        public Room Room
        {
            get { return room; }
            set { room = value; }
        }

        public override string ToString()
        {
            return base.ToString() +
                ", Salary: " + Salary +
                ", Profession: " + Profession +
                ", Room: " + Room;
        }
    }
}
