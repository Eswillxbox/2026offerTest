namespace _2026offerTest.习题集;

public class FindMinSolution
{
    public int FindMin(int[] nums)
    {
        int left = 0, right = nums.Length - 1;

        while (left < right)
        {
            int mid = left + (right - left) / 2;
            if(nums[right] < nums[mid])
                left = mid+1;
            else
                right = mid;
        }
        return nums[left];
    }
    
}