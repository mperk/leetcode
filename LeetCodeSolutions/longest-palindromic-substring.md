# longest-palindromic-substring
**Solution**
```
string LongestPalindrome(string s)
{
    //Manacher's Algorithm
    string longest = string.Empty;
    int longLength = 0;
    if (s.Length < 2) return s;
    for (int i = 0; i < s.Length; i++)
    {
        int left = i;
        int right = i;
        extendPalindrome(s, ref left, ref right);
        if(longLength < right - left - 1)
        {
            longLength = right - left - 1;
            longest = s.Substring(left+1, right - left - 1);
        }

        left = i;
        right = i+1;
        extendPalindrome(s, ref left, ref right);
        if (longLength < right - left - 1)
        {
            longLength = right - left - 1;
            longest = s.Substring(left + 1, right - left - 1);
        }
    }
    if (longLength == 0) return s[0].ToString();
    return longest;
}

void extendPalindrome(string s, ref int left, ref int right)
{
    while (left >= 0 && right < s.Length)
    {
        if (s[left] == s[right])
        {
            left--;
            right++;
        }
        else
        {
            break;
        }
    }
}
```