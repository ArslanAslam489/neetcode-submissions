public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var hasmap = new Dictionary<int,int>();
int count = 0;
foreach (int i in nums)
{
    if(hasmap.ContainsKey(i))
    {
        int val = hasmap[i];
        hasmap[i] = (int)val+1;
    }
    else
    {
        hasmap.Add(i,1);
    }
}
return hasmap.OrderByDescending(p => p.Value).Take(k).Select(propa=>propa.Key).ToArray();
    }
}
