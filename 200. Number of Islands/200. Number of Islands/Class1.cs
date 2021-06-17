namespace _200.Number_of_Islands
{
    internal class Class1
    {

        public int NumIslands(char[][] grid)
        {
         

            bool[,] visited = new bool[grid.GetLength(0), grid.GetLength(1)];
            int res = 0;
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i][j] == '1' && !visited[i, j])
                    {
                        DFS(grid, visited, i, j);
                        res++;
                    }
                }
            }
            return res;
        }

        public void DFS(char[][] grid, bool[,] visited, int i, int j)
        {
            if (i < 0 || i >= grid.GetLength(0)) return;
            if (j < 0 || j >= grid.GetLength(1)) return;
            if (grid[i][j] != '1' || visited[i, j]) return;
            visited[i, j] = true;
            DFS(grid, visited, i + 1, j);
            DFS(grid, visited, i - 1, j);
            DFS(grid, visited, i, j + 1);
            DFS(grid, visited, i, j - 1);
        }
    }
}