public class Calculator
{
    public static int Sum(int firstNum, int secondNum)
    {
        return firstNum + secondNum;
    }
    //using generic method we can work on multiple data type
    public static int Sum<T>(T firstNum, T secondNum)
    {
        return 0;//only syntax

    }
}