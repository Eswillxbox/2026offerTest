namespace _2026offerTest.习题集;

public class Q1LengthOfLIS
{
    public int LengthOfLIS(int[] nums)
    {
        if (nums == null) return 0;

        List<int> tails = new List<int>();
        
        foreach(int num in nums)
        {
            int left = 0, right = tails.Count;
            while (left < right)
            {
                int mid = (left + right) / 2;
                if (tails[mid] < num)
                    left = mid + 1;
                else
                    right = mid;
            }
            if(left == tails.Count)
                tails.Add(num);
            else
                tails[left] = num;
        }
        return tails.Count;
    }
}