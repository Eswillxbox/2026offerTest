namespace _2026offerTest.算法分类._01_数组;

/// <summary>
/// 移动零
/// 难度: 简单
/// 标签: 数组, 双指针
/// </summary>
public class MoveZero_Solution
{
    /// <summary>
    /// 将数组中的所有 0 移动到末尾，保持非零元素的相对顺序
    /// 时间复杂度: O(n)
    /// 空间复杂度: O(1)
    /// </summary>
    public void MoveZeroes(int[] nums)
    {
        if (nums == null || nums.Length <= 1)
            return;

        // 双指针法：slow 指向下一个非零元素应该放置的位置
        int slow = 0;
        
        // fast 遍历数组，遇到非零元素就放到 slow 位置
        for (int fast = 0; fast < nums.Length; fast++)
        {
            if (nums[fast] != 0)
            {
                nums[slow] = nums[fast];
                slow++;
            }
        }
        
        // 将剩余位置填充为 0
        for (int i = slow; i < nums.Length; i++)
        {
            nums[i] = 0;
        }
    }
}
