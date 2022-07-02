# container-with-most-water
**Solution**
```
int MaxArea(int[] height)
{
    // https://leetcode.com/problems/container-with-most-water/discuss/6100/Simple-and-clear-proofexplanation
    int maxArea = 0;
    int i = 0;
    int j = height.Length - 1;
    while (i < j)
    {
        maxArea = Math.Max(maxArea, (j - i) * Math.Min(height[i], height[j]));
        if (height[i] < height[j])
            i++;
        else
            j--;
    }
    return maxArea;
}
```