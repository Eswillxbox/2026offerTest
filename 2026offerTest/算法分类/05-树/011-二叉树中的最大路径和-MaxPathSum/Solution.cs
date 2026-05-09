namespace _2026offerTest.算法分类._05_树;

public class Q3TreePathSum
{
    int maxSum=int.MinValue;
    public int MaxPathSum(TreeNode root) 
    {
        
        if (root == null) return 0;
        
        maxSum = int.MinValue;  // 初始化
        MaxGain(root);          // 递归计算
        return maxSum;          // 返回全局最大值
    }
    
    private int MaxGain(TreeNode node)
    {
        if (node == null) return 0;
    
        // 递归获取左右子树的最大贡献（如果为负则取0，表示不选择）
        int leftGain = Math.Max(MaxGain(node.left), 0);
        int rightGain = Math.Max(MaxGain(node.right), 0);
    
        // 情况1：以当前节点为最高点的路径（可以左右都选）
        int currentPath = node.val + leftGain + rightGain;
        maxSum = Math.Max(maxSum, currentPath);  // 更新全局最大值
    
        // 情况2：返回给父节点的贡献（只能选一边）
        return node.val + Math.Max(leftGain, rightGain);
    }

}