using System;
namespace AccessModifierAndMethods
{
class Methods
    {
        void PrintInfo()
        {
        Console.WriteLine("Printing something..");//takes no arguments
        Multiply(2.3f, 223.5f);
        Multiply(12.3f, 15.3f,15.6f );
        Sum(2.3, 5.1, 4.9, 6.7);
        Sum(5, 8, 7, 1, 6, 10);
        Greet("Bijita","Mr.");
        Greet("lushi"," ");//default miss linxa
        byte[] numbers = { 2, 4, 5, 105, 100, 1};
        (byte Min, byte Max) result = FindMinMax(numbers);
        PrintCustomerDetails(age:23, name:"Bijita", address:"Nakhipot");//named arguments
        
        }
        void PrintSomething(string message)
        {
            Console.WriteLine(message);//take one arguments
        }
        float Multiply(float firstNum, float secondNum)
        {
            float product = firstNum * secondNum;//takes two arguments
            return product;   
        }
        float Multiply(float firstNum, float secondNum, float thirdNum)
        {
            float product = firstNum * secondNum * thirdNum;//takes three arguments
            return product;   
        }
        double Sum(params double[] numbers)//takes multiply arguments
        {
        double sum = 0;
        foreach(double num in numbers)
            {
                sum = sum + num; 
            }
             return sum;

         }

    //optional arguments
         string Greet(string name, string prefix = "Miss.")
        {
            string fullName =$"{prefix}, {name}"; //(string interpolation)//prefix + " , "+ name; 
            return fullName;
         }
    
    //Returning multiple values : using tuples
        (byte, byte) FindMinMax(byte[] numbers)//one way is looping and ccmparing
        {
            byte max = numbers.Max();
            byte min = numbers.Min();

            return (min, max);



        }

        void PrintCustomerDetails(string name, string address, byte age )
        {
             Console.WriteLine($"{name}[{age}], {address}");
        }
        float Subtract(float firstNum, float secondNum) => firstNum - secondNum;
    }
}