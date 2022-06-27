
//Console.WriteLine(NumberOfCities(new List<int>() { 9, 1, 4, 9, 0, 4, 8, 9, 0, 1 }));

//Console.WriteLine(JohnTravelsToAnotherCity(new int[] { 29, 50 }, new int[] { 61, 37 }, new int[] { 37, 70 }));
//Console.WriteLine(JohnTravelsToAnotherCity(new int[] { 29,29 }, new int[] { 61, 61 }, new int[] { 70, 70 }));

//Console.WriteLine(TwoCitySchedCost(new int[][] { new int[] { 10, 20 }, new int[] { 30, 200 }, new int[] { 400, 50 },new int[] { 30, 20 } }));
//Console.WriteLine(UpdateBoard(new char[][] { 
//    new char[] { 'E', 'E', 'E', 'E', 'E' }, 
//    new char[] { 'E', 'E', 'M', 'E', 'E' },
//    new char[] { 'E', 'E', 'E', 'E', 'E' },
//    new char[] { 'E', 'E', 'E', 'E', 'E' } }, new int[] { 3, 0 }));

Console.WriteLine(ReformatNumber("1222"));
Console.ReadLine();


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
