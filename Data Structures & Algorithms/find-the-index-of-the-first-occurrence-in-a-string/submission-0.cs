public class Solution {
   public int StrStr(string haystack, string needle)
{
  int i = 0; int inr = 0;

 while (i <= haystack.Length-needle.Length)
 {
     inr = 0;
     while (inr < needle.Length)
     {
         if (needle[inr] != haystack[i+inr])
             break;

         inr++; 
     }
     if (inr==needle.Length)
     {
         return i;
     }
     i++;
     
 }
 return -1; 
}
}