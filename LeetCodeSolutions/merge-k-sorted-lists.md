# merge-k-sorted-lists
**Solution**
```
ListNode MergeKLists(ListNode[] lists)
{
    var flatList = new List<int>();

    foreach (var item in lists)
    {
        flatListFromKLists(item);
    }

    void flatListFromKLists(ListNode list)
    {
        if(list == null) return;
        flatList.Add(list.val);
        flatListFromKLists(list.next);
    }
    flatList.Sort();
    if (flatList.Count == 0) return null;
    var result = new ListNode(flatList[0]);
    flatList.RemoveAt(0);
    void generateResultFromFlatList(List<int> l, ListNode _result)
    {
        if(l.Count == 0) return;
        _result.next = new ListNode(l[0]);
        l.RemoveAt(0);
        generateResultFromFlatList(l, _result.next);
    }
    generateResultFromFlatList(flatList, result);

    return result;
}
```