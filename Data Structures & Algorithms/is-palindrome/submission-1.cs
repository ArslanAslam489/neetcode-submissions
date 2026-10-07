public class Solution {
    public bool IsPalindrome(string s)
{
     var ch = s.Trim(' ').ToLower().ToCharArray();
 var stack = new Stack<char>();
 StringBuilder stringBuilder = new StringBuilder();
 StringBuilder oriwithoutspace = new StringBuilder();

 foreach (char c in ch)
 {
    int index = c - 'a';
int digitIndex = c - '0';
if ((index<26 && index>=0) || (digitIndex >= 0 && digitIndex < 10))
{
    stack.Push(c);
    oriwithoutspace.Append(c);
}

 }

 foreach (var item in stack)
 {
     stringBuilder.Append(item);
 }

return stringBuilder.ToString() == oriwithoutspace.ToString();
}
}
