using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests
{
  [TestClass]
  public class CubeTests
  {

    [TestMethod]
    public void Cube_GetVolume_VolumeOfCube()
    {
      // Arrange
      Rectangle newRectangle = new Rectangle(4, 4);
      Cube newCube = new Cube(newRectangle);
      // Act
      int result = newCube.GetVolume();
      // Assert
      Assert.AreEqual(result, 64);
    }

    [TestMethod]
    public void Cube_GetSurfaceArea_SurfaceAreaOfCube()
    {
      // Arrange
      Rectangle newRectangle = new Rectangle(4, 4);
      Cube newCube = new Cube(newRectangle);
      // Act
      int result = newCube.GetSurfaceArea();
      // Assert
      Assert.AreEqual(result, 96);
    }
  }  
}