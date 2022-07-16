class Solution:
    def plusOne(self, digits: List[int]) -> List[int]:
        
        digits[len(digits) - 1] = (digits[len(digits) - 1] + 1) % 10
        if digits[len(digits) - 1] == 0:
            carry = 1
        else:
            carry = 0
            return digits
        
        
        for i in range(len(digits) - 2, -1, -1):
            
            digits[i] = (digits[i] + carry) % 10
            if digits[i] == 0:
                carry = 1
            else: 
                carry = 0
                break
            
            
        if carry == 1:
            digits = [1] + digits
            
        return digits
