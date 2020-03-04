using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests
{
  [TestClass]
  public class SphereTests
  {

    [TestMethod]
    public void Sphere_GetCircumference_Circumference()
    {
      // Arrange
      Circle newCircle = new Circle(4);
      Sphere newSphere = new Sphere(newCircle);
      // Act
      double result = newSphere.GetVolume();
      // Assert
      Assert.AreEqual(result, 268.08, 1);
    }
    [TestMethod]
    public void Sphere_GetCSurfaceArea_SurfaceArea()
    {
      // Arrange
      Circle newCircle = new Circle(6);
      Sphere newSphere = new Sphere(newCircle);
      // Act
      double result = newSphere.GetSurfaceArea();
      // Assert
      Assert.AreEqual(result, 452.39, 1);
    }
  }
}         
