namespace VectorTesting
{
    public class Vector2DTests 
    {
        public class TestVector2D : Vector2D, IEquatable<TestVector2D>
        {
            public TestVector2D(int r1, int r2) : base(r1, r2)
            {
            }

            public bool Equals(TestVector2D? other)
            {
                 if (R1 == other.R1 && R2 == other.R2)
                     return true;
                 return false;
            }
        }

        [Theory]
        [InlineData(1, 1, 1, 1, 2, 2)]
        [InlineData(1, 2, 1, 2, 2, 4)]
        [InlineData(5, 5, 5, 5, 10, 10)]
        [InlineData(4, 7, 1, 6, 5, 13)]
        public void TwoVectors_Add_ReturnCombinedVector(int vR1, int vR2, int ovR1, int ovR2, int expectedR1, int expectedR2)
        {
            TestVector2D OGVector = new TestVector2D(vR1, vR2);
            TestVector2D OtherVector = new TestVector2D(ovR1, ovR2);
            TestVector2D expectedVector = new TestVector2D(expectedR1, expectedR2);

            Vector2D combinedVector = OGVector.Add(OtherVector);

            Assert.True(expectedVector.Equals(combinedVector));
        }

        [Theory]
        [InlineData(1, 1, 1, 1, 0, 0)]
        [InlineData(1, 2, 2, 1, -1, 1)]
        [InlineData(4, 7, 1, 6, 3, 1)]
        public void TwoVectors_Subtract_ReturnCombinedVector(int vR1, int vR2, int ovR1, int ovR2, int expectedR1, int expectedR2)
        {
            Vector2D OGVector = new Vector2D(vR1, vR2);
            Vector2D OtherVector = new Vector2D(ovR1, ovR2);
            Vector2D expectedVector = new Vector2D(expectedR1, expectedR2);

            Vector2D combinedVector = OGVector.Subtract(OtherVector);

            Assert.Equivalent(expectedVector,combinedVector);
        }

        [Theory]
        [InlineData(1, 1, 1, 1, 2)]
        [InlineData(1, 2, 2, 1, 4)]
        [InlineData(4, 7, 1, 6, 46)]
        public void TwoVectors_Scalar_ReturnScalar(int vR1, int vR2, int ovR1, int ovR2, int expected)
        {
            Vector2D OGVector = new Vector2D(vR1, vR2);
            Vector2D OtherVector = new Vector2D(ovR1, ovR2);
           
            int scalar = OGVector.Scalar(OtherVector);

            Assert.Equal(expected, scalar);
        }

        [Theory]
        [InlineData(1, 1, 1, 1, 2)]
        [InlineData(1, 2, 2, 1, 5)]
        [InlineData(4, 7, 1, 6, 31)]
        public void TwoVectors_CrossProduct_ReturnCrossProduct(int vR1, int vR2, int ovR1, int ovR2, int expected)
        {
            Vector2D OGVector = new Vector2D(vR1, vR2);
            Vector2D OtherVector = new Vector2D(ovR1, ovR2);

            int crossProduct = OGVector.CrossProduct(OtherVector);

            Assert.Equal(expected, crossProduct);
        }
    }
}