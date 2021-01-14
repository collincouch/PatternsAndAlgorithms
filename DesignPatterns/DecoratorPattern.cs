using System;
/// <summary>
/// Commonly used in drawing programs.
/// Draw a triangle, circle, square, etc
/// Then you want to add color to the shapes
/// Then you want ot add a border to the shape
/// Then you want to add pattern filling, etc
///
/// 
/// </summary>
namespace IK.DesignPatterns
{

    public interface Shape
    {
       string draw();
    }

    public class Triangle : Shape
    {
        public string draw()
        {
            return "Triangle";
        }
    }

    public class Circle : Shape
    {
        public string draw()
        {
            return "Circle";
        }
    }

    public abstract class ShapeDecorator:Shape
    {
        public Shape shape;

        public ShapeDecorator(Shape shape)
        {
            this.shape = shape;
        }
        public virtual string draw()
        {
            throw new NotImplementedException();
        }
    }

    public class ColorDecorator:ShapeDecorator
    {
        string color;

      
        public ColorDecorator(string color,Shape shape) : base(shape)
        {
            this.color = color;
        }

        public override string draw()
        {
            return color + " " + shape.draw();
        }

         
    }

    public class BorderDecorator : ShapeDecorator
    {
        
        public BorderDecorator(Shape shape) : base(shape)
        {
           
        }

        public override string draw()
        {
            return shape.draw() + " with a border";
        }


    }

    public class DecoratorPattern
    {
        public void TestDecoratorPattern()
        {
            Shape circle = new Circle();
            Console.WriteLine(circle.draw());
            Shape redCircle = new ColorDecorator("red", circle);
            Console.WriteLine(redCircle.draw());
            Shape redCircleWithBorder = new BorderDecorator(redCircle);
            Console.WriteLine(redCircleWithBorder.draw());
        }
    }
}
