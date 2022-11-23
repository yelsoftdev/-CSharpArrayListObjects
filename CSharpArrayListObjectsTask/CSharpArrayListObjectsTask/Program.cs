using System;
using System.Collections;

namespace CSharpArrayListObjectsTask
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArrayList listOfPersons = new ArrayList();
            int personsCount = 3, p = 0, ages;
            string names = string.Empty;
            string[] digitName = { "First", "Second", "Third" };

            Console.WriteLine("*******Input*******");
            Console.WriteLine("You can enter the three names and ages:-");
            for (p = 0; p < personsCount; p++)
            {
                Console.Write(String.Format($"Enter {digitName[p]} name: "));
                names = Console.ReadLine();
                Console.Write(String.Format($"Enter age of {digitName[p]} name : "));
                ages = int.Parse(Console.ReadLine());

                listOfPersons.Add(new Person()
                {
                    name = names,
                    age = ages
                });
            }

            Console.WriteLine("*******Output*******");
            p = 0;
            foreach (Person data in listOfPersons)
            {
                Console.Write(String.Format($"\n{digitName[p]} name - age : {data.ToString()}"));
                p++;
            }
            Console.ReadLine();
        }
    }
    public class Person
    {
        public string name { get; set; }
        public int age { get; set; }

        public override string ToString()
        {
            return String.Format($"{name} - {age}");
        }
    }
}
