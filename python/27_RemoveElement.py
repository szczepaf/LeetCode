class Solution:

    def removeElement(self, nums, val: int) -> int:
        countOfDuplicity = 0
        length = len(nums)
        for i in range(length):
            if nums[i] == val:
                countOfDuplicity += 1
            else:
                nums[i - countOfDuplicity] = nums[i]
        return length - countOfDuplicity
