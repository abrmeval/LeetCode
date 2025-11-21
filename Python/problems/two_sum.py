class Solution(object):
    def twoSum(self, nums, target):
        """
        :type nums: List[int]
        :type target: int
        :rtype: List[int]
        """
        seen = {}  # value -> index
        for i, num in enumerate(nums):
            complement = target - num
            if complement in seen:
                return [seen[complement], i]
            seen[num] = i
        return []


def two_sum(nums: list[int], target: int) -> list[int]:
    seen: dict[int, int] = {}
    
    for i, v in enumerate(nums):
        if (target - v) in seen:
            return [seen[target - v], i]
        seen[v] = i
    return []

print("Two Sum Problem Implementation")
result = twoSum([2, 7, 11, 15], 9)
print("Indices of numbers that add up to target:", result)