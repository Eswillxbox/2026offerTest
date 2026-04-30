namespace _2026offerTest.算法分类._01_数组;

/// <summary>
/// 和为 K 的子数组
/// 难度: 中等
/// 标签: 数组, 前缀和, 哈希表
/// </summary>
public class SubarraySumK_Solution
{
    /// <summary>
    /// 统计连续子数组之和等于 k 的个数
    /// 时间复杂度: O(n)
    /// 空间复杂度: O(n)
    /// </summary>
    public int SubarraySum(int[] nums, int k)
    {
        if (nums == null || nums.Length == 0)
            return 0;

        // key: 前缀和, value: 该前缀和出现的次数
        Dictionary<int, int> prefixSumCount = new Dictionary<int, int>();
        prefixSumCount[0] = 1;  // 前缀和为 0 出现 1 次
        
        int sum = 0;    // 当前前缀和
        int count = 0;  // 满足条件的子数组个数
        
        foreach (int num in nums)
        {
            sum += num;
            
            // 如果存在前缀和为 (sum - k)，说明存在子数组和为 k
            if (prefixSumCount.ContainsKey(sum - k))
                count += prefixSumCount[sum - k];
            
            // 更新当前前缀和的出现次数
            if (prefixSumCount.ContainsKey(sum))
                prefixSumCount[sum]++;
            else
                prefixSumCount[sum] = 1;
        }
        
        return count;
    }
}
