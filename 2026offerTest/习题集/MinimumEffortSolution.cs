namespace _2026offerTest.习题集;

public class MinimumEffortSolution
{
    public int MinimumEffort(int[][] tasks)
    {
        // 按 minimum - actual 降序排序
        Array.Sort(tasks, (a, b) => 
            (b[1] - b[0]).CompareTo(a[1] - a[0]));
        
        int energy = 0;
        // 当前消耗的能量
        int current = 0;
        
        foreach (var task in tasks)
        {
            int actual = task[0];
            int minimum = task[1];

            // 当前能量不足以开始任务，需要补充能量
            if (current < minimum)
            {
                // 补充到最低要求的能量
                energy += minimum - current;
                // 执行任务后剩余的能量
                current = minimum - actual;
            }
            // 当前能量足够，直接执行任务
            else
            {
                current -= actual;
            }
        }
        
        return energy;
    }
}