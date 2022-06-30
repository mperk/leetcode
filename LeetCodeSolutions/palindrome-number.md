# palindrome-number
**Solution**
```
bool IsPalindrome(int x)
{
    //this solution: faster than 98.11% of C# online submissions
    string xS = x.ToString();
    string reverse = new string(xS.Reverse().ToArray());
    if (xS == reverse) return true;
    else return false;
}

bool IsPalindrome(int x)
{
    //this solution: faster than 29.61% of C# online submissions
    //string xS = x.ToString();
    //int i = 0;
    //int j = xS.Length - 1;

    //int endI = xS.Length / 2;
    //int endJ = xS.Length / 2;
    //if (xS.Length % 2 != 0) endJ++;
    //while (i < endI && j >= endJ)
    //{
    //    if (xS[i] == xS[j])
    //    {
    //        i++;
    //        j--;
    //    }
    //    else
    //    {
    //        return false;
    //    }
    //}
    //return true;
}
```