namespace Exercise3;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            var testPerson = new Person("test", "test");

            Console.WriteLine(testPerson);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
