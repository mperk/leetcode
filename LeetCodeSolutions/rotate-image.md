# rotate-image
**Solution**
```
void Rotate(int[][] matrix)
{
    var matrix2 = new int[matrix.Length, matrix.Length];
    int last = matrix.Length - 1;
    for (int i = 0; i < matrix.Length; i++)
    {
        for (int j = 0; j < matrix[0].Length; j++)
        {
           matrix2[j,last] = matrix[i][j];
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
```