namespace Exercise3;

public class Dog : Animal
{
    public override string Name { get; set; } = "Dog";
    public override double Height { get; set; }
    public override double Weight { get; set; }
    public override string Sound { get; set; } = "woof";
    public int NumberOfLegs { get; set; } = 4;

    public Dog(string name)
    {
        Name = name;
    }

    public override void Move()
    {
        throw new NotImplementedException();
    }

    public override string Stats()
    {
        return GetType().GetProperties().Select(x => x.Name).Aggregate((x, y) => x + ", " + y);
    }

    public void RandomMethod()
    {
        Console.WriteLine("This is a random method.");
    }
}
