using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;
using System;

namespace Shapes.Tests
{
  [TestClass]
  public class CircleTests
  {
    [TestMethod]
    public void Circle_GetDiameter_DiameterOfCircle()
    {
      // Arrange
      Circle newCircle = new Circle(5);
      // Act
      double result = newCircle.GetDiameter();
      // Assert
      Assert.AreEqual(result, 10);
    }
    [TestMethod]
    public void Circle_GetCircumference_DiameterOfCircle()
    {
      // Arrange
      Circle newCircle = new Circle(5);
      // Act
      double result = newCircle.GetCircumference();
      // Assert
      Assert.AreEqual(result, 31.4159265358979, 0.0000000000001);
    }
  }
}
