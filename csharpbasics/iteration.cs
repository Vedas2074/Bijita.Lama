using System;
class iterationStatement
{
    //pascal casing: IterationStatement for method name class name
    //came casing: iterationStatement for variables

    public static void Main()
    {
        iterationStatement iterationStatement = new iterationStatement();
        iterationStatement.Learnforloops();
    }
    void Learnforloops()
    {
        int i;
        for(i = 0; i < 10; i++)
        {
            Console.WriteLine("Hello World");
        
        
        }
        int[] numbers = { 4, 5, 12, 23, 64, 15 };
        for(int x = 0; x < numbers.Length; x++)
        {
            Console.WriteLine(numbers[x]);
        }
    }
}