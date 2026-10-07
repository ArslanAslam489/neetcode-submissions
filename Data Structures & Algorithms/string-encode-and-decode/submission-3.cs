public class Solution {
char sep = '~';
      public string Encode(IList<string> strs)
{
    
    StringBuilder encodedstr = new StringBuilder();
    encodedstr.Append(strs.Count());
    encodedstr.Append(sep);
    for (int i = 0; i < strs.Count; i++) { 
        encodedstr.Append(strs[i]);
        if(i!=strs.Count-1)
            encodedstr.Append(sep);
    }
    return encodedstr.ToString();
}

public List<string> Decode(string s)
{
    var str = s.Split(sep);
    if (str[0] == "0") return [];
    return str.Skip(1).ToList();
}
}
