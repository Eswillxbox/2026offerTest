namespace _2026offerTest.习题集;

public class Q1IsValid
{
    public bool IsValid(string s)
    {
        if (string.IsNullOrEmpty(s) || s.Length % 2 == 1)
            return false;

        Dictionary<char, char> pair = new Dictionary<char, char>
        {
            [')'] = '(',
            [']'] = '[',
            ['}'] = '{'
        };

        Stack<char> stack = new();

        foreach (char c in s)
        {
            if (c == '(' || c == '[' || c == '{')
            {
                stack.Push(c);
            }
            else
            {
                if (stack.Count == 0 || stack.Pop() != pair[c])
                    return false;
            }
        }
        return stack.Count == 0;
    }
}