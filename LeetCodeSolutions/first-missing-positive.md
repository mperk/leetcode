# first-missing-positive
**Solution**
```
int FirstMissingPositive(int[] nums)
{
    Array.Sort(nums);
    int lastJ = 0;
    int result = nums.Length;
    for (int i = 1; i <= nums.Length; i++)
    {
        for (int j = lastJ; j < nums.Length; j++)
        {
            if (nums[j] == i)
            {
                lastJ = j + 1;
                result = i + 1;
                break;
            }
            else if (nums[j] < i)
            {
                result = i;
                lastJ = j + 1;
                continue;
            }
            else if (nums[j] > i) return i;
        }
    }
    return result;
}
```