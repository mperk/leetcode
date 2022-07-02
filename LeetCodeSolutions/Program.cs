
//Console.WriteLine(NumberOfCities(new List<int>() { 9, 1, 4, 9, 0, 4, 8, 9, 0, 1 }));

//Console.WriteLine(JohnTravelsToAnotherCity(new int[] { 29, 50 }, new int[] { 61, 37 }, new int[] { 37, 70 }));
//Console.WriteLine(JohnTravelsToAnotherCity(new int[] { 29,29 }, new int[] { 61, 61 }, new int[] { 70, 70 }));

//Console.WriteLine(TwoCitySchedCost(new int[][] { new int[] { 10, 20 }, new int[] { 30, 200 }, new int[] { 400, 50 },new int[] { 30, 20 } }));
//Console.WriteLine(UpdateBoard(new char[][] { 
//    new char[] { 'E', 'E', 'E', 'E', 'E' }, 
//    new char[] { 'E', 'E', 'M', 'E', 'E' },
//    new char[] { 'E', 'E', 'E', 'E', 'E' },
//    new char[] { 'E', 'E', 'E', 'E', 'E' } }, new int[] { 3, 0 }));

//Console.WriteLine(ReformatNumber("1222"));
//Console.WriteLine(LargestNumber(new int[] {3, 30, 34, 5, 9}));
//Console.WriteLine(TwoSum(new int[] { 2, 7, 11, 15 }, 9));

using System.Numerics;
using System.Text;

//AddTwoNumbers(new ListNode(2, new ListNode(4, new ListNode(3))), new ListNode(5, new ListNode(6, new ListNode(4))));

//Console.WriteLine(LengthOfLongestSubstring("dvdf"));

//Console.WriteLine(FindMedianSortedArrays(new int[] {  }, new int[] {  }));

//Console.WriteLine(LongestPalindrome("cbbd"));
//Console.WriteLine(Reverse(-123));
//Console.WriteLine(MyAtoi("    +11191657170"));
//Console.WriteLine(IsPalindrome(12231));
//Console.WriteLine(GenerateParenthesis(13));
//Console.WriteLine(IsMatch("aa", "a"));
//Console.WriteLine(MaxArea(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }));
Console.WriteLine(IntToRoman(1994));

Console.ReadLine();

string IntToRoman(int num)
{
    string result = string.Empty;
    while (num > 0)
    {
        if (num >= 900)
        {
            if (num >= 900 && num < 1000)
            {
                result += "CM";
                num -= 900;
            }
            else
            {
                result += "M";
                num -= 1000;
            }
        }
        else if (num >= 400)
        {
            if (num >= 400 && num < 500)
            {
                result += "CD";
                num -= 400;
            }
            else
            {
                result += "D";
                num -= 500;
            }
        }
        else if (num >= 90)
        {
            if (num >= 90 && num < 100)
            {
                result += "XC";
                num -= 90;
            }
            else
            {
                result += "C";
                num -= 100;
            }
        }
        else if (num >= 40)
        {
            if (num >= 40 && num < 50)
            {
                result += "XL";
                num -= 40;
            }
            else
            {
                result += "L";
                num -= 50;
            }
        }
        else if (num >= 10)
        {
            result += "X";
            num -= 10;
        }
        else if (num >= 5)
        {
            if (num >= 9)
            {
                result += "IX";
                num -= 9;
            }
            else
            {
                result += "V";
                num -= 5;
            }
        }
        else if (num >= 1)
        {
            if(num == 4)
            {
                result += "IV";
                num -= 4;
            }
            else
            {
                result += "I";
                num -= 1;
            }
        }
    }
    return result;
}

