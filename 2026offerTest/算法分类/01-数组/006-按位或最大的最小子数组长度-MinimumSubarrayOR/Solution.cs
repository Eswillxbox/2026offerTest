namespace _2026offerTest.算法分类._01_数组;

public class Subarrays
{
    public int[] SmallestSubarrays(int[] nums)
    {
        int n = nums.Length;
        int[] res = new int[n];
        
        // lastPos[bit] 记录第 bit 位最近一次出现的位置
        int[] lastPos = new int[32];
        for (int i = 0; i < 32; i++)
        {
            lastPos[i] = -1;
        }
        
        // 从后往前遍历
        for (int i = n - 1; i >= 0; i--)
        {
            // 更新当前数字所有比特位的最后出现位置
            for (int bit = 0; bit < 32; bit++)
            {
                if ((nums[i] & (1 << bit)) != 0)
                {
                    lastPos[bit] = i;
                }
            }
            
            // 找到所有已设置比特位中最远的位置
            int maxPos = i;
            for (int bit = 0; bit < 32; bit++)
            {
                if (lastPos[bit] != -1)
                {
                    maxPos = Math.Max(maxPos, lastPos[bit]);
                }
            }
            
            res[i] = maxPos - i + 1;
        }
        
        return res;
    }
}
