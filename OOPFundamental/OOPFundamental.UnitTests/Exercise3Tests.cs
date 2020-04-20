using System;
using System.Collections.Generic;
using Exercise3.Models;
using NUnit.Framework;
namespace OOPFundamental.UnitTests
{
    [TestFixture]
    public class Exercise3Tests
    {
        public static IEnumerable<TestCaseData> CalculateSurfaceOfShapeIsCorrectedTestCases
        {
            get
            {
                yield return new TestCaseData(new Circle() { Width = 10 }, 5*Math.PI);
                yield return new TestCaseData(new Rectangle() { Width = 10, Height = 5 }, 50);
                yield return new TestCaseData(new Triangle()
                {
                    Height = 10,
                    Width = 20
                }, 100);
            }
        }

        [TestCaseSource("CalculateSurfaceOfShapeIsCorrectedTestCases")]
        public void CalculateSurface_OfShape_IsCorrected(Shape shape, double surface)
        {
            Assert.AreEqual(surface, shape.CalculateSurface());
        }
    }
}
