# reverse-integer
**Solution**
```
int Reverse(int x)
{
    if(x >= 0)
    {
        Int32.TryParse(new string(x.ToString().Reverse().ToArray()), out int result);
        return result;
    }
    else
    {
        string tempS = x.ToString();
        Int32.TryParse("-" + new string(tempS.Substring(1, tempS.Length - 1).Reverse().ToArray()), out int result);
        return result;
    }
}
```