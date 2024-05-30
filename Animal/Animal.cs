namespace Exercise3;

public abstract class Animal { 

    public abstract string Name { get; set; }

    public abstract double Height { get; set; }

    public abstract double Weight { get; set; }

    public abstract string Sound { get; set; }

    public Animal() 
    {
    }

    public virtual void DoSound() => Console.WriteLine(Sound);

    public abstract void Move();

    public virtual string Stats()
    {
        return GetType().GetProperties().Select(x => x.Name).Aggregate((x, y) => x + ", " + y);
    }
}
