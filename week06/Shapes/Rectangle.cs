public class Rectangle : Shape
{
    private double _sideA;
    private double _sideB;

    public Rectangle(double sideA, double sideB, string color) : base(color)
    {
        _sideA = sideA;
        _sideB = sideB;
    }

    public override double GetArea()
    {
        return _sideA * _sideB;
    }
}