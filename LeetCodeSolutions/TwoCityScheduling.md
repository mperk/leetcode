# Two-City-Scheduling
**Solution**
```
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
```