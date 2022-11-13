using BadListExercise;
using Microsoft.Win32.SafeHandles;

namespace BadTestExerciseTests
{
    public class BadListTests
    {
        [Theory]
        [InlineData(3,4)]
        [InlineData(1,1)]
        [InlineData(2,1)]
        [InlineData(10,0)]
        public void CountNumbersTests(int number, int expected)
        {
            BadList list = new BadList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(3);
            list.Add(3);
            list.Add(3);
            list.Add(4);

            int result = list.CountNumbers(number);

            Assert.Equal(expected, result);

        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(10000)]
        public void AddOneNumber_GetFirstNumber(int number)
        {
            BadList list = new BadList();

            list.Add(number);

            Assert.Equal(number, list.Get(1));
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        public void GetIndexNumberFromList(int index)
        {
            BadList list = new BadList();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);


            Assert.Equal(index,list.Get(index));
        }
    }
}