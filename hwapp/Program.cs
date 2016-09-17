using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "dude";
            Console.WriteLine("Hello " + person.Name + "! ");
        }
    }
}
