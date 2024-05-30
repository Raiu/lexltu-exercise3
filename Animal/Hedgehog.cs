namespace Exercise3;

public class Hedgehog : Animal
{
    public override string Name { get; set; } = "Hedgehog";
    public override double Height { get; set; }
    public override double Weight { get; set; }
    public override string Sound { get; set; } = "What does the hedgehog say?";
    public int NumberOfSpines { get; set; }

    public Hedgehog(string name)
    {
        Name = name;
    }

    public override void Move()
    {
        throw new NotImplementedException();
    }
}
