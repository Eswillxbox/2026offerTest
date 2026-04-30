namespace _2026offerTest.算法分类._03_动态规划;

/// <summary>
/// 知道秘密的人数
/// 难度: 中等
/// 标签: 动态规划, 滑动窗口
/// </summary>
public class PeopleAwareOfSecret_Solution
{
    private const int MOD = 1000000007;

    /// <summary>
    /// 计算在第 n 天结束时，知道秘密的人数
    /// 时间复杂度: O(n)
    /// 空间复杂度: O(forget)
    /// </summary>
    public int PeopleAwareOfSecret(int n, int delay, int forget)
    {
        // dp[i] 表示第 i 天新知道秘密的人数
        long[] dp = new long[n + 1];
        dp[1] = 1;  // 第 1 天有 1 个人知道秘密

        long sharing = 0;  // 当前可以分享秘密的人数

        for (int i = 2; i <= n; i++)
        {
            // 第 i-delay 天知道的人在第 i 天开始可以分享
            if (i - delay >= 1)
            {
                sharing = (sharing + dp[i - delay]) % MOD;
            }

            // 第 i-forget 天知道的人在第 i 天会忘记
            if (i - forget >= 1)
            {
                sharing = (sharing - dp[i - forget] + MOD) % MOD;
            }

            dp[i] = sharing;
        }

        // 统计第 n 天时还知道秘密的人数
        long result = 0;
        for (int i = Math.Max(1, n - forget + 1); i <= n; i++)
        {
            result = (result + dp[i]) % MOD;
        }

        return (int)result;
    }
}
