# letter-combinations-of-a-phone-number
**Solution**
```
IList<string> LetterCombinations(string digits)
{
    var dic = new Dictionary<char, string>
    {
        { '2', "abc" },{ '3', "def" },{ '4', "ghi" },{ '5', "jkl" },{ '6', "mno" },{ '7', "pqrs" },{ '8', "tuv" },{ '9', "wxyz" },
    };
    var result = new List<string>();
    if (digits.Length == 0) return result;
    dfs(0, new StringBuilder());
    void dfs(int i, StringBuilder currentStr)
    {
        if (currentStr.Length == digits.Length)
        {
            result.Add(currentStr.ToString());
            return;
        }
        foreach (var item in dic[digits[i]])
        {
            currentStr.Append(item.ToString());
            dfs(i + 1, currentStr);
            currentStr.Remove(currentStr.Length - 1, 1);
        }
    }
    return result;
}
```