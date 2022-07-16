class Solution:
    def lengthOfLastWord(self, s: str) -> int:
        count = 0
        start = len(s) - 1
        for j in range(len(s) - 1, -1, -1):
            if s[j] == ' ':
                start -= 1
            else:
                break
            
        for i in range(start, -1, -1):
            if s[i] != ' ':
                count += 1
            else:
                break
                
        return count
            
