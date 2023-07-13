namespace DSA;

public class GraphTraversal {
    public static void DFS(Dictionary<int, IList<int>> graph, int current, HashSet<int> visited) {
        if (visited.Contains(current)) {
            return;
        }

        visited.Add(current);

        Console.Write($"{current} ");
        
        foreach (int next in graph[current]) {
            DFS(graph, next, visited);
        }
    }
    
    public static void BFS(Dictionary<int, IList<int>> graph, int node) {
        Queue<int> q = new Queue<int>();
        HashSet<int> visited = new HashSet<int>();

        q.Enqueue(node);
        visited.Add(node);
        
        while (q.Count > 0) {
            int currNode = q.Dequeue();
            Console.Write($"{currNode} ");
            foreach (int next in graph[currNode]) {
                if (visited.Contains(next)) {
                    continue;
                }

                q.Enqueue(next);
                visited.Add(next);
            }
        }
    }
}
