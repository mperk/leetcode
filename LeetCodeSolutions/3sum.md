# 3sum
**Solution**
```
IList<IList<int>> ThreeSum(int[] nums)
{
    //var finds = new List<IList<int>>();
    var finds = new Dictionary<string, IList<int>>();
    Array.Sort(nums);
    for (int i = 0; i < nums.Length - 2; i++)
    {
        int left = i + 1, right = nums.Length - 1;

        while (left < right)
        {
            if (nums[i] + nums[left] + nums[right] == 0)
            {
                var triple = new List<int> { nums[i], nums[left], nums[right] };
                var key = string.Join("", triple);
                if (!finds.ContainsKey(key))
                    finds.Add(key, triple);
                left++;
                right--;
            }
            else if (nums[i] + nums[left] + nums[right] > 0)
                right--;
            else
                left++;
        }
    }
    return finds.Select(x => x.Value).ToList();
}
```