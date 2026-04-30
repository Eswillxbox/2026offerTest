namespace _2026offerTest.算法分类._01_数组;

/// <summary>
/// 二分查找
/// 难度: 简单
/// 标签: 数组, 二分查找
/// </summary>
public class BinarySearch_Solution
{
    /// <summary>
    /// 在有序数组中搜索目标值
    /// 时间复杂度: O(log n)
    /// 空间复杂度: O(1)
    /// </summary>
    public int Search(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;
        
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            
            if (nums[mid] == target)
                return mid;
            else if (nums[mid] > target)
                right = mid - 1;
            else
                left = mid + 1;
        }
        
        return -1;
    }
}
