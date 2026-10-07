public class Solution {
    public int[] ProductExceptSelf(int[] nums) {

        int[] results = new int[nums.Length];
 Array.Fill(results, 1);
 int leftproduct = 1;
 int rightproduct = 1;
 for (int i = 0; i < nums.Length; i++)
 {
     int selfindex = i;

     

     results[i] = results[i] * leftproduct;
     leftproduct = nums[i]* leftproduct;

     results[nums.Length - 1 - i] = results[nums.Length - 1 - i] * rightproduct;
     rightproduct = nums[nums.Length - 1 - i]* rightproduct;

 }

 return results;
        
    }
}
