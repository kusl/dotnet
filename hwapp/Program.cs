using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine("Hello " + person.Name + "! ");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(person.Email);
            }
        }
    }
}
