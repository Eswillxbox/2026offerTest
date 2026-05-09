namespace _2026offerTest.算法分类._01_数组;

public class Q3FirstMissingPositive
{
    public int FirstMissingPositive(int[] nums) 
    {
        int len = nums.Length;

        // 将每个正整数放到它应该在的位置上
        // 即：数字 1 放在索引 0，数字 2 放在索引 1，以此类推
        for (int i = 0; i < len; i++)
        {
            // 当 nums[i] 在有效范围内 [1, len]，且不在正确位置上时，进行交换
            while (nums[i] > 0 && nums[i] <= len && nums[i] != nums[nums[i] - 1])
            {
                // 将 nums[i] 放到它应该在的位置 nums[i] - 1
                int correctPos = nums[i] - 1;
                (nums[correctPos], nums[i]) = (nums[i], nums[correctPos]);
            }
        }

        // 找到第一个不在正确位置上的数字
        for (int i = 0; i < len; i++)
        {
            if (nums[i] != i + 1)
                return i + 1;
        }

        // 如果所有位置都正确，说明缺失的是 len + 1
        return len + 1;
    }
}