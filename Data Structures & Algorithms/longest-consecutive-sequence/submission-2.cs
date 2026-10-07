public class Solution {
    public int LongestConsecutive(int[] nums) {
        var set = new HashSet<int>();
for (int i = 0; i < nums.Length; i++)
{
    set.Add(nums[i]);
}
int count = 0;
int longseq = 0;
foreach (var item in set)
{
    var leftseq = item - 1;
    if (!set.Contains(leftseq))
    {
        int curritem = item;
        count = 1;
        while(set.Contains(curritem+1))
        {
            curritem++;
            count++;
        }
    }
    if(count>longseq)
        longseq=count;

    
    
}
return longseq;
    }
}
