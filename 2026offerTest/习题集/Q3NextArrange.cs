namespace _2026offerTest.习题集;

public class Q3NextArrange
{
    public void NextPermutation(int[] nums)
    {
        if (nums == null || nums.Length <= 1)
            return;

        int n = nums.Length;
        int i = n - 2;

        while (i >= 0 && nums[i] >= nums[i + 1])
        {
            i--;
        }

        if (i >= 0)
        {
            int j = n - 1;
            while (j >= 0 && nums[j] <= nums[i])
            {
                j--;
            }
            Swap(nums, i, j);
        }

        Reverse(nums, i + 1, n - 1);
    }

    private void Swap(int[] nums, int i, int j)
    {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }

    private void Reverse(int[] nums, int left, int right)
    {
        while (left < right)
        {
            Swap(nums, left, right);
            left++;
            right--;
        }
    }
}
