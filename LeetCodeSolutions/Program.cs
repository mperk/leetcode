
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

//AddTwoNumbers(new ListNode(2, new ListNode(4, new ListNode(3))), new ListNode(5, new ListNode(6, new ListNode(4))));

//Console.WriteLine(LengthOfLongestSubstring("dvdf"));

//Console.WriteLine(FindMedianSortedArrays(new int[] {  }, new int[] {  }));

Console.WriteLine(LongestPalindrome("babad"));

Console.ReadLine();

string LongestPalindrome(string s)
{
    //var allSubstrings = new List<string>();
    string longest = string.Empty;
    for (int i = 0; i < s.Length; i++)
    {
        for (int j = i; j < s.Length; j++)
        {
            string sub = s.Substring(i, j - i + 1);
            if(sub == new string(sub.Reverse().ToArray()))
            {
                if (longest.Length < sub.Length)
                    longest = sub;
            }
        }
    }
    return longest;
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
    if(string.IsNullOrEmpty(s)) return null;
    var result = new ListNode(Convert.ToInt32(s[0].ToString()));
    result.next = GenerateListNode(s.Substring(1, s.Length - 1));
    return result;
}

string FlatListNode(ListNode node)
{
    var result = node.val.ToString();
    if(node.next != null)
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
        if(hashNums.ContainsKey(nums[i])) hashNums[nums[i]].Add(i);
        else hashNums[nums[i]] = new List<int> { i };
        int diff = target - nums[i];
        if (hashNums.ContainsKey(diff) && hashNums[diff].Count(x => x != i) > 0 )
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
    number = number.Replace(" ", "").Replace("-","");

    int size = 0;
    for (int i = 0; i < number.Length; i++)
    {
        if(size == 2 && number.Length - i == 2)
        {
            result += "-";
            size = 0;
        } else if(size == 3)
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

        List<(int,int)> list = new List<(int, int)>();

        for (int i = -1; i <= 1; i++)
        {
            for (int j = -1; j <= 1; j++)
            {
                int x = row + i;
                int y = col + j;
                if (x >= 0 && x < endi && y >= 0 && y < endj)
                {
                    if (board[x][y] == 'M') count++;
                    else if (count == 0 && board[x][y] == 'E') {
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
        while(aCount < A.Length && A[aCount] < B[i])
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

