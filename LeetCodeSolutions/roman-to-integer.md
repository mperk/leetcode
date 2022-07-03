# roman-to-integer
**Solution**
```
int RomanToInt(string s)
{
    //https://leetcode.com/problems/roman-to-integer/discuss/264743/Clean-Python-beats-99.78.
    var dic = new Dictionary<char, int>();
    dic.Add('I', 1);
    dic.Add('V', 5);
    dic.Add('X', 10);
    dic.Add('L', 50);
    dic.Add('C', 100);
    dic.Add('D', 500);
    dic.Add('M', 1000);
    int result = 0;
    s = s.Replace("IV", "IIII").Replace("IX", "VIIII");
    s = s.Replace("XL", "XXXX").Replace("XC", "LXXXX");
    s = s.Replace("CD", "CCCC").Replace("CM", "DCCCC");
    for (int i = 0; i < s.Length; i++)
    {
        result += dic[s[i]];
    }
    return result;
}
```