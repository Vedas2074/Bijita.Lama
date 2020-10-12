using System;
public abstract class Shape
{
    public abstract double GerArea();
    public abstract double GetPerimeter();
    public void PrintDetails()
    {
        Console.WriteLine("Printing deatils for shape..");
    }
}
public class Rectangle : Shape
{
    public double Length { get; set; }
    public double Breadth { get; set; }
    public override double GetArea() => Length * Breadth;
    public override double GetPerimeter() => 2 * ( Length + Breadth);
}
public class Square : Rectangle
{

}
//this point the current object(pointer)