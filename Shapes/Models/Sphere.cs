using System;

namespace Shapes.Models
{
  public class Sphere
  {
    public Circle RoundThing { get; set; }
    public Sphere(Circle roundthing)
    {
      RoundThing = roundthing;
    }
    public double GetVolume()
    {
      double volume = (4 * Math.PI * Math.Pow(RoundThing.Radius, 3))/3;
      return volume;
    }

    public double GetSurfaceArea()
    {
      return 4 * Math.PI * Math.Pow(RoundThing.Radius, 2);
    }
  }
}