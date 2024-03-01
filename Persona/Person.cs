// 1. Class Person
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
