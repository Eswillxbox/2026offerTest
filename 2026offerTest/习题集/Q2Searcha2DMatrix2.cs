namespace _2026offerTest.习题集;

public class Q2Searcha2DMatrix2 
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
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
                col--; // 当前值太大，向左移动
            else
                row++; // 当前值太小，向下移动
        }

        return false;
    }
}