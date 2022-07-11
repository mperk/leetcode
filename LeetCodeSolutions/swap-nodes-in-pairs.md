# swap-nodes-in-pairs
**Solution**
```
ListNode SwapPairs(ListNode head)
{
    var flat = new List<int>();

    void generateFlatListFromNode(ListNode n)
    {
        if(n == null) return;
        flat.Add(n.val);
        generateFlatListFromNode(n.next);
    }
    generateFlatListFromNode(head);
    if (flat.Count == 0) return null;
    for (int i = 0; i < flat.Count - 1; i+=2)
    {
        int swap = flat[i];
        flat[i] = flat[i + 1];
        flat[i + 1] = swap;
    }

    var result = new ListNode(flat[0]);
    flat.RemoveAt(0);
    void generateNodeFromFlatList(List<int> l, ListNode _result)
    {
        if (l.Count == 0) return;
        _result.next = new ListNode(l[0]);
        l.RemoveAt(0);
        generateNodeFromFlatList(l, _result.next);
    }
    generateNodeFromFlatList(flat, result);

    return result;
}
```