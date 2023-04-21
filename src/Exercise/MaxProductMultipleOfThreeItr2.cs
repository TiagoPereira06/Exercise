using NUnit.Framework;

namespace Exercise;

public class MaxProductMultipleOfThreeItr2
{
    public static int MaxProductMultipleOfThree(int[] numbers)
    {
        if (numbers.Length <= 1)
        {
            return int.MinValue;
        }

        var biggestMultipleOf3 = int.MinValue;
        var max = int.MinValue;

        foreach (var t in numbers)
        {
            if (t % 3 == 0 && t > biggestMultipleOf3)
            {
                biggestMultipleOf3 = t;
            }
            else if (t > max)
            {
                max = t;
            }
        }

        return biggestMultipleOf3 * max;
    }

    [TestFixture]
    public class MaxProductOfTwoNumbersThatAreMultipleOf3Tests
    {
        [TestCase(new[] { 6, 8, 8, 7, 2, 5 }, 48)]
        [TestCase(new[] { 1, 9, 2, 4 }, 36)]
        [TestCase(new[] { 1 }, int.MinValue)]
        [TestCase(new int[0], int.MinValue)]
        public void Should_Return_Max_Product_Of_Two_Numbers_That_Are_Multiple_Of_3_From_Array(int[] numbers,
            int expectedResult)
        {
            // Act
            var actual = MaxProductMultipleOfThree(numbers);

            // Assert
            Assert.AreEqual(expectedResult, actual);
        }
    }
}