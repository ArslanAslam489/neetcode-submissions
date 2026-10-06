public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var map = new Dictionary<string, List<string>>();

foreach (var str in strs)
{
   var chars= str.ToCharArray();
    Array.Sort(chars);
    var key = new string(chars);

    if(!map.ContainsKey(key))
    {
        map.Add(key, new List<string>() { str});
    }
    else
        map[key].Add(str);
    

}
return map.Values.ToList<List<string>>();
    }
}
