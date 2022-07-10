# merge-two-sorted-lists
**Solution**
```
ListNode MergeTwoLists(ListNode list1, ListNode list2)
{
    var list = new List<int>();
    void generateFlatList(ListNode l1, ListNode l2)
    {
        if (l1 != null) list.Add(l1.val);
        if (l2 != null) list.Add(l2.val);
        if (l1 == null && l2 == null) return;
        generateFlatList(l1?.next, l2?.next);
    }
    generateFlatList(list1, list2);
    if (list.Count == 0) return null;
    list = list.OrderBy(x => x).ToList();
    var result = new ListNode(list[0]);
    list.RemoveAt(0);
    void generateNodeFromFlatList(List<int> flatList, ListNode _result)
    {
        if(flatList.Count == 0) return;
        _result.next = new ListNode(flatList[0]);
        flatList.RemoveAt(0);
        generateNodeFromFlatList(flatList, _result.next);
    }
    generateNodeFromFlatList(list, result);
    return result;
}
```