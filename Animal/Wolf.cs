namespace Exercise3;

public class Wolf : Animal, IMammal
{
    public override string Name { get; set; } = "Wolf";
    public override double Height { get; set; }
    public override double Weight { get; set; }
    public override string Sound { get; set; } = "Howling";
    public bool IsAlpha { get; set; }

    public Wolf(string name)
    {
        Name = name;
    }

    public override void DoSound()
    {
    }

    public override void Move()
    {
        throw new NotImplementedException();
    }
}
