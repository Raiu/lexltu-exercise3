namespace Exercise3;

public class Bird : Animal
{
    public override string Name { get; set; } = "Bird";
    public override double Height { get; set; }
    public override double Weight { get; set; }
    public override string Sound { get; set; } = "Tweet";
    public bool CanFly { get; set; }
    public double WingSpan { get; set; }
    
    public Bird(string name)
    {
        Name = name;
    }

    public override void Move()
    {
        throw new NotImplementedException();
    }
}
