﻿
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

using System.Collections.Concurrent;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;

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
//Console.WriteLine(IntToRoman(1994));
//Console.WriteLine(RomanToInt("MCMXCIV"));
//Console.WriteLine(LongestCommonPrefix(new string[] { "flower", "flow", "flight" }));
//Console.WriteLine(CountPaths(new int[][] { new int[] { 1, 1 }, new int[] { 3, 4 } }));
//Console.WriteLine(SpiralMatrix(4, 5, GenerateListNodeFromArray(new int[] { 515, 942, 528, 483, 20, 159, 868, 999, 474, 320, 734, 956, 12, 124, 224, 252, 909, 732 })));
//Console.WriteLine(SpiralMatrix(3, 5, GenerateListNodeFromArray(new int[] { 3, 0, 2, 6, 8, 1, 7, 9, 4, 2, 5, 5, 0 })));
//Console.WriteLine(PeopleAwareOfSecret(6, 2, 4));
//Console.WriteLine(PeopleAwareOfSecret(425, 81, 118));
//Console.WriteLine(ThreeSum(new int[] { -1, 0, 1, 2, -1, -4 }));
//Console.WriteLine(ThreeSumClosest(new int[] { 4, 0, 5, -5, 3, 3, 0, -4, -5 }, -2));
//Console.WriteLine(LetterCombinations("234"));
//Console.WriteLine(FourSum(new int[] { 1000000000, 1000000000, 1000000000, 1000000000 }, -294967296));
//RemoveNthFromEnd(new ListNode(1), 1);
//Console.WriteLine(IsValid("([)]"));
//MergeTwoLists(new ListNode(1, new ListNode(21, new ListNode(24))), new ListNode(1, new ListNode(3, new ListNode(4))));
//MergeKLists(new List<ListNode> { new ListNode(1, new ListNode(4, new ListNode(5))), new ListNode(1, new ListNode(3, new ListNode(4))), new ListNode(2, new ListNode(6)) }.ToArray());
//SwapPairs(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4)))));
//ReverseKGroup(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, new ListNode(6)))))), 3);
//Console.WriteLine(StrStr("hello", "ll"));
//Console.WriteLine(Divide(-2147483648, -1));
//Console.WriteLine(solutionExceptionally("[{\"id\": \"0\", \"agent\": \"Virginia Rios\", \"unit\": \"#739\", \"description\": \"This renovated 1-bedroom is located on the fifth of a nice building in downtown.\", \"num_bedrooms\": 1}, {\"id\": \"1\", \"agent\": \"Antonio Green\", \"unit\": \"#976\", \"description\": \"small , ornate and small apartment in the heart of midtown!\", \"num_bedrooms\": 0}, {\"id\": \"2\", \"agent\": \"Evan Williams\", \"unit\": \"#25\", \"description\": \"What a good deal for this beautiful and beautiful 1-bedroom!\", \"num_bedrooms\": 1}]"));
//Console.WriteLine(FindSubstring("barfoothefoobarman", new string[] { "foo", "bar" }));
//NextPermutation(new int[] { 0, 1, 2, 5, 3, 3, 0 });
//LongestValidParentheses("()())((()))");
//Search(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 11);
//SearchInsert(new int[] { 3, 5, 6 }, 2);
//Console.WriteLine(IsValidSudoku(new char[][] {
// new char[] {'5','3','.','.','7','.','.','.','.'}
//,new char[] {'6','.','.','1','9','5','.','.','.'}
//,new char[] {'.','9','8','.','.','.','.','6','.'}
//,new char[] {'8','.','.','.','6','.','.','.','3'}
//,new char[] {'4','.','.','8','.','3','.','.','1'}
//,new char[] {'7','.','.','.','2','.','.','.','6'}
//,new char[] {'.','6','.','.','.','.','2','8','.'}
//,new char[] {'.','.','.','4','1','9','.','.','5'}
//,new char[] {'.','.','.','.','8','.','.','7','9'}  }));
//SolveSudoku(new char[][] {
// new char[] {'5','3','.','.','7','.','.','.','.'}
//,new char[] {'6','.','.','1','9','5','.','.','.'}
//,new char[] {'.','9','8','.','.','.','.','6','.'}
//,new char[] {'8','.','.','.','6','.','.','.','3'}
//,new char[] {'4','.','.','8','.','3','.','.','1'}
//,new char[] {'7','.','.','.','2','.','.','.','6'}
//,new char[] {'.','6','.','.','.','.','2','8','.'}
//,new char[] {'.','.','.','4','1','9','.','.','5'}
//,new char[] {'.','.','.','.','8','.','.','7','9'}
//});
//CombinationSum(new int[] { 2, 3, 6, 7 }, 7);
//CombinationSum2(new int[] { 10, 1, 2, 7, 6, 1, 5 }, 8);
//Console.WriteLine(FirstMissingPositive(new int[] { -1, -2, -3 }));
//Console.WriteLine(Trap(new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 }));
//Console.WriteLine(Multiply("123", "456"));
// Console.WriteLine(WildcardMatching("abcabczzzde", "*abc???de*"));
//Console.WriteLine(JumpGame2(new int[] { 5,9,3,2,1,0,2,3,3,1,0,0 }));
//Console.WriteLine(Permute(new int[] { 1,2,3 }));
// Console.WriteLine(PermuteUnique(new int[] { 1,1,2 }));
// Rotate(new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 }, });
// Console.WriteLine(solution(new int[] { 1, 3, 6, 4, 1, 2 }));
// Console.WriteLine(GetTaskIndexAtCycle_first(new int[] { 3, 4, 3, 2, 5 }, 10));
// Console.WriteLine(GetTaskIndexAtCycle(new int[] { 3, 4, 3, 2, 5 }, new int[] { -1, -1, -1, 2, -1 }, 8));
// Console.WriteLine(Validate(new string[] { "--name", "SOME_NAME", "--count", "10" }));
// Console.WriteLine("Mehmet");
// Analyze("1 2222 3");
// Console.WriteLine(GroupAnagrams(new[] { "eat", "tea", "tan", "ate", "nat", "bat" }));

