# search-in-rotated-sorted-array
**Solution**
```
int Search(int[] nums, int target)
{
    return nums.ToList().IndexOf(target);

    //var result = -1;
    //for (int i = 0; i < nums.Length; i++)
    //{
    //    if (target == nums[i]) result = i;
    //}
    //return result;
}
```