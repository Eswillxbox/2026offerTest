namespace _2026offerTest.算法分类._03_动态规划;

/// <summary>
/// 零钱兑换
/// 难度: 中等
/// 标签: 动态规划, 背包问题
/// </summary>
public class CoinChange_Solution
{
    /// <summary>
    /// 计算凑成总金额所需的最少硬币个数
    /// 时间复杂度: O(amount * coins.Length)
    /// 空间复杂度: O(amount)
    /// </summary>
    public int CoinChange(int[] coins, int amount)
    {
        if (amount == 0) return 0;
        
        // dp[i] 表示凑成金额 i 所需的最少硬币数
        int[] dp = new int[amount + 1];
        
        // 初始化为最大值（amount+1 代表不可能达到的值）
        for (int i = 1; i <= amount; i++)
            dp[i] = amount + 1;
        
        dp[0] = 0;  // 凑成金额 0 需要 0 个硬币
        
        // 遍历每个金额
        for (int i = 1; i <= amount; i++)
        {
            // 尝试每种硬币
            foreach (int coin in coins)
            {
                if (i >= coin)
                {
                    dp[i] = Math.Min(dp[i], dp[i - coin] + 1);
                }
            }
        }
        
        return dp[amount] > amount ? -1 : dp[amount];
    }
}
