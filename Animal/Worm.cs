namespace Exercise3;

public class Worm : Animal
{
    public override string Name { get; set; } = "Worm";
    public override double Height { get; set; }
    public override double Weight { get; set; }
    public override string Sound { get; set; } = "Crunch";
    public bool IsPoisonous { get; set; }

    public Worm(string name)
    {
        Name = name;
    }

    public override void Move()
    {
        throw new NotImplementedException();
    }
}
