namespace Exercise3;

class Program
{
    static void Main(string[] args)
    {
        var personHandler = new PersonHandler();
        Person personJohn;
        Person personJane;
        Person personBob;

        try {
            personJohn = personHandler.CreatePerson("John", "Doe", 30, 180, 70);
            personJane = personHandler.CreatePerson("Jane", "Doe", 24, 180, 70);
            personBob = personHandler.CreatePerson("Bob", "Doe");
            personBob.SetAge(40);
            personBob.SetHeight(180);
            personBob.SetWeight(70);
        } catch (Exception e) {
            Console.WriteLine(e.Message);
        }

        Console.WriteLine(string.Join("\n", personHandler.GetPersons().Select(x => x.ToString())));

        var testWolf = new Wolf("testy");

        Console.WriteLine(testWolf.Stats());

        List<Animal> animals = [
            testWolf, 
            new Dog("Rex"),
            new WolfMan("Wolfe"),
            new Bird("Tweety"),
            new Hedgehog("Hedge")
        ];

        foreach (var animal in animals)
        {
            Console.WriteLine($"\n\n{animal.GetType().Name}");
            Console.WriteLine(animal.Stats());
            if (animal is IPerson) {
                Console.WriteLine("Animal is IPerson");
                ((IPerson) animal).Talk();
            }

            if (animal is Dog) {
                ((Dog) animal).RandomMethod();
            }
            
            animal.DoSound();
        }


        List<Dog> dogs = new();

        dogs.Add(new Dog("Bobby"));
        dogs.Add(new Dog("Sally"));
        dogs.Add(new Dog("Belly"));
        dogs.Add(new Dog("Roxxy"));

        Console.WriteLine();







        Console.ReadKey();
    }
}