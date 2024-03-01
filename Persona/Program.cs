// 1. Class Persona
public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public bool Married { get; set; }
    public string IdentityDocumentNumber { get; set; }

    public Person(string firstName, string lastName, int age, bool married, string identityDocumentNumber)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Married = married;
        IdentityDocumentNumber = identityDocumentNumber;
    }

    public void ProfessionAction1()
    {
        // Action 1 according to the person's profession
        Console.WriteLine(FirstName + " is performing action 1 of their profession.");
    }

    public void ProfessionAction2()
    {
        // Action 2 according to the person's profession
        Console.WriteLine(FirstName + " is performing action 2 of their profession.");
    }

    public void ProfessionAction3()
    {
        // Action 3 according to the person's profession
        Console.WriteLine(FirstName + " is performing action 3 of their profession.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating different Person objects
        Person person1 = new Person("Victor", "Alcantara", 30, true, "12345678");
        Person person2 = new Person("Andres", "Lopez", 25, false, "87654321");
        Person person3 = new Person("Erick", "Toribio", 35, true, "23456789");
        Person person4 = new Person("Ana", "Sanchez", 28, false, "34567890");
        Person person5 = new Person("Raul", "Garcia", 40, true, "45678901");
        Person person6 = new Person("Isabella", "gonzales", 32, false, "56789012");
        Person person7 = new Person("Luis", "Martinez", 38, true, "67890123");

        // Calling different actions for each person
        person1.ProfessionAction1();
        person2.ProfessionAction2();
        person3.ProfessionAction3();
        person4.ProfessionAction1();
        person5.ProfessionAction2();
        person6.ProfessionAction3();
        person7.ProfessionAction1();
    }
}