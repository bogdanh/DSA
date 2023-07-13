namespace DSA;

public class MatrixTraversal {
    public static void DFS(int[][] matrix, int i, int j, bool[][] visited) {
        if (i < 0 || i >= matrix.Length ||
            j < 0 || j >= matrix[0].Length ||
            visited[i][j]) {
            return;
        }
        
        Console.Write($"{matrix[i][j]} ");
        visited[i][j] = true;
        
        DFS(matrix, i - 1, j, visited);
        DFS(matrix, i + 1, j, visited);
        DFS(matrix, i, j - 1, visited);
        DFS(matrix, i, j + 1, visited);
    }
    
    public static void BFS(int[][] matrix) {
        int[][] dirs = new int[4][] {
            new int[] { 0, 1 },
            new int[] { 0, -1 },
            new int[] { 1, 0 },
            new int[] { -1, 0 }
        };

        Queue<int[]> q = new Queue<int[]>();
        bool[][] visited = new bool[matrix.Length][];
        
        for (int i = 0; i < matrix.Length; i++) {
            visited[i] = new bool[matrix[i].Length];
        }

        
        q.Enqueue(new int[] { 0, 0 });
        visited[0][0] = true;
        
        while (q.Count > 0) {
            int[] currentPos = q.Dequeue();
            foreach (int[] dir in dirs) {
                int nextI = currentPos[0] + dir[0],
                nextJ = currentPos[1] + dir[1];
                
                // check bounds and that we haven't already been here before
                if (nextI < 0 || nextI >= matrix.Length ||
                    nextJ < 0 || nextJ >= matrix[0].Length ||
                    visited[nextI][nextJ]) {
                    continue;
                }

                visited[nextI][nextJ] = true;

                q.Enqueue(new int[] { nextI, nextJ });
            }
        }
    }
}
