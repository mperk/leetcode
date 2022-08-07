# permutations
**Solution**
```
IList<IList<int>> Permute(int[] nums)
{
    var result = new List<IList<int>>();
    backtrack(new List<int>());
    void backtrack(List<int> candidate)
    {
        if (candidate.Count() == nums.Length)
            result.Add(new List<int>(candidate));
        else
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (candidate.Contains(nums[i])) continue;
                candidate.Add(nums[i]);
                backtrack(candidate);
                candidate.RemoveAt(candidate.Count() - 1);
            }
        }
    }
    return result;
}
```