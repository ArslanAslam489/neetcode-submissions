public class Solution {
    public bool IsAnagram(string s, string t) 
    {
        if(s == null || t == null) return false;
 if(s.Length == 0)  return false;
  if (t.Length == 0) return false;
  if(s.Length !=t.Length) return false;

  int[] ints = new int[26];
  for(int i = 0; i < s.Length; i++)
  {
      char letter = s[i];
      char letter1 = t[i];
      int index =    letter - 'a';
      ints[index] = ints[index] + 1;

      int index2 = letter1 - 'a';
      ints[index2] = ints[index2] - 1;

  }

  for (int i = 0; i < ints.Length; i++)
  {
      if (ints[i] != 0) return false;

  }
  return true;
    }
}
