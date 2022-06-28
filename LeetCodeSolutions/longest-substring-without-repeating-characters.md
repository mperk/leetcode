# longest-substring-without-repeating-characters
**Solution**
```
int LengthOfLongestSubstring(string s)
{
    var dic = new Dictionary<string, int>();
    int maxCount = 0;
    for (int i = 0; i < s.Length; i++)
    {
        if (!dic.ContainsKey(s[i].ToString()))
        {
            dic.Add(s[i].ToString(), i);
        }
        else
        {
            maxCount = Math.Max(dic.Count, maxCount);
            i = dic[s[i].ToString()];
            dic.Clear();
        }
    }
    maxCount = Math.Max(dic.Count, maxCount);
    return maxCount;
}
```