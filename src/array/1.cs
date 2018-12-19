/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1] Two Sum
 *
 * https://leetcode-cn.com/problems/two-sum/description/
 *
 * algorithms
 * Easy (42.56%)
 * Total Accepted:    1.3M
 * Total Submissions: 3.2M
 * Testcase Example:  '[2,7,11,15]\n9'
 *
 * Given an array of integers, return indices of the two numbers such that they
 * add up to a specific target.
 * 
 * You may assume that each input would have exactly one solution, and you may
 * not use the same element twice.
 * 
 * Example:
 * 
 * 
 * Given nums = [2, 7, 11, 15], target = 9,
 * 
 * Because nums[0] + nums[1] = 2 + 7 = 9,
 * return [0, 1].
 * 
 * 
 * 
 * 
 */

using System.Collections.Generic;

public class TwoSumSolution {
  public int[] TwoSum(int[] nums, int target) {
    Dictionary<int, int> dic = new Dictionary<int, int>();
    for (int i = 0; i < nums.Length; i++)
    {
      int number = target - nums[i];
      if (dic.ContainsKey(number))
        return new int[2]{dic[number],i};
      else if (!dic.ContainsKey(nums[i]))
        dic.Add(nums[i],i);
    }

    return new int[2]{-1,-1};
  }
}