Console.WriteLine(MaxSubArray(new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }));
Console.ReadLine();

int MaxSubArray(int[] nums)
{
    int maxSub = nums[0];
    int curSum = 0;
    foreach (var n in nums)
    {
        if(curSum < 0)
            curSum = 0;
        curSum += n;
        maxSub = Math.Max(maxSub, curSum);
    }
    return maxSub;
}

double MyPow(double x, int n)
{
    if (n == 0) return (double)1.00000;
    if (x == 1.00000) return (double)1.00000;

    int half = n >> 1;
    double result = x;
    int i = 1;
    while (i < Math.Abs(half))
    {
        result = result * x;
        i++;
    }

    if (n % 2 == 0)
        result = result * result;
    else
        result = result * result * x;

    if (n < 0)
    {
        result = 1 / result;
    }

    return result;
}


IList<IList<string>> GroupAnagrams(string[] strs)
{
    var dic = new Dictionary<string, IList<string>>();
    foreach (var str in strs)
    {
        var ordered = string.Join(string.Empty, str.OrderBy(x => x));
        if (dic.ContainsKey(ordered))
        {
            dic[ordered].Add(str);
        }
        else
        {
            dic[ordered] = new List<string> { str };
        }
    }
    return dic.Select(x => x.Value).ToList();
}


Stats Analyze(string document)
{
    var result = new Stats();
    if (document is null) throw new ArgumentNullException();
    if (string.IsNullOrEmpty(document)) return result;

    var splitedDoc = document.Split(" ");
    result.NumberOfAllWords = splitedDoc.Count();
    result.NumberOfWordsThatContainOnlyDigits = splitedDoc.Where(x => x.All(Char.IsDigit)).Count();
    result.NumberOfWordsStartingWithSmallLetter = splitedDoc.Where(x => Char.IsLower(x.FirstOrDefault())).Count();
    result.NumberOfWordsStartingWithCapitalLetter = splitedDoc.Where(x => Char.IsUpper(x.FirstOrDefault())).Count();
    var orderedDoc = splitedDoc.OrderBy(x => x.Length).Select(v => new { v, v.Length });
    result.TheLongestWord = orderedDoc.Where(x => orderedDoc.LastOrDefault().Length == x.Length).First().v;
    result.TheShortestWord = orderedDoc.FirstOrDefault().v;
    return result;
}

public class Stats
{
    // Total number of all words in the document
    public int NumberOfAllWords { get; set; }

    // Returns number of words that consist only from digits e.g. 13455, 98374
    public int NumberOfWordsThatContainOnlyDigits { get; set; }

    // Returns number of words that start with a lower letter e.g. a, d, z
    public int NumberOfWordsStartingWithSmallLetter { get; set; }

    // Returns number of words that start with a capital letter e.g. A, D, Z
    public int NumberOfWordsStartingWithCapitalLetter { get; set; }

    // Returns the first longest word in the document
    public string TheLongestWord { get; set; }

    // Returns the first shortest word in the document
    public string TheShortestWord { get; set; }
}


