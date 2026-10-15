class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
         collection ={}
         for  v in (strs):
            sortedkey = "".join(sorted(v))
            if sortedkey in collection:
                collection[sortedkey].append(v)
            else:
                collection[sortedkey] = [v]

         return list(collection.values())