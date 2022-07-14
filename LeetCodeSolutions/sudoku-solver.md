# sudoku-solver
**Solution**
```
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
```