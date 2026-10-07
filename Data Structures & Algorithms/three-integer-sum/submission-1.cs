public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
         List<List<int>> list=new List<List<int>>();
 Array.Sort(nums);
 for (int i = 0; i < nums.Length - 2; i++)
 {
     if (nums[i] > 0) break;
     if (i > 0 && nums[i] == nums[i - 1]) continue;

     int left = i + 1, right = nums.Length - 1;

     while (left < right)
     {
         {
             int sum = nums[left] + nums[right] + nums[i];
             if (sum < 0) left++;
             else if (sum > 0) right--;
             else
             {
                 list.Add(new List<int> { nums[i], nums[left], nums[right] });
                 left++; right--;
                 while (left < right && nums[left] == nums[left - 1]) left++;     // skip duplicate left
                 while (left < right && nums[right] == nums[right + 1]) right--;
             }


         }
     }
 }
 
 return list;
    }
}
