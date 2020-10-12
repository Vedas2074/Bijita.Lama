using System.Collections.Generic;
public class Collections
{
    public void LearnAboutList()
    {
        List<string> names = new List<string> { "Ram", "James", "Binod"};//initialize garni
        names.Add("Bijita");
        names.Add("Rita");
        names.Add("Gita");
        names.Sort();
    }

    public void LearnAboutDictionary()//dictionary data type can hold key value pairs
    {
        //holds key-value pairs.key must be unique.
        //search fast
        Dictionary<string, string> countryCapitals = new Dictionary<string, string>();
        
        countryCapitals.Add( "Nepal", "Kathmandu");
        countryCapitals.Add( "India", "Delhi");
        countryCapitals.Add( "Japan", "Dhaka");
        countryCapitals.Add( "Korea", "Seul");        
    }

}