namespace ConsoleApplication
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Person()
        {
            Id = 1;
            Name = "Bill Gates";
            Email = "billg@microsoft.com";
        }
    }
}