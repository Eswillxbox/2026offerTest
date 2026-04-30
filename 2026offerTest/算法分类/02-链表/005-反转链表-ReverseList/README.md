# 005. 反转链表 (Reverse Linked List)

**难度**: 简单  
**标签**: 链表, 双指针

---

## 📝 题目描述

给你单链表的头节点 `head`，请你反转链表，并返回反转后的链表。

---

## 💡 示例

### 示例 1
```
输入: head = [1,2,3,4,5]
输出: [5,4,3,2,1]
```

### 示例 2
```
输入: head = [1,2]
输出: [2,1]
```

### 示例 3
```
输入: head = []
输出: []
```

---

## 🎯 解题思路

**核心思想**: 迭代法 - 逐个反转指针方向

**步骤**:
1. 初始化 `prev = null`, `curr = head`
2. 遍历链表，在每次迭代中:
   - 保存下一个节点 `nextTemp = curr.next`
   - 反转当前节点的指针 `curr.next = prev`
   - 移动 `prev` 和 `curr` 指针
3. 返回 `prev`（新的头节点）

---

## 📊 复杂度分析

- **时间复杂度**: O(n) - 遍历链表一次
- **空间复杂度**: O(1) - 只使用常数额外空间

---

## 🔑 关键点

- 需要先保存下一个节点，避免断链
- 注意处理空链表和只有一个节点的情况
- 也可以使用递归方法实现

---

## 🔄 递归解法

```csharp
public ListNode ReverseList(ListNode head)
{
    if (head == null || head.next == null)
        return head;
    
    ListNode newHead = ReverseList(head.next);
    head.next.next = head;
    head.next = null;
    
    return newHead;
}
```

---

## 📚 相关题目

- K 个一组翻转链表
- 反转链表 II
- 回文链表
