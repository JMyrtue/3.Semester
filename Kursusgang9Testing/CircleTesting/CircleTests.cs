using Xunit.Sdk;

namespace CircleTesting
{
    public class CircleTests
    {
        [Theory]
        [InlineData(2, 5, 5, 4, 4)]
        [InlineData(3, 4, 4, 2, 2)]
        [InlineData(100, 1, 1, 1, 1)]
        public void PointsInsideCircle_ReturnTrue(double radius, int centerX, int centerY, int pointX, int pointY)
        {
            Circle c = new Circle(radius, centerX, centerY);
            Point p = new Point(pointX, pointY);

            bool result = c.ContainsPoint(p);

            Assert.True(result);
        }

        [Theory]
        [InlineData(1, 5, 5, 4, 4)]
        [InlineData(2, 4, 4, 2, 2)]
        [InlineData(1, 100, 100, 10, 10)]
        public void PointsOutsideCircle_ReturnFalse(double radius, int centerX, int centerY, int pointX, int pointY)
        {
            Circle c = new Circle(radius, centerX, centerY);
            Point p = new Point(pointX, pointY);

            bool result = c.ContainsPoint(p);

            Assert.False(result);
        }

        [Theory]
        [InlineData(1, 5, 5, 1, 4, 4)]
        [InlineData(3.1, 4, 5, 2, 1, 1)]
        [InlineData(10, 1, 1, 10, 1, 1)]
        public void OverlappingCircles_ReturnTrue(double radius1, int x1, int y1, double radius2, int x2, int y2)
        {
            Circle c1 = new Circle(radius1, x1, y1);
            Circle c2 = new Circle(radius2, x2, y2);

            bool result = c1.CircleOverlap(c2);

            Assert.True(result);
        }

        [Theory]
        [InlineData(1, 6, 6, 1, 4, 4)]
        [InlineData(2.9, 4, 5, 2, 1, 1)]
        [InlineData(1, 100, 100, 1, 10, 10)]
        public void NotOverlappingCircles_ReturnFalse(double radius1, int x1, int y1, double radius2, int x2, int y2)
        {
            Circle c1 = new Circle(radius1, x1, y1);
            Circle c2 = new Circle(radius2, x2, y2);

            bool result = c1.CircleOverlap(c2);

            Assert.False(result);
        }
    }

    public class Vector2DTests 
    {

        [Theory]
        [InlineData(1, 1, 1, 1, 2, 2)]
        [InlineData(1, 2, 1, 2, 2, 4)]
        [InlineData(5, 5, 5, 5, 10, 10)]
        [InlineData(4, 7, 1, 6, 5, 13)]

        public void TwoVectors_Add_ReturnCombinedVector(int vR1, int vR2, int ovR1, int ovR2, int expectedR1, int expectedR2)
        {
            Vector2D OGVector = new Vector2D(vR1, vR2);
            Vector2D OtherVector = new Vector2D(ovR1, ovR2);
            Vector2D expectedVector = new Vector2D(expectedR1, expectedR2);

            Vector2D combinedVector = OGVector.Add(OtherVector);

            Assert.True(expectedVector.Equals(combinedVector));
        } 
    }
}