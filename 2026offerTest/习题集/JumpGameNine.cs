namespace _2026offerTest.习题集;

public class JumpGameNine
{
    public int[] MaxValue(int[] nums)
    {
       int n = nums.Length;
       
       int[] preMax = new int[n];
       int curMax = int.MinValue;
       for(int i=0; i<n; i++)
       {
           curMax = Math.Max(curMax, nums[i]);
           preMax[i] = curMax;
       }
       
       int[] sufMin = new int[n];
       int curMin = int.MaxValue;
       for(int i=n-1; i>=0; i--)
       {
           curMin = Math.Min(curMin, nums[i]);
           sufMin[i] = curMin;
       }
       
       int[] res = new int[n];
       int start = 0;
       for(int i=0; i<n; i++)
       {
           if (i == n - 1 || preMax[i] <= sufMin[i + 1])
           {
               int blockMax = preMax[i];
               for(int j=start; j<=i; j++)
                   res[j] = blockMax;
               start = i + 1;
           }
       }
       return res;
    }
}
