# group-anagrams
**Solution**
```
IList<IList<string>> GroupAnagrams(string[] strs)
{
    var dic = new Dictionary<string, IList<string>>();
    foreach (var str in strs)
    {
        var ordered = string.Join(string.Empty,str.OrderBy(x => x));
        if (dic.ContainsKey(ordered))
        {
            dic[ordered].Add(str);
        }
        else
        {
            dic[ordered] = new List<string> { str };
        }
    }
    return dic.Select(x => x.Value).ToList();
}
```