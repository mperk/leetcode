# regular-expression-matching
**Solution**
```
// getting feyz from here: https://www.youtube.com/watch?v=l3hda49XcDE
bool IsMatch(string s, string p)
{
    var T = new bool[s.Length + 1, p.Length + 1];
    T[0, 0] = true;

    //deals with patterns like a* or a*b* or a*b*c*
    for (int i = 1; i < T.GetLength(1); i++)
    {
        if (p[i - 1] == '*')
            T[0, i] = T[0, i - 2];
    }

    for (int i = 1; i < T.GetLength(0); i++)
    {
        for (int j = 1; j < T.GetLength(1); j++)
        {
            if (p[j - 1] == '.' || p[j - 1] == s[i - 1])
                T[i, j] = T[i - 1, j - 1];
            else if (p[j - 1] == '*')
            {
                T[i, j] = T[i, j - 2];
                if (p[j - 2] == '.' || p[j - 2] == s[i - 1])
                    T[i, j] = T[i, j] | T[i - 1, j];
            }
            else
                T[i, j] = false;
        }
    }
    return T[s.Length, p.Length];
}
```