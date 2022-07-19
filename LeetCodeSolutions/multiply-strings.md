# multiply-strings

**Solution**
```
string Multiply(string num1, string num2)
{
    var result = new int[num1.Length + num2.Length];
    for (int i = num1.Length - 1; i >= 0; i--)
    {
        for (int j = num2.Length - 1; j >= 0; j--)
        {
            int t = Int32.Parse(num1[i].ToString()) * Int32.Parse(num2[j].ToString()) + result[i + j + 1];
            result[i + j] += t / 10;
            result[i + j + 1] = t % 10;
        }
    }

    var sb = new StringBuilder();
    foreach (var item in result)
    {
        if (sb.Length == 0 && item == 0) continue;
        else sb.Append(item.ToString());
    }
    return sb.Length == 0 ? "0" : sb.ToString();
}
```