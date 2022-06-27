# Reformat-Phone-Number
**Solution**
```
string ReformatNumber(string number)
{
    string result = string.Empty;
    number = number.Replace(" ", "").Replace("-","");

    int size = 0;
    for (int i = 0; i < number.Length; i++)
    {
        if(size == 2 && number.Length - i == 2)
        {
            result += "-";
            size = 0;
        } else if(size == 3)
        {
            result += "-";
            size = 0;
        }
        result += number[i];
        size++;
    }
    return result;
}
```