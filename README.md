
# C# Exercise Collection - Encapsulation, Inheritance, and Polymorphism

Throughout the tasks, there are some knowledge questions (starting with "F:"). These questions should be answered as comments in the code. The code does not need to take input from a user.

## 3.1) Encapsulation
1. Create a class `Person` and give it the following private fields:
`age`, `fName`, `lName`, `height`, `weight`
Create public properties with get and set that fetch or assign the variable.
Instantiate a person in Program.cs, can you access the variables directly?
Implement validation in the created properties:
- Age can only be assigned a value greater than 0.
- FName is mandatory and must not be less than 2 characters or more than 10 characters.
- LName is mandatory and must not be less than 3 characters or more than 15 characters.
Throw an exception of type ArgumentException in each property if its validation is not completed, the exception should contain a descriptive message.
Make sure to handle exceptions in Program class with a try-catch block.

2. To further encapsulate Person objects we will create the class `PersonHandler` -
a class whose purpose is to create and manage your Person objects.
In `PersonHandler` class create method:
```csharp
public void SetAge(Person pers, int age)
```
Use the sent person's Age property to set the person's age attribute via `SetAge` method. Instead of just using a property we have now abstracted two layers.

3. In `PersonHandler`, write a method that creates a person with given values:
```csharp
public Person CreatePerson(int age, string fname,
string lname, double height, double weight)
```
4. Continue creating methods in `PersonHandler` to be able to handle all operations one might want to do with a `Person`.

5. When this class is complete, comment out your previous instance of `Person` from `Program.cs`, and instead instantiate a `PersonHandler`. Create some people and test your methods.

## 3.2) Polymorphism
1. Create the abstract class `UserError`
2. Create the abstract method `UEMessage()` that has return type string.
3. Create a regular class `NumericInputError` that inherits from `UserError`
4. Write an override for `UEMessage()` so that it returns "You tried to use a numeric input in a text only field. This fired an error!"
5. Create a regular class `TextInputError` that inherits from `UserError`
6. Write an override for `UEMessage()` so that it returns "You tried to use a text input in a numeric only field. This fired an error!"
7. In `Program.cs` Main method: Create a list with `UserErrors` and populate it with instances of `NumericInputError` and `TextInputError`.
8. Print all `UserErrors` `UEMessage()` through a foreach loop.
9. Now create three own classes with three own definitions on `UEMessage()`
10. Test and see that it works.

## 3.3) Inheritance
1. Create abstract class `Animal`
2. Fill the `Animal` class with properties that all animals should have. For example, name, weight, age.
3. Create an abstract method called `DoSound()`.
4. Add a constructor.
5. Create Subclasses (inherits from `Animal`): `Horse`, `Dog`, `Hedgehog`, `Worm` and `Bird`, `Wolf`.
6. Give these at least one unique property each. Which property it is is not important here. Example `Worm`: `IsPoisonous`, `Hedgehog`: `NrOfSpikes`, `Bird`: `WingSpan` etc.
7. Implement so that `DoSound()` method prints out how the animal sounds.
8. Now create the following three classes: `Pelican`, `Flamingo` and `Swan`. These should inherit from `Bird`.
9. Give these at least one unique property each.
10. Create the interface `IPerson` with a method declaration `Talk()`.
11. Create the class `Wolfman` that inherits from `Wolf` and implements `IPerson` interface.
12. Implement `Talk()` that prints out what `Wolfman` says.
13. F: If we during development come to the conclusion that all birds need a new attribute, in which class should we put it?
14. F: If all animals need the new attribute, where should we put it then?

## 3.4) More polymorphism
1. Create the method `Stats()` in the `Animal` class that has return type string.
The method should be able to be overridden in its Subclasses. The method should return all properties that the animal has.
2. Write an override for `Stats()` in the subclasses for `Animal` so it returns all properties for that animal.
3. Create a list `Animals` in `Program.cs` that receives animals.
4. Create some animals (of different type) in your list.
5. Print out which animals are in the list with the help of a foreach loop
6. Also call `Animals` `Sound()` method in the foreach loop.
7. Make a check in the for loop if an animal is also of type `IPerson`, if it is type-cast to `IPerson` and call its `Talk()` method.
8. Create a list for dogs.
9. F: Try to add a horse to the list of dogs. Why does not it work?
10. F: What type must the list be for all classes to be stored together?
11. Print all `Animals` `Stats()`
through a foreach loop.
12. Test and see that it works.
13. F: Explain what is happening.
14. Print `Stats()` method only for all dogs through a foreach on `Animals`.
15. Create a new method with any name in the `Dog` class that only returns a random string.
16. Can you access that method from `Animals` list?
17. F: Why not?
18. Find a way to print out your new method for dog through a foreach on `Animals`.
Good luck!
