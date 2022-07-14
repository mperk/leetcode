# valid-sudoku
**Solution**
```
bool IsValidSudoku(char[][] board)
{
    //check row by row
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
```