using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Person alex = new Person("Alex", "1995.02.26", "Male");
            Console.WriteLine(alex.ToString());

            Person alexa = new Person("Alex", "1995.02.26", "Female");
            Console.WriteLine(alexa.ToString());

            Person unknown = new Person("Unknown", "1995.02.26", "Unknown");
            Console.WriteLine(unknown.ToString());

            Room room1 = new Room(1);

            Employee tony = new Employee("Tony", "1995.02.12", "Male", 100, "Slave", room1);
            tony.Room.RoomNumber = 1;
            Employee tonyClone = (Employee)tony.Clone();
            tonyClone.Room.RoomNumber = 7;

            Console.WriteLine(tony.ToString());
            Console.WriteLine(tonyClone.ToString());

            Console.ReadKey();
        }
    }
}
