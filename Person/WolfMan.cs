namespace Exercise3;

public class WolfMan : Wolf, IPerson
{
    public WolfMan(string name) : base(name)
    {
    }

    public void Jump()
    {
        throw new NotImplementedException();
    }

    public void Talk()
    {
        Console.WriteLine($"The wolfman says: {base.Sound}");
    }
}
