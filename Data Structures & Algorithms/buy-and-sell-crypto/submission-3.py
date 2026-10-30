class Solution:
    def maxProfit(self, prices: List[int]) -> int:
        maxprofit = 0
        if not prices:
           return 0
        buy = prices[0]
        for i in prices:
            profit = 0
            if(i<buy):
                buy = i
            else:
                profit = i - buy
            if(profit > maxprofit):
                maxprofit = profit
        return maxprofit
        