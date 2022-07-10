# 4sum
**Solution**
```
IList<IList<int>> FourSum(int[] nums, int target)
{
    if (nums.Length < 4) return new List<IList<int>>();
    Array.Sort(nums);
    var finds = new Dictionary<string, IList<int>>();
    for (int i = 0; i < nums.Length - 3; i++)
    {
        for(int j = i + 1; j < nums.Length - 2; j++)
        {
            int left = j + 1, right = nums.Length - 1;
            while (left < right)
            {
                long subSum = (long)nums[i] + (long)nums[j] + (long)nums[left] + (long)nums[right];
                if (subSum == target)
                {
                    var find = new List<int>() { nums[i], nums[j], nums[left], nums[right] };
                    string key = string.Join("", find);
                    if (!finds.ContainsKey(key)) finds.Add(key, find);
                    left++;
                    right--;
                }
                else if (subSum < target)
                    left++;
                else
                    right--;
            }
        }
    }
    return finds.Select(x=>x.Value).ToList();
}
```