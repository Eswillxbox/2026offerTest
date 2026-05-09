namespace _2026offerTest.算法分类._06_回溯;

public class Q2Parenthesis
{
    /// <summary>
    /// 生成所有可能的有效括号组合 - 回溯法实现
    /// </summary>
    /// <param name="n">括号对数</param>
    /// <returns>所有有效的括号组合列表</returns>
    public IList<string> GenerateParenthesis(int n) 
    {
        IList<string> result = new List<string>();
        if (n <= 0) return result;
        
        Backtrack(result, "", 0, 0, n);
        return result;
    }
    
    /// <summary>
    /// 回溯函数，递归生成有效括号组合
    /// </summary>
    /// <param name="result">结果列表</param>
    /// <param name="current">当前构建的字符串</param>
    /// <param name="open">已使用的左括号数量</param>
    /// <param name="close">已使用的右括号数量</param>
    /// <param name="max">最大括号对数</param>
    private void Backtrack(IList<string> result, string current, int open, int close, int max)
    {
        // 如果当前字符串长度达到目标长度，添加到结果中
        if (current.Length == max * 2)
        {
            result.Add(current);
            return;
        }
        
        // 如果左括号数量小于最大值，可以添加左括号
        if (open < max)
        {
            Backtrack(result, current + "(", open + 1, close, max);
        }
        
        // 如果右括号数量小于左括号数量，可以添加右括号（保证有效性）
        if (close < open)
        {
            Backtrack(result, current + ")", open, close + 1, max);
        }
    }
}