namespace _2026offerTest.算法分类._04_矩阵;

/// <summary>
/// 搜索二维矩阵 II
/// 难度: 中等
/// 标签: 矩阵, 二分查找, 双指针
/// </summary>
public class Search2DMatrixII_Solution
{
    /// <summary>
    /// 在有序矩阵中搜索目标值
    /// 每行的元素从左到右升序排列
    /// 每列的元素从上到下升序排列
    /// 时间复杂度: O(m + n)
    /// 空间复杂度: O(1)
    /// </summary>
    public bool SearchMatrix(int[][] matrix, int target)
    {
        if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0)
            return false;

        int rows = matrix.Length;
        int cols = matrix[0].Length;
        
        // 从右上角开始搜索
        int row = 0;
        int col = cols - 1;

        while (row < rows && col >= 0)
        {
            if (matrix[row][col] == target)
                return true;
            else if (matrix[row][col] > target)
                col--;  // 当前值太大，向左移动
            else
                row++;  // 当前值太小，向下移动
        }

        return false;
    }
}
