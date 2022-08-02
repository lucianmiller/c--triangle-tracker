using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tracker.Models;

namespace Tracker.Tests
{
  [TestClass]
  public class TriangleTests
  {

    [TestMethod]
    public void TriangleConstructor_CreatesInstanceOfTriangle_Triangle()
    {
      Triangle newTriangle = new Triangle(1, 2, 3);
      Assert.AreEqual(typeof(Triangle), newTriangle.GetType());
    }

    [TestMethod]
    public void TriangleConstructor_StoresValuesCorrectly_Triangle()
    {
      //Arrange
      Triangle newTriangle = new Triangle(2, 2, 8);

      //Assert
      Assert.AreEqual(2, newTriangle.Side1);
      Assert.AreEqual(2, newTriangle.Side2);
      Assert.AreEqual(8, newTriangle.Side3);
      Assert.AreEqual("", newTriangle.Type);
    }

    [TestMethod]
    public void CheckType_DeterminesNotATriangle_Triangle()
    {
      //Arrange
      Triangle newTriangle = new Triangle(2, 2, 8);
      newTriangle.CheckType();

      //Act
      string answer = "Not a triangle";
      string result = newTriangle.Type;

      //Assert
      Assert.AreEqual(answer, result);
    }

    [TestMethod]
    public void CheckType_DeterminesEquilateralTriangle_Triangle()
    {
      //Arrange
      Triangle newTriangle = new Triangle(3, 3, 3);
      newTriangle.CheckType();

      //Act
      string answer = "Equilateral Triangle";
      string result = newTriangle.Type;

      //Assert
      Assert.AreEqual(answer, result);
    }

    [TestMethod]
    public void CheckType_DeterminesIsoscelesTriangle_Triangle()
    {
      //Arrange
      Triangle newTriangle = new Triangle(4, 4, 7);
      newTriangle.CheckType();

      //Act
      string answer = "Isosceles Triangle";
      string result = newTriangle.Type;

      //Assert
      Assert.AreEqual(answer, result);
    }
  }
}