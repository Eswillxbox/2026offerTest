namespace _2026offerTest.算法分类._04_矩阵;

public class RotateImage
{
    public void Rotate(int[][] matrix) 
    {
        int n = matrix.Length;
        
        // 第一步：转置矩阵（沿主对角线翻转）
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                (matrix[i][j], matrix[j][i])=(matrix[j][i], matrix[i][j]);
            }
        }
        
        // 第二步：翻转每一行（左右翻转）
        for (int i = 0; i < n; i++)
        {
            int left = 0;
            int right = n - 1;
            while (left < right)
            {
                (matrix[i][left], matrix[i][right]) = (matrix[i][right], matrix[i][left]);
                left++;
                right--;
            }
        }
    }
}
