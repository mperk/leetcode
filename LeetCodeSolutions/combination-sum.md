# combination-sum
**Solution**
```
IList<IList<int>> CombinationSum(int[] candidates, int target)
{
    var result = new List<IList<int>>();
    dfs(0, new List<int>());
    void dfs(int i, List<int> cur)
    {
        int sum = cur.Sum();
        if (sum == target)
        {
            result.Add(new List<int>(cur));
            return;
        }
        else if (sum > target || i >= candidates.Length)
            return;

        cur.Add(candidates[i]);
        dfs(i, cur);
        cur.RemoveAt(cur.Count - 1);
        dfs(i + 1, cur);
    }
    return result;
}
```