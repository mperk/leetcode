# permutations-ii
**Solution**
```
IList<IList<int>> PermuteUnique(int[] nums)
{
    var result = new List<IList<int>>();
    var added = new HashSet<string>();
    backtrack(new List<(int, int)>());
    void backtrack(List<(int,int)> candidate)
    {
        if (candidate.Count == nums.Length)
        {
            string key = string.Join(",", candidate.Select(x => x.Item2));
            if (!added.Contains(key))
            {
                result.Add(new List<int>(candidate.Select(x => x.Item2)));
                added.Add(key);
            }
        }
        else
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (candidate.Any(x => x.Item1 == i)) continue;
                else
                {
                    candidate.Add((i, nums[i]));
                    backtrack(candidate);
                    candidate.RemoveAt(candidate.Count - 1);
                }
            }
        }
    }

    return result;
}
```