# remove-nth-node-from-end-of-list
**Solution**
```
ListNode RemoveNthFromEnd(ListNode head, int n)
{
    int count = 1;
    var flatList = new List<int>();
    void Flat(ListNode node)
    {
        flatList.Add(node.val);
        if (node.next != null)
            Flat(node.next);
    }
    Flat(head);

    flatList.RemoveAt(flatList.Count - n);
    if (flatList.Count == 0) return null;
    var result = new ListNode();
    result.val = flatList[0];
    flatList.RemoveAt(0);
    void Generate(ListNode node, List<int> l)
    {
        if (l.Count == 0) return;
        node.next = new ListNode(l[0]);
        l.RemoveAt(0);
        Generate(node.next, l);
    }
    
    Generate(result, flatList);
    return result;
}
```