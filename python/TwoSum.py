class Solution:

    def twoSum(nums, target):
        seen = {}
        for index, value in enumerate(nums):
            if target - value in seen:
                return [seen[target - value], index]
            else:
                seen[value] = index
                
