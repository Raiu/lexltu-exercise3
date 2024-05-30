namespace Exercise3;

public class PersonHandler
{
    private List<Person> _persons = new();
    

    public Person CreatePerson(
        string fname, 
        string lname)
    {
        var person = new Person(fname, lname);
        _persons.Add(person);
        return person;
    }


    public Person CreatePerson(
        string fname, 
        string lname, 
        int age, 
        double height, 
        double weight)
    {
        var person = new Person(fname, lname, age, height, weight);
        _persons.Add(person);
        return person;
    }


    public void SetAge(Person person, int age) => person.SetAge(age);


    public void SetHeight(Person person, double height) => person.SetHeight(height);


    public void SetWeight(Person person, double weight) => person.SetWeight(weight);


    public List<Person> GetPersons() => _persons;


    public void AddPerson(Person person) => _persons.Add(person);


    public void RemovePerson(Person person) => _persons.Remove(person);


    public List<Person> FindPersons(
        string? fname = null,
        string? lname = null,
        int? age = null,
        double? height = null,
        double? weight = null
    )
    {
        return _persons
            .Where(x => fname == null || x.FName == fname)
            .Where(x => lname == null || x.LName == lname)
            .Where(x => age == null || x.Age == age)
            .Where(x => height == null || x.Height == height)
            .Where(x => weight == null || x.Weight == weight)
            .ToList();
    }
}
