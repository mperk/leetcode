# find-first-and-last-position-of-element-in-sorted-array
**Solution**
```
int[] SearchRange(int[] nums, int target)
{
    var result = nums.Select((x, i) => x == target ? i : -1).Where( x => x != -1);
    if (result.Count() == 1) return new[] { result.First(), result.First() };
    if (result.Any()) return new[] { result.First(), result.Last() };
    else return new int[] { -1, -1 };
}
```