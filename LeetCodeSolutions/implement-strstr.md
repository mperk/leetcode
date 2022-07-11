# implement-strstr
**Solution**
```
int StrStr(string haystack, string needle)
{
    if (string.IsNullOrEmpty(needle)) return 0;
    int result = haystack.IndexOf(needle);
    return result;
}
```