using System;
using System.Collections.Generic;
using System.Text;

namespace MunicipalServicesApp
{
    public class Edge
    {
        public string Destination { get; set; }
        public int Weight { get; set; } // Distance in kilometers

        public Edge(string dest, int weight)
        {
            Destination = dest;
            Weight = weight;
        }
    }

    public class MunicipalGraph
    {
        private Dictionary<string, List<Edge>> adjacencyList = new Dictionary<string, List<Edge>>();

        public MunicipalGraph()
        {
            SeedDefaultNetwork();
        }

        public void AddLocation(string location)
        {
            if (!adjacencyList.ContainsKey(location))
                adjacencyList[location] = new List<Edge>();
        }

        public void AddConnection(string source, string dest, int weight)
        {
            AddLocation(source);
            AddLocation(dest);
            adjacencyList[source].Add(new Edge(dest, weight));
            adjacencyList[dest].Add(new Edge(source, weight));
        }

        private void SeedDefaultNetwork()
        {
            AddConnection("Central Municipal Depot", "Ward 1 Hub (East)", 8);
            AddConnection("Central Municipal Depot", "Ward 2 Hub (West)", 12);
            AddConnection("Central Municipal Depot", "Ward 4 Hub (North)", 15);
            AddConnection("Ward 1 Hub (East)", "Sector 3 Industrial", 5);
            AddConnection("Ward 2 Hub (West)", "Sector 3 Industrial", 9);
            AddConnection("Ward 2 Hub (West)", "Ward 8 Health Clinic", 7);
            AddConnection("Ward 4 Hub (North)", "Ward 12 Community Center", 11);
            AddConnection("Sector 3 Industrial", "Ward 12 Community Center", 6);
        }

        public string BFS(string startNode)
        {
            if (!adjacencyList.ContainsKey(startNode)) return "Start location not found in network.";

            StringBuilder sb = new StringBuilder();
            HashSet<string> visited = new HashSet<string>();
            Queue<string> queue = new Queue<string>();

            visited.Add(startNode);
            queue.Enqueue(startNode);

            while (queue.Count > 0)
            {
                string current = queue.Dequeue();
                sb.Append(current + "  ==>  ");

                foreach (var edge in adjacencyList[current])
                {
                    if (!visited.Contains(edge.Destination))
                    {
                        visited.Add(edge.Destination);
                        queue.Enqueue(edge.Destination);
                    }
                }
            }

            string result = sb.ToString();
            return result.Substring(0, result.Length - 7);
        }

        public string DFS(string startNode)
        {
            if (!adjacencyList.ContainsKey(startNode)) return "Start location not found in network.";

            StringBuilder sb = new StringBuilder();
            HashSet<string> visited = new HashSet<string>();
            
            DFSRec(startNode, visited, sb);
            string result = sb.ToString();
            return result.Substring(0, result.Length - 7);
        }

        private void DFSRec(string current, HashSet<string> visited, StringBuilder sb)
        {
            visited.Add(current);
            sb.Append(current + "  ==>  ");

            foreach (var edge in adjacencyList[current])
            {
                if (!visited.Contains(edge.Destination))
                {
                    DFSRec(edge.Destination, visited, sb);
                }
            }
        }

        public string GetMinimumSpanningTree(string startNode)
        {
            if (!adjacencyList.ContainsKey(startNode)) return "Start location not found in network.";

            StringBuilder sb = new StringBuilder();
            HashSet<string> inMST = new HashSet<string>();
            int totalWeight = 0;

            inMST.Add(startNode);
            sb.AppendLine($"--- PRIM'S MINIMUM SPANNING TREE (MST) OPTIMIZED ROUTE ---");
            sb.AppendLine($"Root Depot Node: {startNode}");

            while (inMST.Count < adjacencyList.Count)
            {
                Edge minEdge = null;
                string nextNode = null;
                string fromNode = null;
                int minWeight = int.MaxValue;

                foreach (string node in inMST)
                {
                    foreach (Edge edge in adjacencyList[node])
                    {
                        if (!inMST.Contains(edge.Destination) && edge.Weight < minWeight)
                        {
                            minWeight = edge.Weight;
                            minEdge = edge;
                            fromNode = node;
                            nextNode = edge.Destination;
                        }
                    }
                }

                if (minEdge == null) break;

                inMST.Add(nextNode);
                totalWeight += minWeight;
                sb.AppendLine($"[Connected Route] {fromNode}  <----->  {nextNode} | Distance: {minWeight} km");
            }

            sb.AppendLine($"=======================================================");
            sb.AppendLine($"TOTAL MINIMUM INFRASTRUCTURE COVERAGE DISTANCE: {totalWeight} km");
            sb.AppendLine($"=======================================================");
            return sb.ToString();
        }

        public List<string> GetAllLocations()
        {
            return new List<string>(adjacencyList.Keys);
        }
    }
}
