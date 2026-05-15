namespace _2026offerTest.习题集;

public class ClosedIslandSolution
{
    public int ClosedIsland(int[][] grid) 
    {
        if(grid.Length==0)return 0;
        int count = 0;
        DfSide(grid);
        for (int i = 1; i < grid.Length-1; i++)
        {
            for (int j = 1; j < grid[0].Length-1; j++)
            {
                if (grid[i][j] == 0)
                {
                    Dfs(grid, i, j);
                    count++;
                }
            }
        }
        return count;
    }
    
    public void DfSide(int[][] grid)
    {
        for (int n1 = 0; n1 < grid.Length; n1++)
        {
            int width = grid[n1].Length;
            if(grid[n1][0]==0)
                Dfs(grid, n1, 0);
            if (grid[n1][width - 1] == 0)
                Dfs(grid, n1, width-1);
        }

        for (int n2 = 1; n2 < grid[0].Length-1; n2++)
        {
            int hight = grid.Length;
            if (grid[0][n2] == 0)
                Dfs(grid, 0, n2);
            if (grid[hight-1][n2] == 0)
                Dfs(grid, hight-1, n2);
        }
    }
    
    public void Dfs(int[][] grid, int i, int j)
    {
        if (i < 0 || i >= grid.Length || j < 0 || j >= grid[0].Length || grid[i][j] != 0)
        {
            return;
        }
        grid[i][j] = 1;
        Dfs(grid, i - 1, j);
        Dfs(grid, i + 1, j);
        Dfs(grid, i, j - 1);
        Dfs(grid, i, j + 1);
    }
}