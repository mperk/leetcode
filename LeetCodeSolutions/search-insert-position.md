# search-insert-position
**Solution**
```
int SearchInsert(int[] nums, int target)
{
    if (nums[nums.Length - 1] < target) return nums.Length;
    for (int i = 0; i < nums.Length; i++)
    {
       if (nums[i] >= target) return i;
    }
    return -1;
}
```