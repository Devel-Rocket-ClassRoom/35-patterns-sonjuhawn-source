using System;

// README.md를 읽고 코드를 작성하세요.
Console.WriteLine("코드를 작성하세요.");


abstract class Shape
{
    public abstract double CalculateArea();
    public abstract string ClassifyShape(Shape p);
}
class Circle : Shape
{
    public int Radius { get; set; }
    public override double CalculateArea()
    {
        return Radius * Radius * Math.PI;
    }

    public override string ClassifyShape(Shape c) => c switch
    {
        {Radius: >= 10} => "큰 원",
        {Radius: < 10 } => "작은 원"
    };
}
class Rectangle : Shape
{
    public int Width {  get; set; }
    public int Height { get; set; }
    public override double CalculateArea()
    {
        throw new NotImplementedException();
    }

    public override string ClassifyShape(Shape p)
    {
        throw new NotImplementedException();
    }
}
class Square : Shape
{
    public int Side { get; set; }
    public override double CalculateArea()
    {
        throw new NotImplementedException();
    }

    public override string ClassifyShape(Shape p)
    {
        throw new NotImplementedException();
    }
}
