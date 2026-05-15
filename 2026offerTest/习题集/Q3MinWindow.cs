namespace _2026offerTest.习题集;

public class Q3MinWindow
{
    public string MinWindow(string s, string t)
    {
        if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t) || s.Length < t.Length)
            return "";

        // 记录 t 中每个字符的需求量
        int[] need = new int[128];  // ASCII 字符集
        int required = 0;

        foreach (char c in t)
        {
            if (need[c] == 0) required++;
            need[c]++;
        }

        // 滑动窗口
        int[] window = new int[128];
        int formed = 0;
        int left = 0, right = 0;
        int ansLength = int.MaxValue;
        int ansLeft = 0;

        while (right < s.Length)
        {
            char c = s[right];
            window[c]++;

            // 如果当前字符在 t 中，且数量刚好满足需求
            if (need[c] > 0 && window[c] == need[c])
            {
                formed++;
            }

            // 尝试收缩窗口
            while (left <= right && formed == required)
            {
                c = s[left];

                // 更新最优解
                if (right - left + 1 < ansLength)
                {
                    ansLength = right - left + 1;
                    ansLeft = left;
                }

                // 收缩左边界
                window[c]--;
                if (need[c] > 0 && window[c] < need[c])
                {
                    formed--;
                }

                left++;
            }

            right++;
        }

        return ansLength == int.MaxValue ? "" : s.Substring(ansLeft, ansLength);
    }
}
