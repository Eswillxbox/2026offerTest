using _2026offerTest.算法分类._01_数组;
using _2026offerTest.算法分类._02_链表;
using _2026offerTest.算法分类._03_动态规划;
using _2026offerTest.算法分类._04_矩阵;
using _2026offerTest.算法分类._05_树;
using _2026offerTest.算法分类._06_回溯;
using _2026offerTest.算法分类._07_图_搜索;

namespace _2026offerTest;

/// <summary>
/// 算法题演示入口
/// 可以选择性地运行某道题的测试用例
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== 算法题学习演示 ===\n");

        // 示例：运行二分查找
        TestBinarySearch();
        
        // 示例：运行移动零
        TestMoveZero();
        
        // 取消注释以测试其他题目
        // TestSubarraySumK();
        // TestNextPermutation();
        // TestReverseList();
        // TestCoinChange();
        // TestPeopleAwareOfSecret();
        // TestSearch2DMatrixII();
        
        Console.WriteLine("\n=== 演示结束 ===");
    }

    static void TestBinarySearch()
    {
        Console.WriteLine("【001】二分查找");
        var solution = new BinarySearch_Solution();
        
        int[] nums1 = { -1, 0, 3, 5, 9, 12 };
        int target1 = 9;
        int result1 = solution.Search(nums1, target1);
        Console.WriteLine($"数组: [{string.Join(", ", nums1)}], 目标: {target1}");
        Console.WriteLine($"结果: {result1} (期望: 4)\n");
        
        int target2 = 2;
        int result2 = solution.Search(nums1, target2);
        Console.WriteLine($"数组: [{string.Join(", ", nums1)}], 目标: {target2}");
        Console.WriteLine($"结果: {result2} (期望: -1)\n");
    }

    static void TestMoveZero()
    {
        Console.WriteLine("【002】移动零");
        var solution = new MoveZero_Solution();
        
        int[] nums = { 0, 1, 0, 3, 12 };
        Console.WriteLine($"原数组: [{string.Join(", ", nums)}]");
        solution.MoveZeroes(nums);
        Console.WriteLine($"结果:   [{string.Join(", ", nums)}] (期望: [1, 3, 12, 0, 0])\n");
    }

    static void TestSubarraySumK()
    {
        Console.WriteLine("【003】和为K的子数组");
        var solution = new SubarraySumK_Solution();
        
        int[] nums = { 1, 1, 1 };
        int k = 2;
        int result = solution.SubarraySum(nums, k);
        Console.WriteLine($"数组: [{string.Join(", ", nums)}], K: {k}");
        Console.WriteLine($"结果: {result} (期望: 2)\n");
    }

    static void TestNextPermutation()
    {
        Console.WriteLine("【004】下一个排列");
        var solution = new NextPermutation_Solution();
        
        int[] nums = { 1, 2, 3 };
        Console.WriteLine($"原数组: [{string.Join(", ", nums)}]");
        solution.NextPermutation(nums);
        Console.WriteLine($"结果:   [{string.Join(", ", nums)}] (期望: [1, 3, 2])\n");
    }

    static void TestReverseList()
    {
        Console.WriteLine("【005】反转链表");
        var solution = new ReverseList_Solution();
        
        // 创建链表 1->2->3->4->5
        ListNode head = new ListNode(1, 
            new ListNode(2, 
                new ListNode(3, 
                    new ListNode(4, 
                        new ListNode(5)))));
        
        Console.Write("原链表: ");
        PrintList(head);
        
        ListNode reversed = solution.ReverseList(head);
        Console.Write("反转后: ");
        PrintList(reversed);
        Console.WriteLine("(期望: 5->4->3->2->1)\n");
    }

    static void PrintList(ListNode head)
    {
        List<int> values = new List<int>();
        ListNode curr = head;
        while (curr != null)
        {
            values.Add(curr.val);
            curr = curr.next;
        }
        Console.WriteLine(string.Join("->", values));
    }

    static void TestCoinChange()
    {
        Console.WriteLine("【006】零钱兑换");
        var solution = new CoinChange_Solution();
        
        int[] coins = { 1, 2, 5 };
        int amount = 11;
        int result = solution.CoinChange(coins, amount);
        Console.WriteLine($"硬币: [{string.Join(", ", coins)}], 金额: {amount}");
        Console.WriteLine($"结果: {result} (期望: 3)\n");
    }

    static void TestPeopleAwareOfSecret()
    {
        Console.WriteLine("【007】知道密码的人数");
        var solution = new PeopleAwareOfSecret_Solution();
        
        int n = 6, delay = 2, forget = 4;
        int result = solution.PeopleAwareOfSecret(n, delay, forget);
        Console.WriteLine($"天数: {n}, 延迟: {delay}, 忘记: {forget}");
        Console.WriteLine($"结果: {result} (期望: 5)\n");
    }

    static void TestSearch2DMatrixII()
    {
        Console.WriteLine("【008】搜索二维矩阵II");
        var solution = new Search2DMatrixII_Solution();
        
        int[][] matrix = new int[][]
        {
            new int[] { 1, 4, 7, 11, 15 },
            new int[] { 2, 5, 8, 12, 19 },
            new int[] { 3, 6, 9, 16, 22 },
            new int[] { 10, 13, 14, 17, 24 },
            new int[] { 18, 21, 23, 26, 30 }
        };
        
        int target1 = 5;
        bool result1 = solution.SearchMatrix(matrix, target1);
        Console.WriteLine($"目标: {target1}, 结果: {result1} (期望: True)");
        
        int target2 = 20;
        bool result2 = solution.SearchMatrix(matrix, target2);
        Console.WriteLine($"目标: {target2}, 结果: {result2} (期望: False)\n");
    }
}