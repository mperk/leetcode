# generate-parentheses
**Solution**
```
IList<string> GenerateParenthesis(int n)
{
    var result = new List<string>();
    GenerateParenthesisRecursive(string.Empty, 0, 0, result, n);
    return result;
}

void GenerateParenthesisRecursive(string s, int openParenthesis, int closeParenthesis, List<string> result, int n)
{
    if(openParenthesis == closeParenthesis && openParenthesis == n)
    {
        result.Add(s);
        return;
    }

    if (openParenthesis < n)
        GenerateParenthesisRecursive(s + "(", openParenthesis + 1, closeParenthesis, result, n);

    if(closeParenthesis < openParenthesis)
        GenerateParenthesisRecursive(s + ")", openParenthesis, closeParenthesis +1, result, n);

    return;
}
```