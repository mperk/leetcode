# number-of-increasing-paths-in-a-grid
**Solution**
```
///https://leetcode.com/problems/number-of-increasing-paths-in-a-grid/discuss/2230149/C-oror-DFS-%2B-DP
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
            
            count += (int)(visited[i,j] % 1000000007);
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
            localCount += dfsCountPaths(grid, k+1, l, visited);
        if (k - 1 >= 0 && grid[k][l] < grid[k - 1][l])
            localCount += dfsCountPaths(grid, k-1, l, visited);
        if (l + 1 < grid[0].Length && grid[k][l] < grid[k][l +1])
            localCount += dfsCountPaths(grid, k, l + 1, visited);
        if (l - 1 >= 0 && grid[k][l] < grid[k][l - 1])
            localCount += dfsCountPaths(grid, k, l - 1, visited);
        visited[k, l] = (int)(localCount % 1000000007);
    }
    return visited[k, l];
}
```