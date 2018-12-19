using System;
using Xunit;

public class TwoSumTest
{
  [Theory]
  [InlineData(new int[]{2, 7, 11, 15}, 9, new int[]{0, 1})]
  public void Test(int[] nums, int target, int[] expected)
  {
    var solution = new TwoSumSolution();
    var indexes = solution.TwoSum(nums, target);
    Assert.Equal(expected, indexes);
  }
}
