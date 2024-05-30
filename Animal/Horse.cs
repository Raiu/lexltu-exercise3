namespace Exercise3;

public class Horse : Animal
{
    public override string Name { get; set; } = "Horse";
    public override double Height { get; set; }
    public override double Weight { get; set; }
    public override string Sound { get; set; } = "Hourse sound!";
    public int MaxSpeed { get; set; }

    public Horse(string name)
    {
        Name = name;
    }

    public override void Move()
    {
        throw new NotImplementedException();
    }
}
