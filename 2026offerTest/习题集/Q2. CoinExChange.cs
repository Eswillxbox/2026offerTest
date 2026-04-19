namespace _2026offerTest.习题集;

public class Q2__CoinExChange
{
    public int CoinChange(int[] coins, int amount)
    {
        int[] dp = new int[amount+1];
        for(int item=0; item<=amount; item++)
           dp[item] = int.MaxValue;
        dp[0] = 0;
        for(int i=0; i<coins.Length; i++)
        {
            for(int j=coins[i]; j<=amount; j++)
            {
                if(dp[j-coins[i]] != int.MaxValue)
                {
                    //dp[j-coins[i]]代表大小为j的金额扣除一次coins[i]后最少用硬币数
                    dp[j] = Math.Min(dp[j], dp[j-coins[i]]+1);
                }
            }
        }
        return dp[amount] == int.MaxValue ? -1 : dp[amount];
    }
}