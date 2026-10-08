public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int count = 0;
var set = new HashSet<char>();
int index = 0;
for (int i = 0; i < s.Length; i++)
{
    while (set.Contains(s[i]))
    {
        set.Remove(s[index]);
        index++;
    }
    set.Add(s[i]);
    count = Math.Max(count, i - index + 1);
}
return count;
    }
}
