# 3sum-closest
**Solution**
```
int ThreeSumClosest(int[] nums, int target)
{
    int minSum = nums[0] + nums[1] + nums[2];
    if (nums.Length == 3) return minSum;
    Array.Sort(nums);
    int min = Math.Abs(target - minSum);
    for (int i = 0; i < nums.Length - 2; i++)
    {
        int left = i + 1, right = nums.Length - 1;
        while(left < right)
        {
            int tempSum = nums[left] + nums[right] + nums[i];
            if (tempSum > target)
                right--;
            else
                left++;

            int tempDiff = Math.Abs(target - tempSum);
            if (tempDiff < min) 
            { 
                min = tempDiff;
                minSum = tempSum;
            }
        }
    }

    return minSum;
}
```