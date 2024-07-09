using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Red", 5);
        Rectangle rectangle = new Rectangle("Blue", 10, 2);
        Circle circle = new Circle("Yellow", 5);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape sha in shapes)
        {
            string sh1 = sha.GetColor();
            double sh2 = sha.GetArea();
            Console.WriteLine($"{sh1}, {sh2}");
            
        }

        // DisplayShape(square);
        // DisplayShape(rectangle);
        // DisplayShape(circle);
        
        // static void DisplayShape(Shape shape)
        // {
        //     Console.WriteLine(shape.GetArea());
        // }
        
    }
}