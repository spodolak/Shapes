using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests
{
  [TestClass]
  public class RectangleTests
  {
    [TestMethod]
    public void Rectangle_GetArea_AreaOfRectangle()
    {
      //Arrange
      Rectangle newRectangle = new Rectangle (4,4);
      //Act
      int result = newRectangle.GetArea();
      //Assert
      Assert.AreEqual(result, 16);
    }

    [TestMethod]
    public void Rectangle_IsSquare_True()
    {
      // Arrange
      Rectangle newRectangle = new Rectangle(4, 4);
      // Act
      bool result = newRectangle.IsSquare();
      // Assert
      Assert.AreEqual(result, true);
    }

    [TestMethod]
    public void Rectangle_IsSquare_False()
    {
      // Arrange
      Rectangle newRectangle = new Rectangle(4, 5);
      // Act
      bool result = newRectangle.IsSquare();
      // Assert
      Assert.AreEqual(result, false);
    }
  }
}