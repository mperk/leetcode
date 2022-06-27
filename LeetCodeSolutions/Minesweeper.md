# Minesweeper

**Solution**
```
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
```