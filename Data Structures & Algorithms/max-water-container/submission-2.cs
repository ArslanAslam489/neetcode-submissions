public class Solution {
    public int MaxArea(int[] heights) {
       int left=0, right=heights.Length-1;
 int maxarea = 0;
 while(left<right)
 {
     int width = left>right?left-right:right-left;
     int height = Math.Min(heights[left], heights[right]);
     int currentarea = width * height;
     if(currentarea>maxarea)
         maxarea = currentarea;



     if (heights[left] < heights[right]) left++;
     else right--;
 }

 return maxarea;
    }
}
