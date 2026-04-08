using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Crear lista de figuras
        List<Shape> shapes = new List<Shape>();

        // Agregar diferentes figuras
        shapes.Add(new Square("Red", 5));
        shapes.Add(new Rectangle("Blue", 4, 6));
        shapes.Add(new Circle("Green", 3));

        // Iterar y mostrar resultados
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}, Area: {shape.GetArea()}");
        }
    }
}
