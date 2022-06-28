# Largest-Number
**Solution**
```
string LargestNumber(int[] nums)
{
    var l = nums.Select(x => x.ToString()).OrderByDescending(x => x).ToList();
    l.Sort((a, b) => (b + a).CompareTo(a + b));
    if (l[0] == "0") return "0";
    return string.Join("", l);
}
```