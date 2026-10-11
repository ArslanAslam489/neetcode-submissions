public class Solution {
    public int[] TwoSum(int[] nums, int target) {
    for (int i = 0; i < nums.Length; i++)
{
    int iterator = nums.Length - 1;

    while (iterator>=0)
    {
        if (i == iterator)
        { iterator--; continue; }

        int sum = Math.Abs( nums[i] + nums[iterator]);
        if (sum == Math.Abs(target))
        {
            return i > iterator ? new int[] { iterator, i } : new int[] { i, iterator };
        }
        iterator--;
    }

    
    
}
return new int[0];
    }
}
