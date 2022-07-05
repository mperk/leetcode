# longest-common-prefix
**Solution**
```
string LongestCommonPrefix(string[] strs)
{
    string longestCommonPrefix = string.Empty;

    for (int j = 1; j <= strs[0].Length; j++)
    {
        string s = strs[0].Substring(0, j);
        if (strs.Count(x => x.StartsWith(s)) == strs.Count())
        {
            if(s.Length > longestCommonPrefix.Length)
                longestCommonPrefix = s;
        }
        else { break; }
    }
    
    return longestCommonPrefix;
}
```