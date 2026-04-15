namespace _2026offerTest.习题集;

public class Q3HowmanyknowSecret
{
    public int PeopleAwareOfSecret(int n, int delay, int forget) 
    {
        const int MOD = 1000000007;
    
        // 使用循环数组，大小为 forget+1
        long[] dp = new long[forget + 1];
        dp[1] = 1;
    
        long sharing = 0;
    
        for (int i = 2; i <= n; i++)
        {
            int idx = i % (forget + 1);
        
            // 添加可以开始分享的人
            if (i - delay >= 1)
            {
                int addIdx = (i - delay) % (forget + 1);
                sharing = (sharing + dp[addIdx]) % MOD;
            }
        
            // 移除已经忘记的人
            if (i - forget >= 1)
            {
                int removeIdx = (i - forget) % (forget + 1);
                sharing = (sharing - dp[removeIdx] + MOD) % MOD;
            }
        
            dp[idx] = sharing;
        }
    
        // 统计结果
        long result = 0;
        for (int j = System.Math.Max(1, n - forget + 1); j <= n; j++)
        {
            result = (result + dp[j % (forget + 1)]) % MOD;
        }
    
        return (int)result;
        
    }
}