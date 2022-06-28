# median-of-two-sorted-arrays
**Solution**
```
double FindMedianSortedArrays(int[] nums1, int[] nums2)
{
    var nums3 = nums1.Concat(nums2).ToArray();
    Array.Sort(nums3);
    if (nums3.Length == 0) return 0.0;
    double median = nums3[0];
    int l = nums3.Length;
    if (l % 2 == 0)
    {
        median = (nums3[l / 2] + nums3[l / 2 - 1]) / 2.0;
    }
    else
    {
        median = nums3[l / 2];
    }
    return median;
}
```