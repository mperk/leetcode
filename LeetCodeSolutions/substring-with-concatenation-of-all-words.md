# substring-with-concatenation-of-all-words
**Solution**
```
IList<int> FindSubstring(string s, string[] words)
{
    var result = new List<int>();
    if (words.Length == 0) return result;

    int n = words.Length, len = words[0].Length;
    var expect = new Dictionary<string, int>();
    foreach (var word in words)
    {
        if (expect.ContainsKey(word)) expect[word]++;
        else expect.Add(word, 1);
    }

    var seen = new Dictionary<string, int>();
    for (int i = 0; i < s.Length - n * len + 1; i++)
    {
        seen.Clear();
        int count = 0;
        while (count < n)
        {
            string curr = s.Substring(i + count * len, len);
            if (expect.ContainsKey(curr))
            {
                if (seen.ContainsKey(curr)) seen[curr]++;
                else seen.Add(curr, 1);

                if (seen[curr] > expect[curr])
                    break;
            }
            else
                break;
            count++;
        }
        if (count == n) result.Add(i);
    }
    return result;
}
```