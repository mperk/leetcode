
Console.WriteLine(NumberOfCities(new List<int>() { 9, 1, 4, 9, 0, 4, 8, 9, 0, 1 }));


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
