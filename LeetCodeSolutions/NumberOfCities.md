# Number-Of-Cities
Problem Statement
Cities 2 and 4 are connected directly, so the distance between them is 1 . Cities 4 and 7 are connected by a path consisting of the direct roads 4–0, 0–9 and 9–7; hence the distance between them is 3. One of the cities is the capital, and the goal is to count the number of cities positioned away from it at each of the distances 1, 2, 3, …, M- 1. If city number 1 is the capital, then the cities positioned at the various distances from the capital would be as follows:

• 9 is at a distance of 1;
• 0, 3, 7 are at a distance of 2;
• 8,4 are at a distance of 3;
• 2, 5, 6 are at a distance of 4.

We are asked to write a function that, given a non-empty array T consisting of M integers describing a network of M cities and M — 1 roads, returns an array consisting of M — 1 integers, specifying the number of cities positioned at each distance 1, 2, M- 1. Array T describes a network of cities as follows:

    If T[P] = Q and P = Q then P is the capital
    If T[P] = Q and P ≠ Q, then there is a direct road between cities P and Q. For example, given the following array T consisting of ten elements: [9,1,4,9,0,4,8,9,0,1]
    the function should return [1, 3, 2, 3, 0, 0, 0, 0, 0] as explained above

**Solution**
```
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
```