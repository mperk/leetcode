# spiral-matrix-iv
**Solution**
```
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

    while(rowStart <= rowEnd && colStart <= colEnd)
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
            if(rowStart <= rowEnd)
            {
                if (head == null) return matrix;
                matrix[rowEnd][i] = head.val;
                head = head.next;
            }
        }
        rowEnd--;

        for (int i = rowEnd; i >= rowStart; i--)
        {
            if(colStart <= colEnd)
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
```