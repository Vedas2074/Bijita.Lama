using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
             //LINQ -Language Integrated Query
            int[] numbers = {23, 45, 10, 45, 53, 17 };
            //find all the elements from numbers array which are less than 75 and greater than 10
            var result = numbers.Select(x => x < 75 && x > 10);
            //using method syntax - lambda expression
            var result1 = numbers.Where(x => x < 75 && x > 10);
            
            //Query syntax - query expression
            var result2 = from x in numbers
                          where x < 75 && x > 10
                          select x;
            string[] names = { "Bijita", "Bipin", "Rojeena", "Pragya", "Ishan"};
            //find names that starts with 'B' and having length less than 6
            var result3 = from name in names
                          where name.StartsWith ("B") && name.Length < 6
                          select name;

            //Projections
            var result4 = from num in numbers
                          select num * num;
            //ordering
            var result5 =  from num in numbers
                            orderby num
                            select num;

            //Partitioning
            var result6 = numbers.Take(5);
            var result7 = numbers.Skip(5).Take(5);

            //Quantifiers
            
            var isEvenThere = numbers.Any(num => num % 2 == 0);
            var areAllEven = numbers.All(num => num % 2 == 0);
            var is26there = numbers.Contains(26);
            
            var result8 = Enumerable.Range(1, 1000);
            var result9 = Enumerable.Repeat("Hello World", 10);
            
    
            
            List<Person> people = new List<Person>();
            
                new Person() {Id = 1, FirstName = "Bijita", LastName = "Lama", Address  ="Lalitpur", Age =20 };
                new Person() {Id = 2, FirstName = "Bipin", LastName = "Sunar", Address  ="Dang", Age = 18};
                new Person() {Id = 3, FirstName = "Pragya", LastName = "Joshi", Address  ="Lalitpur", Age = 19 };
                new Person() {Id = 4, FirstName = "Rojeena", LastName = "Tamang", Address  ="Lalitpur", Age = 17};
                new Person() { Id = 5, FirstName = "Ishan", LastName = "Maharjan", Address = "Ktm", Age = 16 };
                //find all people who live in kathmandu?
                var result10 = from person in people
                               where person.Address == "Ktm"
                               select person;
                //Find all people who are minors
                var result11 = from person in people
                               where person.Age < 18 && person.Address == "Lalitpur"
                               select person;
         }
    }
}
