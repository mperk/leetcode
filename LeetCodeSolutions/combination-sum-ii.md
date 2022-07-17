# combination-sum-ii
**Solution**
```
IList<IList<int>> CombinationSum2(int[] candidates, int target)
{
    candidates = candidates.ToList().OrderBy(x => x).ToArray();
    var result = new List<IList<int>>();
    
    void backtrack(List<int> cur, int i)
    {
        int sum = cur.Sum();
        if (sum == target)
        {
            result.Add(new List<int>(cur));
            return;
        }
        else if (sum > target || i >= candidates.Length)
            return;

        int prev = -1;
        for (int j = i; j < candidates.Length; j++)
        {
            if (candidates[j] == prev) continue;
            cur.Add(candidates[j]);
            backtrack(cur, j + 1);
            cur.RemoveAt(cur.Count - 1);
            prev = candidates[j];
        }
    }
    backtrack(new List<int>(), 0);
    return result;
}
```