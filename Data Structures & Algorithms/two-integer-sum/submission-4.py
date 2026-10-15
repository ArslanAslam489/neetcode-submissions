class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        collection={}
        for i,v in enumerate( nums):
            remaining = target - v
            if(remaining in collection):
                return [collection.get(remaining), i]
            else:
                collection[v] = i