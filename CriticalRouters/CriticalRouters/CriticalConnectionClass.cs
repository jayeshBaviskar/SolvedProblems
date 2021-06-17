using System;
using System.Collections.Generic;
using System.Linq;

namespace CriticalRouters
{
    internal class CriticalConnectionClass
    {
        private int time = 0;
        private List<List<int>> ret = new List<List<int>>();

        public List<List<int>> CriticalConnections(int n, List<List<int>> connections)
        {
            var low = new int[n];
            var visited = new int[n];
            visited = Enumerable.Repeat(-1, n).ToArray();

            var dict = new Dictionary<int, List<int>>();
            foreach (var val in connections)
            {
                --val[0];
                --val[1];

                if (!dict.ContainsKey(val[0]))
                    dict.Add(val[0], new List<int>());
                dict[val[0]].Add(val[1]);
                if (!dict.ContainsKey(val[1]))
                    dict.Add(val[1], new List<int>());
                dict[val[1]].Add(val[0]);
            }
            for (int i = 0; i < n; i++)
            {
                if (visited[i] == -1)
                    dfs(i, low, visited, dict, i);
            }
            return ret;
        }

        private void dfs(int u, int[] low, int[] visited, Dictionary<int, List<int>> dict, int pre)
        {
            visited[u] = ++time;
            low[u] = time;
            if (dict.ContainsKey(u))
            {
                for (int j = 0; j < dict[u].Count; j++)
                {
                    int v = dict[u][j];
                    if (v == pre)
                        continue;
                    if (visited[v] == -1)
                    {
                        dfs(v, low, visited, dict, u);
                        low[u] = Math.Min(low[v], low[u]);
                        if (low[v] > visited[u])
                        {
                            ret.Add(new List<int> { u, v });
                        }
                    }
                    else
                    {
                        low[u] = Math.Min(low[u], visited[v]);
                    }
                }
            }
        }
    }
}