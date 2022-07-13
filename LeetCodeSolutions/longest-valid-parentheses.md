# longest-valid-parentheses
**Solution**
```
int LongestValidParentheses(string s)
{
    //ref: https://leetcode.com/problems/longest-valid-parentheses/discuss/1019485/Easy-C-solution-(stack)
    int ans = 0;
    var st = new Stack<int>();
    st.Push(-1);
    for (int i = 0; i < s.Length; i++)
    {
        if (s[i] == '(')
            st.Push(i);
        else if (s[i] == ')')
        {
            st.Pop();
            if (st.Count == 0)
                st.Push(i);
            ans = Math.Max(ans, i - st.Peek());
        }
    }
    return ans;
}
```