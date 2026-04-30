namespace _2026offerTest.算法分类._01_数组;

/// <summary>
/// 下一个排列
/// 难度: 中等
/// 标签: 数组, 双指针
/// </summary>
public class NextPermutation_Solution
{
    /// <summary>
    /// 找到数组的下一个字典序排列
    /// 时间复杂度: O(n)
    /// 空间复杂度: O(1)
    /// </summary>
    public void NextPermutation(int[] nums)
    {
        if (nums == null || nums.Length <= 1)
            return;

        int n = nums.Length;
        int i = n - 2;

        // 步骤1: 从右往左找到第一个 nums[i] < nums[i+1] 的位置
        while (i >= 0 && nums[i] >= nums[i + 1])
        {
            i--;
        }

        // 步骤2: 如果找到了这样的位置
        if (i >= 0)
        {
            // 从右往左找到第一个大于 nums[i] 的元素
            int j = n - 1;
            while (j >= 0 && nums[j] <= nums[i])
            {
                j--;
            }
            Swap(nums, i, j);
        }

        // 步骤3: 反转 i+1 到末尾的部分
        Reverse(nums, i + 1, n - 1);
    }

    private void Swap(int[] nums, int i, int j)
    {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }

    private void Reverse(int[] nums, int left, int right)
    {
        while (left < right)
        {
            Swap(nums, left, right);
            left++;
            right--;
        }
    }
}
