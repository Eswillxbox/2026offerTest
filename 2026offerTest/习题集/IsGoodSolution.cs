namespace _2026offerTest.习题集;

public class IsGoodSolution
{
    public bool IsGood(int[] nums)
    {
        int n = 0;
        HashSet<int> s = new HashSet<int>();

        foreach (var num in nums)
        {
            n = Math.Max(n, num);
        }
        foreach (var num in nums)
        {
            if (!s.Contains(num))
                s.Add(num);
            else if(num<n)
                return false;
        }
        
        return n+1 == nums.Length&&s.Count==n;
    }
}