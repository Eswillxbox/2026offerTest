namespace _2026offerTest.习题集;

public class Q3IslandNum
{
    public int NumIslands(char[][] grid)
    {
        int count = 0;
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == '1')
                {
                    Dfs(grid, i, j);
                    count++;
                }
            }
        }
        return count;
    }

    public void Dfs(char[][] grid, int i, int j)
    {
        if (i < 0 || i >= grid.Length || j < 0 || j >= grid[0].Length || grid[i][j] != '1')
        {
            return;
        }
        grid[i][j] = '0';
        Dfs(grid, i - 1, j);
        Dfs(grid, i + 1, j);
        Dfs(grid, i, j - 1);
        Dfs(grid, i, j + 1);
    }
}