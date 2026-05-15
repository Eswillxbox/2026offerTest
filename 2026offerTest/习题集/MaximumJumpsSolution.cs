namespace _2026offerTest.习题集;

public class MaximumJumpsSolution
{
    public int MaximumJumps(int[] nums, int target)
    {
        int n = nums.Length;
        if (n == 1) return 0;
        if(target == 0 && Math.Abs(nums[0] - nums[n-1]) != 0) return -1;
        
        int[] dp = new int[n];
        
        // 初始化为 -1，表示不可达
        for (int i = 1; i < n; i++)
            dp[i] = -1;
        
        // dp[0] = 0，起始位置 
        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (dp[j] != -1 && Math.Abs(nums[i] - nums[j]) <= target)
                {
                    dp[i] = Math.Max(dp[i], dp[j] + 1);
                }
            }
        }
        
        return dp[n - 1];

    }
}