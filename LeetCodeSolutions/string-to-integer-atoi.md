# string-to-integer-atoi
**Solution**
```
int MyAtoi(string s)
{
    StringBuilder sb = new StringBuilder();
    for (int i = 0; i < s.Length; i++)
    {
        if (string.IsNullOrEmpty(sb.ToString()))
        {
            if(s[i] == '-')
                sb.Append('-');
            else if(s[i] == '+')
                sb.Append('+');
            else if(s[i] != ' ' && s[i] != '+' && (s[i] < '0' || s[i] > '9'))
                return 0;
            if (s[i] >= '0' && s[i] <= '9')
                sb.Append(s[i]);
        }
        else
        {
            if (s[i] >= '0' && s[i] <= '9')
                sb.Append(s[i]);
            else
            {
                break;
            }
        }
        
    }
    Int32.TryParse(sb.ToString(), out int result);
    if(result == 0 && sb.Length > 1)
    {
        BigInteger.TryParse(sb.ToString(), out BigInteger bigInteger);
        if(bigInteger != 0)
        {
            if (sb.ToString()[0] == '-') return Int32.MinValue;
            else if (sb.ToString()[0] == '+') return Int32.MaxValue;
            else if (sb.ToString()[0] > '0' && sb.ToString()[0] <= '9') return Int32.MaxValue;
        }
    }
    return result;
}
```