/*


int Validate(string[] args)
{
    if (args.Count() == 0) return -1;

    string[] acceptedParams = new string[] { "--name", "--count", "--help" };
    var dic = new Dictionary<string, List<string>>()
    {
        {"--name", new List<string>()},
        {"--count", new List<string>()},
        {"--help", new List<string>()},
    };
    bool invalidKey = false;
    bool invalidParam = false;
    for (int i = 0; i < args.Length; i += 2)
    {
        if (dic.ContainsKey(args[i].ToLower()))
        {
            if (args[i].ToLower() == "--help")
                dic[args[i].ToLower()].Add("help");
            else if (args[i].ToLower() == "--count")
            {
                if (args.Length > i + 1)
                {
                    dic[args[i].ToLower()].Add(args[i + 1]);
                    if (Int32.TryParse(args[i + 1], out int c))
                    {
                        if (c >= 10 && c <= 100) continue;
                        else invalidKey = true;
                    }
                    else
                    {
                        invalidKey = true;
                        invalidParam = true;
                    }
                }
                else
                    invalidKey = true;

            }
            else if (args[i].ToLower() == "--name")
            {
                if (args.Length > i + 1)
                {
                    dic[args[i].ToLower()].Add(args[i + 1]);
                    int c = args[i + 1].Length;
                    if (c >= 3 && c <= 10) continue;
                    else
                    {
                        invalidKey = true;
                        // invalidParam = true;
                    }
                }
                else
                    invalidKey = true;
            }

        }
        else
        {
            invalidKey = true;
        }
    }

    if (dic["--help"].Count() > 0 && invalidParam == false) return 1;

    if (invalidKey) return -1;
    return 0;
}


int GetTaskIndexAtCycle(int[] jobs, int[] dependencies, int cycle)
{
    var x = new HashSet<(int, int)>();
    var executed = new HashSet<int>();
    var ordered = jobs.Select((val, index) => new { val, index }).OrderBy(x => x.val);
    int sum = 0;
    foreach (var item in ordered)
    {
        int d = dependencies.ElementAt(item.index);
        if (d != -1)
        {
            x.Add((item.index, item.val));
            continue;
        }

        sum += item.val;
        if (cycle <= sum)
        {
            return item.index;
        }
        executed.Add(item.index);
        if (x.Any())
        {
            var first = x.First();

            if (executed.Contains(dependencies[first.Item1]))
            {
                executed.Add(first.Item1);
                sum += first.Item2;
                if (cycle <= sum)
                {
                    return first.Item1;
                }
                x.Remove(first);
            }

        }
    }
    return 0;
}

int GetTaskIndexAtCycle_first(int[] jobs, int cycle)
{
    var ordered = jobs.Select((val, index) => new { val, index }).OrderBy(x => x.val);
    int sum = 0;
    foreach (var item in ordered)
    {
        sum += item.val;
        if (cycle <= sum)
        {
            return item.index;
        }
    }

    return 0;
}

int solution(int[] A)
{
    int result = 1;
    var ordered = A.Distinct().OrderBy(x => x);

    foreach (var item in ordered)
    {
        if (item > result) break;
        else
        {
            result++;
        }
    }
    return result;
}

void Rotate(int[][] matrix)
{
    var matrix2 = new int[matrix.Length, matrix.Length];
    int last = matrix.Length - 1;
    for (int i = 0; i < matrix.Length; i++)
    {
        for (int j = 0; j < matrix[0].Length; j++)
        {
            matrix2[j, last] = matrix[i][j];
        }
        last--;
    }
    for (int i = 0; i < matrix.Length; i++)
    {
        for (int j = 0; j < matrix.Length; j++)
        {
            matrix[i][j] = matrix2[i, j];
        }
    }
}

IList<IList<int>> PermuteUnique(int[] nums)
{
    var result = new List<IList<int>>();
    var added = new HashSet<string>();
    backtrack(new List<(int, int)>());
    void backtrack(List<(int, int)> candidate)
    {
        if (candidate.Count == nums.Length)
        {
            string key = string.Join(",", candidate.Select(x => x.Item2));
            if (!added.Contains(key))
            {
                result.Add(new List<int>(candidate.Select(x => x.Item2)));
                added.Add(key);
            }
        }
        else
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (candidate.Any(x => x.Item1 == i)) continue;
                else
                {
                    candidate.Add((i, nums[i]));
                    backtrack(candidate);
                    candidate.RemoveAt(candidate.Count - 1);
                }
            }
        }
    }

    return result;
}

IList<IList<int>> Permute(int[] nums)
{
    var result = new List<IList<int>>();
    backtrack(new List<int>());
    void backtrack(List<int> candidate)
    {
        if (candidate.Count() == nums.Length)
            result.Add(new List<int>(candidate));
        else
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (candidate.Contains(nums[i])) continue;
                candidate.Add(nums[i]);
                backtrack(candidate);
                candidate.RemoveAt(candidate.Count() - 1);
            }
        }
    }
    return result;
}

//TODO
int JumpGame2(int[] nums)
{
    if (nums.Length == 0 || nums[0] == 0) return 0;
    int current = nums[0];
    int result = 1;
    next(0, nums[0]);
    void next(int current, int step)
    {
        if (current + step >= nums.Length - 1) return;
        int max = -1;
        int maxIndex = 0;
        for (int i = current + 1; i < current + step; i++)
        {
            if (nums[i] > max)
            {
                max = nums[i];
                maxIndex = i;
            }
        }

        result++;
        next(maxIndex, nums[maxIndex]);
    }
    return result;
}

bool WildcardMatching(string s, string p)
{
    int i = 0, j = 0;
    int lastMatch_i = -1, star_j = -1;

    while (i < s.Length)
    {
        if (j < p.Length && (s[i] == p[j] || p[j] == '?'))
        {
            i++; j++;
        }
        else if (j < p.Length && p[j] == '*')
        {
            star_j = j;
            j++;
            lastMatch_i = i;
        }
        else if (star_j != -1)
        {
            j = star_j + 1;
            lastMatch_i++;
            i = lastMatch_i;
        }
        else return false;
    }
    while (j < p.Length && p[j] == '*') j++;
    return j == p.Length;
}

string Multiply(string num1, string num2)
{
    var result = new int[num1.Length + num2.Length];
    for (int i = num1.Length - 1; i >= 0; i--)
    {
        for (int j = num2.Length - 1; j >= 0; j--)
        {
            int t = Int32.Parse(num1[i].ToString()) * Int32.Parse(num2[j].ToString()) + result[i + j + 1];
            result[i + j] += t / 10;
            result[i + j + 1] = t % 10;
        }
    }

    var sb = new StringBuilder();
    foreach (var item in result)
    {
        if (sb.Length == 0 && item == 0) continue;
        else sb.Append(item.ToString());
    }
    return sb.Length == 0 ? "0" : sb.ToString();
}

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

int FirstMissingPositive(int[] nums)
{
    Array.Sort(nums);
    int lastJ = 0;
    int result = nums.Length;
    for (int i = 1; i <= nums.Length; i++)
    {
        for (int j = lastJ; j < nums.Length; j++)
        {
            if (nums[j] == i)
            {
                lastJ = j + 1;
                result = i + 1;
                break;
            }
            else if (nums[j] < i)
            {
                result = i;
                lastJ = j + 1;
                continue;
            }
            else if (nums[j] > i) return i;
        }
    }
    return result;
}

IList<IList<int>> CombinationSum2(int[] candidates, int target)
{
    Array.Sort(candidates);
    var result = new List<IList<int>>();

    void backtrack(List<int> cur, int i)
    {
        int sum = cur.Sum();
        if (sum == target)
        {
            result.Add(new List<int>(cur));
            return;
        }
        else if (sum > target || i >= candidates.Length)
            return;

        int prev = -1;
        for (int j = i; j < candidates.Length; j++)
        {
            if (candidates[j] == prev) continue;
            cur.Add(candidates[j]);
            backtrack(cur, j + 1);
            cur.RemoveAt(cur.Count - 1);
            prev = candidates[j];
        }
    }
    backtrack(new List<int>(), 0);
    return result;
}

IList<IList<int>> CombinationSum(int[] candidates, int target)
{
    var result = new List<IList<int>>();
    dfs(0, new List<int>());
    void dfs(int i, List<int> cur)
    {
        int sum = cur.Sum();
        if (sum == target)
        {
            result.Add(new List<int>(cur));
            return;
        }
        else if (sum > target || i >= candidates.Length)
            return;

        cur.Add(candidates[i]);
        dfs(i, cur);
        cur.RemoveAt(cur.Count - 1);
        dfs(i + 1, cur);
    }

    return result;
}

void SolveSudoku(char[][] board)
{
    var addedCoordinates = new Stack<(int, int)>();
    var addedValues = new Stack<char>();
    int start = 1;
    for (int i = 0; i < board.Length; i++)
    {
        start = 1;
        for (int j = 0; j < board[0].Length; j++)
        {
            if (board[i][j] != '.') continue;

            char candidate = GetNewValueToSudoku(i, j, board, start);
            if (candidate == '.')
            {
                var lastCoordinate = addedCoordinates.Pop();
                var lastAddedValue = addedValues.Pop();
                start = Int32.Parse(lastAddedValue.ToString());
                start++;
                i = lastCoordinate.Item1;
                j = lastCoordinate.Item2;
                board[i][j] = '.';
                j--;
            }
            else
            {
                addedCoordinates.Push((i, j));
                addedValues.Push(candidate);
                board[i][j] = candidate;
                start = 1;
            }
        }
    }
}

char GetNewValueToSudoku(int x, int y, char[][] board, int start)
{
    if (start > 9) return '.';
    var column = new HashSet<char>();
    for (int i = 0; i < 9; i++)
    {
        if (!column.Contains(board[i][y]) && board[i][y] != '.') column.Add(board[i][y]);
    }

    var row = new HashSet<char>();
    for (int i = 0; i < 9; i++)
    {
        if (!row.Contains(board[x][i]) && board[x][i] != '.') row.Add(board[x][i]);
    }

    var TripleCube = new HashSet<char>();
    int startX = (x / 3) * 3;
    int startY = (y / 3) * 3;
    for (int i = startX; i < startX + 3; i++)
    {
        for (int j = startY; j < startY + 3; j++)
        {
            if (!TripleCube.Contains(board[i][j]) && board[i][j] != '.') TripleCube.Add(board[i][j]);
        }
    }

    for (int k = start + 48; k <= 57; k++)
    {
        char candidate = Convert.ToChar(k);
        if (!TripleCube.Contains(candidate) && !row.Contains(candidate) && !column.Contains(candidate))
            return candidate;
    }
    return '.';
}

bool IsValidSudoku(char[][] board)
{
    //check line by line
    var hashSet = new HashSet<char>();
    for (int i = 0; i < board.Length; i++)
    {
        hashSet.Clear();
        for (int j = 0; j < board[0].Length; j++)
        {
            if (board[i][j] == '.') continue;
            if (hashSet.Contains(board[i][j])) return false;
            else hashSet.Add(board[i][j]);
        }
    }
    hashSet.Clear();

    //check column by column
    for (int i = 0; i < board.Length; i++)
    {
        hashSet.Clear();
        for (int j = 0; j < board[0].Length; j++)
        {
            if (board[j][i] == '.') continue;
            if (hashSet.Contains(board[j][i])) return false;
            else hashSet.Add(board[j][i]);
        }
    }
    hashSet.Clear();

    // check 3x3
    bool CheckThreeXThree(int x, int y, char[][] board)
    {
        var hashSet = new HashSet<int>();
        for (int i = x; i < x + 3; i++)
        {
            for (int j = y; j < y + 3; j++)
            {
                if (board[i][j] == '.') continue;
                if (hashSet.Contains(board[i][j])) return false;
                else hashSet.Add(board[i][j]);
            }
        }
        if (x == 6 && y == 6) return true;
        if (x == 6)
        {
            x = 0;
            return CheckThreeXThree(x, y + 3, board);
        }
        else
            return CheckThreeXThree(x + 3, y, board);
    }

    var isValid3x3 = CheckThreeXThree(0, 0, board);
    return isValid3x3;
}

int SearchInsert(int[] nums, int target)
{
    if (nums[nums.Length - 1] < target) return nums.Length;
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] >= target) return i;
    }
    return -1;
}

int[] SearchRange(int[] nums, int target)
{
    var result = nums.Select((x, i) => x == target ? i : -1).Where(x => x != -1);
    if (result.Count() == 1) return new[] { result.First(), result.First() };
    if (result.Any()) return new[] { result.First(), result.Last() };
    else return new int[] { -1, -1 };
}

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

int LongestValidParentheses(string s)
{
    int ans = 0;
    var st = new Stack<int>();
    st.Push(-1);
    for (int i = 0; i < s.Length; i++)
    {
        if (s[i] == '(')
            st.Push(i);
        else if (s[i] == ')')
        {
            st.Pop();
            if (st.Count == 0)
                st.Push(i);
            ans = Math.Max(ans, i - st.Peek());
        }
    }
    return ans;
}

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

IList<int> FindSubstring(string s, string[] words)
{
    var result = new List<int>();
    if (words.Length == 0) return result;

    int n = words.Length, len = words[0].Length;
    var expect = new Dictionary<string, int>();
    foreach (var word in words)
    {
        if (expect.ContainsKey(word)) expect[word]++;
        else expect.Add(word, 1);
    }

    var seen = new Dictionary<string, int>();
    for (int i = 0; i < s.Length - n * len + 1; i++)
    {
        seen.Clear();
        int count = 0;
        while (count < n)
        {
            string curr = s.Substring(i + count * len, len);
            if (expect.ContainsKey(curr))
            {
                if (seen.ContainsKey(curr)) seen[curr]++;
                else seen.Add(curr, 1);

                if (seen[curr] > expect[curr])
                    break;
            }
            else
                break;
            count++;
        }
        if (count == n) result.Add(i);
    }
    return result;
}

int[] solutionExceptionally(string jsonData)
{

    //var bedrooms = JsonConvert.DeserializeObject<List<bedroom>>(jsonData);
    var bedrooms = new List<bedroom>(); // deserialize kapattildigi icin new koyuldu
    var result = new List<int>();
    for (int i = 0; i < bedrooms.Count; i++)
    {
        var item = bedrooms[i];
        if (item.description.Contains("1-bedroom") || item.description.Contains("studio"))
        {
            var l = item.description.Split(" ").ToList();
            var bedroom1 = l.Where(x => x.Contains("1-bedroom")).Select((x, i) => i);
            var yoga = l.Where(x => x == "yoga").Select((x, i) => i);
            var dans = l.Where(x => x == "dans").Select((x, i) => i);
            var art = l.Where(x => x == "art").Select((x, i) => i);
            var studio = l.Where(x => x == "studio").Select((x, i) => i);

            if (bedroom1.Count() > 0)
            {

                result.Add(1);
            }
            else
            {
                result.Add(0);
            }

        }
        else
            result.Add(item.num_bedrooms);
    }


    return result.ToArray();
}

int Divide(int dividend, int divisor)
{
    decimal quotient = (decimal)dividend / (decimal)divisor;
    if (quotient >= 0)
    {
        decimal f = Math.Floor(quotient);
        if (f > Int32.MaxValue) return Int32.MaxValue;
        else return (int)f;
    }
    else
    {
        decimal c = Math.Ceiling(quotient);
        if (c < Int32.MinValue) return Int32.MinValue;
        else return (int)c;
    }
}

int StrStr(string haystack, string needle)
{
    if (string.IsNullOrEmpty(needle)) return 0;
    int result = haystack.IndexOf(needle);
    return result;
}

ListNode ReverseKGroup(ListNode head, int k)
{
    var flat = new List<int>();

    void generateFlatList(ListNode n)
    {
        if (n == null) return;
        flat.Add(n.val);
        generateFlatList(n.next);
    }
    generateFlatList(head);

    if (flat.Count == 0) return null;
    var reverseList = new List<int>();
    for (int i = 0; i < flat.Count && i + k - 1 < flat.Count; i += k)
    {
        var temp = flat.GetRange(i, k);
        temp.Reverse();
        reverseList.AddRange(temp);
    }

    for (int i = ((flat.Count / k) * k); i < flat.Count; i++)
    {
        reverseList.Add(flat[i]);
    }
    var result = new ListNode(reverseList[0]);
    reverseList.RemoveAt(0);
    void generateListNodeFromFlatList(List<int> l, ListNode n)
    {
        if (l.Count == 0) return;
        n.next = new ListNode(l[0]);
        l.RemoveAt(0);
        generateListNodeFromFlatList(l, n.next);
    }
    generateListNodeFromFlatList(reverseList, result);

    return result;
}

ListNode SwapPairs(ListNode head)
{
    var flat = new List<int>();

    void generateFlatListFromNode(ListNode n)
    {
        if (n == null) return;
        flat.Add(n.val);
        generateFlatListFromNode(n.next);
    }
    generateFlatListFromNode(head);
    if (flat.Count == 0) return null;
    for (int i = 0; i < flat.Count - 1; i += 2)
    {
        int swap = flat[i];
        flat[i] = flat[i + 1];
        flat[i + 1] = swap;
    }

    var result = new ListNode(flat[0]);
    flat.RemoveAt(0);
    void generateNodeFromFlatList(List<int> l, ListNode _result)
    {
        if (l.Count == 0) return;
        _result.next = new ListNode(l[0]);
        l.RemoveAt(0);
        generateNodeFromFlatList(l, _result.next);
    }
    generateNodeFromFlatList(flat, result);

    return result;
}

ListNode MergeKLists(ListNode[] lists)
{
    var flatList = new List<int>();

    foreach (var item in lists)
    {
        flatListFromKLists(item);
    }

    void flatListFromKLists(ListNode list)
    {
        if (list == null) return;
        flatList.Add(list.val);
        flatListFromKLists(list.next);
    }
    flatList.Sort();
    if (flatList.Count == 0) return null;
    var result = new ListNode(flatList[0]);
    flatList.RemoveAt(0);
    void generateResultFromFlatList(List<int> l, ListNode _result)
    {
        if (l.Count == 0) return;
        _result.next = new ListNode(l[0]);
        l.RemoveAt(0);
        generateResultFromFlatList(l, _result.next);
    }
    generateResultFromFlatList(flatList, result);

    return result;
}

ListNode MergeTwoLists(ListNode list1, ListNode list2)
{
    var list = new List<int>();
    void generateFlatList(ListNode l1, ListNode l2)
    {
        if (l1 != null) list.Add(l1.val);
        if (l2 != null) list.Add(l2.val);
        if (l1 == null && l2 == null) return;
        generateFlatList(l1?.next, l2?.next);
    }
    generateFlatList(list1, list2);
    if (list.Count == 0) return null;
    list = list.OrderBy(x => x).ToList();
    var result = new ListNode(list[0]);
    list.RemoveAt(0);
    void generateNodeFromFlatList(List<int> flatList, ListNode _result)
    {
        if (flatList.Count == 0) return;
        _result.next = new ListNode(flatList[0]);
        flatList.RemoveAt(0);
        generateNodeFromFlatList(flatList, _result.next);
    }
    generateNodeFromFlatList(list, result);
    return result;
}

bool IsValid(string s)
{
    var dic = new Dictionary<char, char> { { '}', '{' }, { ')', '(' }, { ']', '[' } };
    var open = new HashSet<char>() { '{', '(', '[' };
    var q = new Stack<char>();

    for (int i = 0; i < s.Length; i++)
    {
        if (open.Contains(s[i]))
            q.Push(s[i]);
        else
        {
            if (q.Count == 0) return false;
            if (q.Pop() == dic[s[i]])
                continue;
            else return false;
        }
    }
    if (q.Count == 0) return true;
    else return false;
}

ListNode RemoveNthFromEnd(ListNode head, int n)
{
    int count = 1;
    var flatList = new List<int>();
    void Flat(ListNode node)
    {
        flatList.Add(node.val);
        if (node.next != null)
            Flat(node.next);
    }
    Flat(head);

    flatList.RemoveAt(flatList.Count - n);
    if (flatList.Count == 0) return null;
    var result = new ListNode();
    result.val = flatList[0];
    flatList.RemoveAt(0);
    void Generate(ListNode node, List<int> l)
    {
        if (l.Count == 0) return;
        node.next = new ListNode(l[0]);
        l.RemoveAt(0);
        Generate(node.next, l);
    }

    Generate(result, flatList);
    return result;
}

IList<IList<int>> FourSum(int[] nums, int target)
{
    if (nums.Length < 4) return new List<IList<int>>();
    Array.Sort(nums);
    var finds = new Dictionary<string, IList<int>>();
    for (int i = 0; i < nums.Length - 3; i++)
    {
        for (int j = i + 1; j < nums.Length - 2; j++)
        {
            int left = j + 1, right = nums.Length - 1;
            while (left < right)
            {
                long subSum = (long)nums[i] + (long)nums[j] + (long)nums[left] + (long)nums[right];
                if (subSum == target)
                {
                    var find = new List<int>() { nums[i], nums[j], nums[left], nums[right] };
                    string key = string.Join("", find);
                    if (!finds.ContainsKey(key)) finds.Add(key, find);
                    left++;
                    right--;
                }
                else if (subSum < target)
                    left++;
                else
                    right--;
            }
        }
    }
    return finds.Select(x => x.Value).ToList();
}

IList<string> LetterCombinations(string digits)
{
    var dic = new Dictionary<char, string>
    {
        { '2', "abc" },{ '3', "def" },{ '4', "ghi" },{ '5', "jkl" },{ '6', "mno" },{ '7', "pqrs" },{ '8', "tuv" },{ '9', "wxyz" },
    };
    var result = new List<string>();
    if (digits.Length == 0) return result;
    dfs(0, new StringBuilder());
    void dfs(int i, StringBuilder currentStr)
    {
        if (currentStr.Length == digits.Length)
        {
            result.Add(currentStr.ToString());
            return;
        }
        foreach (var item in dic[digits[i]])
        {
            currentStr.Append(item.ToString());
            dfs(i + 1, currentStr);
            currentStr.Remove(currentStr.Length - 1, 1);
        }
    }
    return result;
}

int ThreeSumClosest(int[] nums, int target)
{
    int minSum = nums[0] + nums[1] + nums[2];
    if (nums.Length == 3) return minSum;
    Array.Sort(nums);
    int min = Math.Abs(target - minSum);
    for (int i = 0; i < nums.Length - 2; i++)
    {
        int left = i + 1, right = nums.Length - 1;
        while (left < right)
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

IList<IList<int>> ThreeSum(int[] nums)
{
    //var finds = new List<IList<int>>();
    var finds = new Dictionary<string, IList<int>>();
    Array.Sort(nums);
    for (int i = 0; i < nums.Length - 2; i++)
    {
        int left = i + 1, right = nums.Length - 1;

        while (left < right)
        {
            if (nums[i] + nums[left] + nums[right] == 0)
            {
                var triple = new List<int> { nums[i], nums[left], nums[right] };
                var key = string.Join("", triple);
                if (!finds.ContainsKey(key))
                    finds.Add(key, triple);
                left++;
                right--;
            }
            else if (nums[i] + nums[left] + nums[right] > 0)
                right--;
            else
                left++;
        }

    }

    return finds.Select(x => x.Value).ToList();
}

int PeopleAwareOfSecret(int n, int delay, int forget)
{
    Dictionary<int, long> add = new();
    Dictionary<int, long> remove = new();
    int MOD = 1000000007;

    if (forget <= delay)
        return n >= forget ? 0 : 1;

    long count = 1;
    add[delay] = 1;
    remove[forget] = 1;

    long increase = 0;
    for (int i = 0; i < n; i++)
    {
        if (add.ContainsKey(i))
            increase += add[i] % MOD;

        if (remove.ContainsKey(i))
        {
            increase -= remove[i] % MOD;
            count -= remove[i] % MOD;
        }

        if (increase > 0)
        {
            count = count + increase;
            add[i + delay] = increase;
            remove[i + forget] = increase;

        }
    }

    return (int)(count % MOD);
}

int PeopleAwareOfSecretA(int n, int delay, int forget)
{
    var x = new int[2];
    int mod = 1000000007;
    var dic = new ConcurrentDictionary<int, int>();
    if (n < 0) return 0;
    dic.TryAdd(1, 1);
    int count = 1;
    for (int i = 2; i <= n; i++)
    {
        int j = dic.Count() - 1;
        while (j >= 0)
        {
            dic[dic.ElementAt(j).Key] = dic.ElementAt(j).Value + 1;
            if (dic.ElementAt(j).Value > forget)
            {
                dic.TryRemove(dic.ElementAt(j).Key, out int _);
                j--;
                continue;
            }
            if (dic.ElementAt(j).Value > delay)
            {
                count++;
                dic.TryAdd(count, 1);
            }
            j--;
        }
    }

    return dic.Count() % mod;
}

int[][] SpiralMatrix(int m, int n, ListNode head)
{
    int[][] matrix = new int[m][];

    for (int k = 0; k < m; k++)
    {
        for (int l = 0; l < n; l++)
        {
            if (matrix[k] == null) matrix[k] = new int[n];
            matrix[k][l] = -1;
        }
    }
    int rowStart = 0, rowEnd = m - 1;
    int colStart = 0, colEnd = n - 1;

    while (rowStart <= rowEnd && colStart <= colEnd)
    {
        for (int i = colStart; i <= colEnd; i++)
        {
            if (head == null) return matrix;
            matrix[rowStart][i] = head.val;
            head = head.next;
        }
        rowStart++;

        for (int i = rowStart; i <= rowEnd; i++)
        {
            if (head == null) return matrix;
            matrix[i][colEnd] = head.val;
            head = head.next;
        }
        colEnd--;

        for (int i = colEnd; i >= colStart; i--)
        {
            if (rowStart <= rowEnd)
            {
                if (head == null) return matrix;
                matrix[rowEnd][i] = head.val;
                head = head.next;
            }
        }
        rowEnd--;

        for (int i = rowEnd; i >= rowStart; i--)
        {
            if (colStart <= colEnd)
            {
                if (head == null) return matrix;
                matrix[i][colStart] = head.val;
                head = head.next;
            }
        }
        colStart++;
    }

    return matrix;
}

int CountPaths(int[][] grid)
{
    long count = 0;
    var visited = new int[grid.Length, grid[0].Length];

    for (int i = 0; i < grid.Length; i++)
    {
        for (int j = 0; j < grid[0].Length; j++)
        {
            if (visited[i, j] == 0)
                dfsCountPaths(grid, i, j, visited);

            count += (int)(visited[i, j] % 1000000007);
        }
    }

    return (int)(count % 1000000007);
}

long dfsCountPaths(int[][] grid, int k, int l, int[,] visited)
{
    if (k < 0 || l < 0 || k > grid.Length || l > grid[0].Length) return 0;

    if (visited[k, l] == 0)
    {
        long localCount = 1;
        if (k + 1 < grid.Length && grid[k][l] < grid[k + 1][l])
            localCount += dfsCountPaths(grid, k + 1, l, visited);
        if (k - 1 >= 0 && grid[k][l] < grid[k - 1][l])
            localCount += dfsCountPaths(grid, k - 1, l, visited);
        if (l + 1 < grid[0].Length && grid[k][l] < grid[k][l + 1])
            localCount += dfsCountPaths(grid, k, l + 1, visited);
        if (l - 1 >= 0 && grid[k][l] < grid[k][l - 1])
            localCount += dfsCountPaths(grid, k, l - 1, visited);
        visited[k, l] = (int)(localCount % 1000000007);
    }
    return visited[k, l];
}

string LongestCommonPrefix(string[] strs)
{
    string longestCommonPrefix = string.Empty;

    for (int j = 1; j <= strs[0].Length; j++)
    {
        string s = strs[0].Substring(0, j);
        if (strs.Count(x => x.StartsWith(s)) == strs.Count())
        {
            if (s.Length > longestCommonPrefix.Length)
                longestCommonPrefix = s;
        }
        else { break; }
    }

    return longestCommonPrefix;
}

int RomanToInt(string s)
{
    var dic = new Dictionary<char, int>();
    dic.Add('I', 1);
    dic.Add('V', 5);
    dic.Add('X', 10);
    dic.Add('L', 50);
    dic.Add('C', 100);
    dic.Add('D', 500);
    dic.Add('M', 1000);
    int result = 0;
    s = s.Replace("IV", "IIII").Replace("IX", "VIIII");
    s = s.Replace("XL", "XXXX").Replace("XC", "LXXXX");
    s = s.Replace("CD", "CCCC").Replace("CM", "DCCCC");
    for (int i = 0; i < s.Length; i++)
    {
        result += dic[s[i]];
    }
    return result;
}

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
            if (num == 4)
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


ListNode GenerateListNodeFromArray(int[] nodes)
{
    if (nodes.Length == 0) return null;
    var result = new ListNode();
    result.val = nodes[0];
    if (nodes.Length > 1)
    {
        var subArray = nodes.ToList().GetRange(1, nodes.Length - 1).ToArray();
        result.next = GenerateListNodeFromArray(subArray);
    }
    return result;
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
class bedroom
{
    public string id { get; set; }
    public string description { get; set; }
    public string unit { get; set; }
    public string agent { get; set; }
    public int num_bedrooms { get; set; }
}

*/