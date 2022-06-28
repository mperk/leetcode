# add-two-numbers
**Solution**
```
ListNode AddTwoNumbers(ListNode l1, ListNode l2)
{
    BigInteger a = new BigInteger();
    BigInteger.TryParse(new string(FlatListNode(l1).Reverse().ToArray()), out BigInteger first);
    BigInteger.TryParse(new string(FlatListNode(l2).Reverse().ToArray()), out BigInteger second);
    var s = new string((first + second).ToString().Reverse().ToArray());

    var result = GenerateListNode(s);

    return result;
}

ListNode GenerateListNode(string s)
{
    if(string.IsNullOrEmpty(s)) return null;
    var result = new ListNode(Convert.ToInt32(s[0].ToString()));
    result.next = GenerateListNode(s.Substring(1, s.Length - 1));
    return result;
}

string FlatListNode(ListNode node)
{
    var result = node.val.ToString();
    if(node.next != null)
    {
        result += FlatListNode(node.next);
    }
    return result;
}

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}
```