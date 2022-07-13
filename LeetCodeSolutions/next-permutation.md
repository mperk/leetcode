# next-permutation
**Solution**
```
void NextPermutation(int[] nums)
{ //good explain: https://leetcode.com/problems/next-permutation/discuss/13994/Readable-code-without-confusing-ij-and-with-explanation
    bool isChanged = false;
    for (int i = nums.Length - 1; i > 0; i--)
    {
        if (nums[i] > nums[i - 1])
        {
            var rightPart = nums.ToList().GetRange(i, nums.Length - i);
            rightPart.Sort();
            int temp = nums[i - 1];
            int willChangeIndex = -1;
            for (int j = 0; j < rightPart.Count; j++)
                if (rightPart[j] > temp)
                {
                    willChangeIndex = j;
                    break;
                }
            Console.WriteLine(willChangeIndex);
            nums[i - 1] = rightPart[willChangeIndex];
            rightPart[willChangeIndex] = temp;
            for (int j = i, k = 0; j < nums.Length; j++, k++)
            {
                nums[j] = rightPart[k];
            }
            isChanged = true;
            break;
        }
    }
    if (!isChanged) Array.Sort(nums);
}
```