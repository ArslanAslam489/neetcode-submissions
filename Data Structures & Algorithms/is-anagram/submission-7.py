class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        chararr = [0] * 26
        if len(s)!=len(t):
            return False
        for i,char in enumerate(s):
           ch = s[i]
           #print(ch)
           sec_ch = t[i]
           #print(sec_ch)
           index = ord(ch)-ord('a')
           #print(index)
           chararr[index] = chararr[index]+1
           sec_index = ord(sec_ch) - ord('a')
           #print(sec_index)
           chararr[sec_index] = chararr[sec_index]-1

        #print(chararr)
        for i in chararr:
           if i!=0:
            return False

        return True
        