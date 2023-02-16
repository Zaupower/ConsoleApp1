

internal class Program
{
    private static void Main(string[] args)
    {

        DelegatePerson delegatePerson = new DelegatePerson();
        Person person = new Person
        {
            Age = 18,
            FirstName = "Marcelo",
            LastName = "Carvalho"
        };

        Console.WriteLine(delegatePerson.Gretings(PersonalizedGretings, person) );   

    }

    public static string PersonalizedGretings(string firsName, string lastName, int age)
    {
        string gretingFirstName = " Sr. ";
        string gretingLastName = "Mo";
        return gretingFirstName+ firsName+", "+ gretingLastName+" "+ lastName+ " have "+ age+" springs";  
    }
}

