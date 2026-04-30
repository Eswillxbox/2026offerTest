namespace _2026offerTest.习题集;

public class Q2SumKsRootArrange
{
    public int SubarraySum(int[] nums, int k)
    {
        if (nums == null || nums.Length == 0)
            return 0;

        Dictionary<int, int> prefixSumCount = new Dictionary<int, int>();
        prefixSumCount[0] = 1;
        
        int sum = 0;
        int count = 0;
        
        foreach (int num in nums)
        {
            sum += num;
            //因为sum按顺序累加，所以查找sum - k得到的子数组和一定是连续的数组和
            if (prefixSumCount.ContainsKey(sum - k))
                count += prefixSumCount[sum - k];
            
            if (prefixSumCount.ContainsKey(sum))
                prefixSumCount[sum]++;
            else
                prefixSumCount[sum] = 1;
        }
        
        return count;
    }
}
