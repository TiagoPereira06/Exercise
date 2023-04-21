using NUnit.Framework;

namespace Exercise;

public class MaxProductMultipleOfThreeItr1
{
    public static int MaxProductMultipleOfThree(int[] numbers)
    {
        var maxProduct = int.MinValue;

        for (var i = 0; i < numbers.Length - 1; i++)
        {
            for (var j = i + 1; j < numbers.Length; j++)
            {
                var currentProduct = numbers[i] * numbers[j];

                if (currentProduct % 3 != 0)
                {
                    continue;
                }

                if (currentProduct > maxProduct)
                {
                    maxProduct = currentProduct;
                }
            }
        }

        return maxProduct;
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