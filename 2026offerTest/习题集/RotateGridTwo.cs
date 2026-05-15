namespace _2026offerTest.习题集;

public class RotateGridTwo
{
    public int[][] RotateGrid(int[][] grid, int k) 
    {
        int m = grid.Length;
        int n = grid[0].Length;
        
        // 处理每一层
        int layers = Math.Min(m / 2, n / 2);
        
        for (int layer = 0; layer < layers; layer++)
        {
            RotateLayer(grid, layer, m, n, k);
        }
        
        return grid;
    }
    
    private void RotateLayer(int[][] grid, int layer, int m, int n, int k)
    {
        // 计算当前层的边界
        int top = layer;
        int bottom = m - 1 - layer;
        int left = layer;
        int right = n - 1 - layer;
        
        // 提取当前层的所有元素（按逆时针顺序）
        List<int> elements = new List<int>();
        
        // 上边：从左到右
        for (int j = left; j <= right; j++)
            elements.Add(grid[top][j]);
        
        // 右边：从上到下（不包括右上角）
        for (int i = top + 1; i <= bottom; i++)
            elements.Add(grid[i][right]);
        
        // 下边：从右到左（不包括右下角）
        for (int j = right - 1; j >= left; j--)
            elements.Add(grid[bottom][j]);
        
        // 左边：从下到上（不包括左下角和左上角）
        for (int i = bottom - 1; i > top; i--)
            elements.Add(grid[i][left]);
        
        // 计算实际需要旋转的次数（对当前层元素个数取模）
        int count = elements.Count;
        if (count == 0) return;
        
        int rotate = k % count;
        
        // 逆时针旋转 k 次 = 向左移动 rotate 个位置
        // 新位置 i 的元素来自原位置 (i + rotate) % count
        List<int> rotated = new List<int>(elements);
        for (int i = 0; i < count; i++)
        {
            rotated[i] = elements[(i + rotate) % count];
        }
        
        // 将旋转后的元素放回矩阵
        int idx = 0;
        
        // 上边：从左到右
        for (int j = left; j <= right; j++)
            grid[top][j] = rotated[idx++];
        
        // 右边：从上到下
        for (int i = top + 1; i <= bottom; i++)
            grid[i][right] = rotated[idx++];
        
        // 下边：从右到左
        for (int j = right - 1; j >= left; j--)
            grid[bottom][j] = rotated[idx++];
        
        // 左边：从下到上
        for (int i = bottom - 1; i > top; i--)
            grid[i][left] = rotated[idx++];
    }
}