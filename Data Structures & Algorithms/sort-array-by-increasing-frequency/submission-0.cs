public class Solution {
    public int[] FrequencySort(int[] nums) {
            Dictionary<int,int> collection = new Dictionary<int, int>();
    int[] results = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        if (!collection.ContainsKey(nums[i]))
        {
            collection.Add(nums[i], 1);
        }
        else
            collection[nums[i]]++;
    }

   var col = collection.OrderBy(x=>x.Value).ThenByDescending(x=>x.Key);
    int index = 0;

    foreach (var item in col)
    {
        int count = 0;
        while(count < item.Value)
        {
            results[index] = item.Key;
            count++;
            index++;
        }
    }
    return results;

   
}
    
}