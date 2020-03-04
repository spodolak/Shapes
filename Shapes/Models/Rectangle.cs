namespace Shapes.Models
{
  public class Rectangle
  {
    public int Length { get; set; } 
    public int Width { get; set; }

    public Rectangle(int sideLength, int sideWidth)
    {
      Length = sideLength;
      Width = sideWidth;    
    }

    public int GetArea()
    {
      return Length * Width;
    }

    public bool IsSquare()
    {
      if (Length == Width)
      {
        return true;
      }
      else 
      {
        return false;
      }
    }
  }  
}