int MaxArea(int[] height)
{
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

bool IsMatch(string s, string p)
{
    var T = new bool[s.Length + 1, p.Length + 1];
    T[0, 0] = true;

    //deals with patterns like a* or a*b* or a*b*c*
    for (int i = 1; i < T.GetLength(1); i++)
    {
        if (p[i - 1] == '*')
            T[0, i] = T[0, i - 2];
    }

    for (int i = 1; i < T.GetLength(0); i++)
    {
        for (int j = 1; j < T.GetLength(1); j++)
        {
            if (p[j - 1] == '.' || p[j - 1] == s[i - 1])
                T[i, j] = T[i - 1, j - 1];
            else if (p[j - 1] == '*')
            {
                T[i, j] = T[i, j - 2];
                if (p[j - 2] == '.' || p[j - 2] == s[i - 1])
                    T[i, j] = T[i, j] | T[i - 1, j];
            }
            else
                T[i, j] = false;
        }
    }
    return T[s.Length, p.Length];
}

IList<string> GenerateParenthesis(int n)
{
    var result = new List<string>();
    GenerateParenthesisRecursive(string.Empty, 0, 0, result, n);
    return result;
}

void GenerateParenthesisRecursive(string s, int openParenthesis, int closeParenthesis, List<string> result, int n)
{
    if (openParenthesis == closeParenthesis && openParenthesis == n)
    {
        result.Add(s);
        return;
    }

    if (openParenthesis < n)
        GenerateParenthesisRecursive(s + "(", openParenthesis + 1, closeParenthesis, result, n);

    if (closeParenthesis < openParenthesis)
        GenerateParenthesisRecursive(s + ")", openParenthesis, closeParenthesis + 1, result, n);

    return;
}

bool IsPalindrome(int x)
{
    //this solution: faster than 98.11% of C# online submissions
    string xS = x.ToString();
    string reverse = new string(xS.Reverse().ToArray());
    if (xS == reverse) return true;
    else return false;

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

int MyAtoi(string s)
{
    StringBuilder sb = new StringBuilder();
    for (int i = 0; i < s.Length; i++)
    {
        if (string.IsNullOrEmpty(sb.ToString()))
        {
            if (s[i] == '-')
                sb.Append('-');
            else if (s[i] == '+')
                sb.Append('+');
            else if (s[i] != ' ' && s[i] != '+' && (s[i] < '0' || s[i] > '9'))
                return 0;
            if (s[i] >= '0' && s[i] <= '9')
                sb.Append(s[i]);
        }
        else
        {
            if (s[i] >= '0' && s[i] <= '9')
                sb.Append(s[i]);
            else
            {
                break;
            }
        }

    }
    Int32.TryParse(sb.ToString(), out int result);
    if (result == 0 && sb.Length > 1)
    {
        BigInteger.TryParse(sb.ToString(), out BigInteger bigInteger);
        if (bigInteger != 0)
        {
            if (sb.ToString()[0] == '-') return Int32.MinValue;
            else if (sb.ToString()[0] == '+') return Int32.MaxValue;
            else if (sb.ToString()[0] > '0' && sb.ToString()[0] <= '9') return Int32.MaxValue;
        }
    }
    return result;
}

int Reverse(int x)
{
    if (x >= 0)
    {
        Int32.TryParse(new string(x.ToString().Reverse().ToArray()), out int result);
        return result;
    }
    else
    {
        string tempS = x.ToString();
        Int32.TryParse("-" + new string(tempS.Substring(1, tempS.Length - 1).Reverse().ToArray()), out int result);
        return result;
    }
}

string LongestPalindrome(string s)
{
    //Manacher's Algorithm
    string longest = string.Empty;
    int longLength = 0;
    if (s.Length < 2) return s;
    for (int i = 0; i < s.Length; i++)
    {
        int left = i;
        int right = i;
        extendPalindrome(s, ref left, ref right);
        if (longLength < right - left - 1)
        {
            longLength = right - left - 1;
            longest = s.Substring(left + 1, right - left - 1);
        }

        left = i;
        right = i + 1;
        extendPalindrome(s, ref left, ref right);
        if (longLength < right - left - 1)
        {
            longLength = right - left - 1;
            longest = s.Substring(left + 1, right - left - 1);
        }
    }
    if (longLength == 0) return s[0].ToString();
    return longest;
}

void extendPalindrome(string s, ref int left, ref int right)
{
    while (left >= 0 && right < s.Length)
    {
        if (s[left] == s[right])
        {
            left--;
            right++;
        }
        else
        {
            break;
        }
    }
}

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

int LengthOfLongestSubstring(string s)
{
    var dic = new Dictionary<string, int>();
    int maxCount = 0;
    for (int i = 0; i < s.Length; i++)
    {
        if (!dic.ContainsKey(s[i].ToString()))
        {
            dic.Add(s[i].ToString(), i);
        }
        else
        {
            maxCount = Math.Max(dic.Count, maxCount);
            i = dic[s[i].ToString()];
            dic.Clear();
        }
    }
    maxCount = Math.Max(dic.Count, maxCount);
    return maxCount;
}

ListNode AddTwoNumbers(ListNode l1, ListNode l2)
{
    BigInteger a = new BigInteger();
    BigInteger.TryParse(new string(FlatListNode(l1).Reverse().ToArray()), out BigInteger first);
    BigInteger.TryParse(new string(FlatListNode(l2).Reverse().ToArray()), out BigInteger second);
    var s = new string((first + second).ToString().Reverse().ToArray());

    var result = GenerateListNode(s);

    return result;
}

ListNode GenerateListNode(string s)
{
    if (string.IsNullOrEmpty(s)) return null;
    var result = new ListNode(Convert.ToInt32(s[0].ToString()));
    result.next = GenerateListNode(s.Substring(1, s.Length - 1));
    return result;
}

string FlatListNode(ListNode node)
{
    var result = node.val.ToString();
    if (node.next != null)
    {
        result += FlatListNode(node.next);
    }
    return result;
}

int[] TwoSum(int[] nums, int target)
{
    var hashNums = new Dictionary<int, List<int>>();
    var result = new List<int>();
    for (int i = 0; i < nums.Length; i++)
    {
        if (hashNums.ContainsKey(nums[i])) hashNums[nums[i]].Add(i);
        else hashNums[nums[i]] = new List<int> { i };
        int diff = target - nums[i];
        if (hashNums.ContainsKey(diff) && hashNums[diff].Count(x => x != i) > 0)
        {
            result.Add(i);
            result.Add(hashNums[diff].FirstOrDefault(x => x != i));
        }
    }
    return result.ToArray();
}

string LargestNumber(int[] nums)
{
    var l = nums.Select(x => x.ToString()).OrderByDescending(x => x).ToList();
    l.Sort((a, b) => (b + a).CompareTo(a + b));
    if (l[0] == "0") return "0";
    return string.Join("", l);
}

string ReformatNumber(string number)
{
    string result = string.Empty;
    number = number.Replace(" ", "").Replace("-", "");

    int size = 0;
    for (int i = 0; i < number.Length; i++)
    {
        if (size == 2 && number.Length - i == 2)
        {
            result += "-";
            size = 0;
        }
        else if (size == 3)
        {
            result += "-";
            size = 0;
        }
        result += number[i];
        size++;
    }
    return result;
}

//minesweeper
char[][] UpdateBoard(char[][] board, int[] click)
{
    if (board[click[0]][click[1]] == 'M')
    {
        board[click[0]][click[1]] = 'X';
        return board;
    }

    int endi = board.Length;
    int endj = board[0].Length;
    Queue<(int, int)> q = new Queue<(int, int)>();
    q.Enqueue((click[0], click[1]));
    board[click[0]][click[1]] = 'B';

    while (q.Count > 0)
    {
        var e = q.Dequeue();
        int row = e.Item1;
        int col = e.Item2;
        int count = 0;

        List<(int, int)> list = new List<(int, int)>();

        for (int i = -1; i <= 1; i++)
        {
            for (int j = -1; j <= 1; j++)
            {
                int x = row + i;
                int y = col + j;
                if (x >= 0 && x < endi && y >= 0 && y < endj)
                {
                    if (board[x][y] == 'M') count++;
                    else if (count == 0 && board[x][y] == 'E')
                    {
                        //board[x][y] = 'B';
                        //q.Enqueue((x, y));
                        list.Add((x, y));
                    }
                }
            }
        }
        if (count != 0) board[row][col] = Convert.ToChar(count + 48);
        else
        {
            foreach (var item in list)
            {
                board[item.Item1][item.Item2] = 'B';
                q.Enqueue(item);
            }
        }

    }
    return board;

}

int TwoCitySchedCost(int[][] costs)
{
    int sum = costs.Sum(x => x[0]);
    var costsOrdered = costs.OrderBy(x => x[1] - x[0]).Select(x => x[1] - x[0]);
    for (int i = 0; i < costsOrdered.Count() / 2; i++)
    {
        sum += costsOrdered.ElementAt(i);
    }
    return sum;
}

long JohnTravelsToAnotherCity(int[] A, int[] B, int[] C)
{
    long count = 0;
    A = A.OrderBy(x => x).ToArray();
    B = B.OrderBy(x => x).ToArray();
    C = C.OrderBy(x => x).ToArray();

    for (int i = 0; i < B.Length; i++)
    {
        long aCount = 0L;
        long cCount = 0L;
        while (aCount < A.Length && A[aCount] < B[i])
        {
            aCount++;
        }
        for (int j = C.Length - 1; j >= 0 && C[j] > B[i]; j--)
        {
            cCount++;
        }

        count += aCount * cCount;
    }

    return count;
}

//https://maksimdan.gitbook.io/interview-practice-problems/leetcode_sessions/trees-and-graphs/number-of-cities-at-each-distance
//https://medium.com/@itoohue/breadth-first-search-by-example-5423be5778ec
List<int> NumberOfCities(List<int> T)
{
    int capital = T[0];
    var tree = new Dictionary<int, List<int>>();
    for (int i = 0; i < T.Count; i++)
    {
        if (i == T[i])
        {
            capital = i;
            tree.Add(i, new List<int>() { i });
        }
        else
        {
            if (!tree.ContainsKey(i)) tree.Add(i, new List<int>() { T[i] });
            else tree[i].Add(T[i]);
            if (!tree.ContainsKey(T[i])) tree.Add(T[i], new List<int> { i });
            else tree[T[i]].Add(i);
        }
    }

    var roadCount = new Dictionary<int, int>();
    HashSet<int> visited = new HashSet<int>();
    Queue<int> q = new Queue<int>();
    q.Enqueue(capital);
    int depth = 0;
    while (q.Count > 0)
    {
        int levelSize = q.Count;
        roadCount.Add(depth, levelSize);
        while (levelSize-- != 0)
        {
            var element = q.Dequeue();
            if (visited.Contains(element)) continue;
            else visited.Add(element);

            List<int> neighbours = new List<int>();
            tree.TryGetValue(element, out neighbours);
            foreach (var neighbour in neighbours)
            {
                if (!visited.Contains(neighbour))
                    q.Enqueue(neighbour);
            }
        }

        if (q.Count != 0)
            depth++;
    }

    var result = new List<int>();
    for (int i = 1; i < T.Count; i++)
    {
        if (roadCount.ContainsKey(i)) result.Add(roadCount[i]);
        else result.Add(0);
    }

    return T;
}


public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

