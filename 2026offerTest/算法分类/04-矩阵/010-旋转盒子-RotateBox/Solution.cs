namespace _2026offerTest.算法分类._04_矩阵;

public class RotateBox
{
    public char[][] RotateTheBox(char[][] boxGrid) 
    {
        if (boxGrid == null || boxGrid.Length == 0)
        {
            return new char[0][];
        }
        
        int m = boxGrid.Length;
        int n = boxGrid[0].Length;
        
        // 第一步：先处理每一行的重力效果（石头向右掉落）
        for (int i = 0; i < m; i++)
        {
            int emptyPos = n - 1; // 记录最右边的空位
            for (int j = n - 1; j >= 0; j--)
            {
                if (boxGrid[i][j] == '*')
                {
                    // 遇到障碍物，更新空位为障碍物左边
                    emptyPos = j - 1;
                }
                else if (boxGrid[i][j] == '#')
                {
                    // 遇到石头，移动到空位
                    if (j != emptyPos)
                    {
                        boxGrid[i][j] = '.';
                        boxGrid[i][emptyPos] = '#';
                    }
                    emptyPos--;
                }
            }
        }
        
        // 第二步：顺时针旋转90度
        char[][] res = new char[n][];
        for (int i = 0; i < n; i++)
        {
            res[i] = new char[m];
        }
        
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                // 顺时针旋转90度：(i, j) -> (j, m-1-i)
                res[j][m - 1 - i] = boxGrid[i][j];
            }
        }
        
        return res;
    }


}