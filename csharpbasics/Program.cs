using System;
//using AccessModifierAndMethods;
using FileDirectoryHandling;
//using LearningClasses;
//namespace csharpbasics

class Program
{
    static void Main()
    {
        //AccessModifier accessModifier = new AccessModifier();
        //accessModifier.DoSomething();
        //CONSTRUCTOR

        //Person person = new Person();
        //person.name = "Bijita";
        //person.Age = 12;
        //var x = person.Age;
        //LearningClasses.Person person = new LearningClasses.Person();
        //var person1 = new Person();
        //person1.Name = "bijita";
        //person1.Address = "ktm";
        //person1.Age = 12;


        //var person2 = new Person("bijita", "lalitpur", 20);
        //var person3 = new Person("Suresh", "Bhaktapur", 25);
        // var y = Math.Sqrt(342);
        //var s = Calculator.Sum(23,35);
        //var S = Calculator.Sum<int>(23, 40);
        // INHERITANCE 
        //Shape r = new Rectangle(23.6, 6.32);
        //Rectangle r1 = new Rectangle(278.6, 61.32);
        //r.PrintDetails();
        //r1.PrintDetails();

        //Shape s = new Square(35.2);        
        //s.PrintDetails();

        //Shape c = new Circle(23.4);
        //c.PrintDetails();
        //FILE HANDLING
        //FileIO file = new FileIO();
        //file.LearnFileReading();
        //FileIO file = new FileIO();
        //file.LearnFileWriting();
        //FileIo file = new FileIO();
        //file.LearnFileInfo();
        //FileIO file = new FileIO();
        //file.LearnDirectory();
        FileIO file = new FileIO();
        file.LearnDirectoryInfo();
    }
}

