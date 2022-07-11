# reverse-nodes-in-k-group
**Solution**
```
ListNode ReverseKGroup(ListNode head, int k)
{
    var flat = new List<int>();

    void generateFlatList(ListNode n)
    {
        if (n == null) return;
        flat.Add(n.val);
        generateFlatList(n.next);
    }
    generateFlatList(head);

    if (flat.Count == 0) return null;
    var reverseList = new List<int>();
    for (int i = 0; i < flat.Count && i + k - 1 < flat.Count; i+=k)
    {
        var temp = flat.GetRange(i, k);
        temp.Reverse();
        reverseList.AddRange(temp);
    }

    for (int i = ((flat.Count / k) * k); i < flat.Count; i++)
    {
        reverseList.Add(flat[i]);
    }
    var result = new ListNode(reverseList[0]);
    reverseList.RemoveAt(0);
    void generateListNodeFromFlatList(List<int> l, ListNode n)
    {
        if (l.Count == 0) return;
        n.next = new ListNode(l[0]);
        l.RemoveAt(0);
        generateListNodeFromFlatList(l, n.next);
    }
    generateListNodeFromFlatList(reverseList, result);

    return result;
}
```