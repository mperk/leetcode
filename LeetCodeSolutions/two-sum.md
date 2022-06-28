# two-sum
**Solution**
```
int[] TwoSum(int[] nums, int target)
{
    var hashNums = new Dictionary<int, List<int>>();
    var result = new List<int>();
    for (int i = 0; i < nums.Length; i++)
    {
        if(hashNums.ContainsKey(nums[i])) hashNums[nums[i]].Add(i);
        else hashNums[nums[i]] = new List<int> { i };
        int diff = target - nums[i];
        if (hashNums.ContainsKey(diff) && hashNums[diff].Count(x => x != i) > 0 )
        {
            result.Add(i);
            result.Add(hashNums[diff].FirstOrDefault(x => x != i));
        }
    }
    return result.ToArray();
}
```