namespace _2026offerTest.习题集;

public class MinMovesSolution_
{
    public int MinMoves(int[] nums, int limit)
    {
        int n = nums.Length;
        // 每个 pair 默认需要 2 次操作，用差分数组记录修正量
        // 实际代价 = 2*(n/2) + prefixSum(diff[2..s])
        int[] diff = new int[2 * limit + 2];

        for (int i = 0; i < n / 2; i++)
        {
            int a = nums[i], b = nums[n - 1 - i];
            int low = Math.Min(a, b);
            int high = Math.Max(a, b);
            int sum = a + b;

            // [low+1, high+limit] : 从 2-op 降为 1-op（减 1）
            diff[low + 1]--;
            diff[high + limit + 1]++;

            // s == sum : 再降为 0-op（再减 1）
            diff[sum]--;
            diff[sum + 1]++;
        }

        int ans = int.MaxValue;
        int current = 0;
        for (int s = 2; s <= 2 * limit; s++)
        {
            current += diff[s];
            int moves = 2 * (n / 2) + current;
            if (moves < ans) ans = moves;
        }

        return ans;
    }
}