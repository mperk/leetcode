# valid-parentheses
**Solution**
```
bool IsValid(string s)
{
    var dic = new Dictionary<char, char> { { '}', '{' }, { ')', '(' }, { ']', '[' } };
    var open = new HashSet<char>() { '{' , '(', '[' };
    var q = new Stack<char>();
    
    for (int i = 0; i < s.Length; i++)
    {
        if (open.Contains(s[i]))
            q.Push(s[i]);
        else
        {
            if (q.Count == 0) return false;
            if (q.Pop() == dic[s[i]])
                continue;
            else return false;
        }
    }
    if (q.Count == 0) return true;
    else return false;
}
```