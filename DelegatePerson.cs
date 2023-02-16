    public class DelegatePerson
    {
        //Delegates work has callbacks 
        //They can be declared in on class and call functions defined on another classes
        //Func is a delegate that receives two input parameters and one output : Func<input1, input2, output>
        //Action is a delegate that can receives up to 16 input parameters but return allways void

        public delegate string DelegatesGretings(string gretingFirstName, string gretingLastName, int gretingAge);

        public string Gretings(DelegatesGretings gretings, Person person)
        {
            return gretings(person.FirstName, person.LastName, person.Age);
        }
    }


//Implement Where
//public static IEnumerable<T> Where<T>(this IEnumerable<T> source, Func<T, bool> predicate)
//{
//    foreach (T item in source)
//    {
//        if (predicate(item))
//        {
//            yield return item;
//        }
//    }
//}
