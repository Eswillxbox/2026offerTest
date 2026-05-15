namespace _2026offerTest.习题集;

public class SeparateDigitsSolution
{
    public int[] SeparateDigits(int[] nums)
    {
        if (nums == null || nums.Length == 0) return nums;

        // 预估总长度（每个数最多 6 位：10^5）
        int totalLen = 0;
        foreach (int num in nums)
            totalLen += num.ToString().Length;

        int[] result = new int[totalLen];
        int idx = 0;

        foreach (int num in nums)
        {
            string s = num.ToString();
            foreach (char c in s)
                result[idx++] = c - '0';
        }

        return result;
    }


}