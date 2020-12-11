using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker;

namespace TriangleTracker.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void CheckType_notATriangle_True()
    {
      // instantiate (in·stan·ti·ate)
      Triangle triangle1 = new Triangle(3, 4, 50);

      Assert.AreEqual("not a triangle", triangle1.CheckType());
    }
    [TestMethod]
    public void CheckType_Scalene_True()
    {
      Triangle triangle2 = new Triangle(3, 4, 5);
      Assert.AreEqual("scalene triangle", triangle2.CheckType());
    }
    [TestMethod]
    public void CheckType_Equalateral_True()
    {
      Triangle triangle3 = new Triangle(4, 4, 4);
      Assert.AreEqual("equilateral triangle", triangle3.CheckType());
    }
    [TestMethod]
    public void CheckType_Isosceles_True()
    {
    Triangle triangle4 = new Triangle(3, 4, 4);
    Assert.AreEqual("isosceles triangle", triangle4.CheckType());
    }
  }
}