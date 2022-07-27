# wildcard-matching
**Solution**
```
bool WildcardMatching(string s, string p)
{
    int i = 0, j = 0;
    int lastMatch_i = -1, star_j = -1;

    while(i < s.Length)
    {
        if (j < p.Length && (s[i] == p[j] || p[j] == '?'))
        {
            i++; j++;
        }
        else if (j < p.Length && p[j] == '*')
        {
            star_j = j;
            j++;
            lastMatch_i = i;
        }
        else if (star_j != -1)
        {
            j = star_j + 1;
            lastMatch_i++;
            i = lastMatch_i;
        }
        else return false;
    }
    while (j < p.Length && p[j] == '*') j++;
    return j == p.Length;
}
```