using System;

namespace Shapes.Models
{
  public class Circle
  {
    public double Radius { get; set; }

    public Circle(double radius)
    {
      Radius = radius;
    }
    public double GetDiameter()
    {
      return (Radius * 2);
    }
    public double GetCircumference()
    {
      return Math.PI * Radius * 2;
    }
  }
}