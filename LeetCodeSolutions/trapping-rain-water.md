# trapping-rain-water
**Solution**
```
int Trap(int[] height)
{
    int result = 0;
    int leftMax = Int32.MinValue;
    int rightMax = Int32.MinValue;

    for (int left = 0, right = height.Length - 1; left <= right;)
    {
        leftMax = Math.Max(leftMax, height[left]);
        rightMax = Math.Max(rightMax, height[right]);
        if (leftMax < rightMax)
        {
            result += leftMax - height[left];
            left++;
        }
        else
        {
            result += rightMax - height[right];
            right--;
        }
    }
    return result;
}
```