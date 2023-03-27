using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Lab_15
{
    public class Graph
    {
        public class Node
        {
            public int id;
            public string Name;
            public int x;
            public int y;
            public bool Colored;
            public List<int> Edges;

            public void AddEdge(int id)
            { if (this.id != id && !Edges.Contains(id)) Edges.Add(id); }

            public bool RemoveEdge(int id)
            { return Edges.Remove(id); }
        }

        public List<Node> Nodes = new List<Node>();
        public Dictionary<int, Node> NodeById = new Dictionary<int, Node>();
        private int MaxId = 0;
        public bool directed = false;
        public int SpawnX = 0;
        public int SpawnY = 0;
        public int NodeSize = 30;

        public void AddNode(string name, int x, int y)
        {
            int id = 0;
            for (int i = 1; i <= MaxId + 1; i++)
            {
                bool taken = false;
                foreach (Node n in Nodes)
                {
                    if (n.id == i)
                    { taken = true; break; }
                }
                if (!taken)
                {
                    id = i;
                    if (id > MaxId) MaxId = id;
                    break;
                }
            }
            Node node = new Node();
            node.id = id;
            if (name != null && name != "") node.Name = name;
            else node.Name = id.ToString();
            node.x = x;
            node.y = y;
            node.Edges = new List<int>();
            Nodes.Add(node);
            NodeById.Add(node.id, node);
            Nodes.Sort((n1, n2) => n1.id.CompareTo(n2.id));
        }

        public void AddNode() => AddNode(null, SpawnX, SpawnY);
        public void AddNode(string name) => AddNode(name, SpawnX, SpawnY);
        public void AddNode(int x, int y) => AddNode(null, x, y);

        public void RemoveNode(int id)
        {
            Node removeNode = null;
            foreach (Node node in Nodes)
            {
                node.RemoveEdge(id);
                if (node.id == id) removeNode = node;
            }
            if (removeNode.id == MaxId) MaxId--;
            Nodes.Remove(removeNode);
            NodeById.Remove(removeNode.id);
        }

        public void AddEdge(int src, int dst)
        { NodeById[src].AddEdge(dst); if (!Directed) NodeById[dst].AddEdge(src); }

        public bool RemoveEdge(int src, int dst)
        { return NodeById[src].RemoveEdge(dst) && (!Directed ? NodeById[dst].RemoveEdge(src) : true); }

        public void Save(string path)
        {
            StreamWriter f = new StreamWriter(path);
            try
            {
                f.Write(Directed ? "directed" : "undirected");
                if (Nodes.Count > 0) f.Write("\n");
                for (int i = 0; i < Nodes.Count; i++)
                {
                    string edges = String.Join(";", Nodes[i].Edges.Select(n => n.ToString()));
                    string nodeString = String.Join(",", Nodes[i].id, Nodes[i].Name, Nodes[i].x, Nodes[i].y, edges);
                    f.Write(nodeString);
                    if (i != Nodes.Count - 1) f.Write("\n");
                }
            }
            finally { f.Close(); }
        }

        public void Load(string path)
        {
            StreamReader f = new StreamReader(path);
            try
            {
                Nodes.Clear();
                NodeById.Clear();
                MaxId = 0;
                Directed = f.ReadLine() == "directed";
                while (!f.EndOfStream)
                {
                    string line = f.ReadLine();
                    if (line != null && line != "")
                    {
                        string[] nodeInfo = line.Split(',');
                        if (nodeInfo.Length != 5) throw new FormatException("Структура файла нарушена");
                        Node node = new Node();
                        node.id = int.Parse(nodeInfo[0]);
                        if (MaxId <= node.id) MaxId = node.id;
                        node.Name = nodeInfo[1];
                        node.x = int.Parse(nodeInfo[2]);
                        node.y = int.Parse(nodeInfo[3]);
                        int[] edges = nodeInfo[4].Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).Select(e => int.Parse(e)).ToArray();
                        node.Edges = new List<int>();
                        foreach (int e in edges) node.Edges.Add(e);
                        Nodes.Add(node);
                        NodeById.Add(node.id, node);
                    }
                }
            }
            finally { f.Close(); }
            Nodes.Sort((n1, n2) => n1.id.CompareTo(n2.id));
        }

        public bool Directed
        {
            get => directed;
            set
            {
                if (!value)
                    foreach (Node n in Nodes) foreach (int e in n.Edges) NodeById[e].AddEdge(n.id);
                directed = value;
            }
        }

        public List<int> ShortestCycleBFS()
        {
            Queue<int> queue = new Queue<int>();
            Dictionary<int, bool> used = new Dictionary<int, bool>(Nodes.Count);
            Dictionary<int, int> distance = new Dictionary<int, int>(Nodes.Count);
            Dictionary<int, int> previous = new Dictionary<int, int>(Nodes.Count);
            List<List<int>> cycles = new List<List<int>>();
            
            foreach (Node i in Nodes)
            {
                List<int> currentCycle = new List<int>();
                queue.Clear();
                foreach (Node n in Nodes)
                { used[n.id] = false; distance[n.id] = -1; previous[n.id] = -1; }

                used[i.id] = true;
                distance[i.id] = 0;
                queue.Enqueue(i.id);
                previous[i.id] = -1;
                while (queue.Count > 0)
                {
                    Node s = NodeById[queue.Dequeue()];
                    
                    if (s.Edges.Contains(i.id))
                    {
                        currentCycle.Add(s.id);
                        break;
                    }

                    foreach (int e in s.Edges)
                    {
                        if (used[e]) continue;
                        used[e] = true;
                        distance[e] = distance[s.id] + 1;
                        queue.Enqueue(e);
                        previous[e] = s.id;
                    }
                }

                if (currentCycle.Count > 0)
                {
                    while (true)
                    {
                        if (previous[currentCycle[0]] != -1)
                            currentCycle.Insert(0, previous[currentCycle[0]]);
                        else break;
                    }
                    currentCycle.Add(currentCycle[0]);
                    cycles.Add(currentCycle);
                }
            }

            if (cycles.Count == 0) return new List<int>();
            else
            {
                int shortestCycleIndex = 0;
                int shortestCycleLength = cycles[0].Count;
                for (int i = 1; i < cycles.Count; i++)
                {
                    if (cycles[i].Count < shortestCycleLength)
                    {
                        shortestCycleIndex = i;
                        shortestCycleLength = cycles[i].Count;
                    }
                }
                return cycles[shortestCycleIndex];
            }
        }
    }

    public class Trig
    {
        public static double DegToRad(double deg) => deg * Math.PI / 180;
        public static double RadToDeg(double rad) => rad / Math.PI * 180;
        public static double dX(double length, double direction) => length * Math.Cos(DegToRad(direction));
        public static double dY(double length, double direction) => length * Math.Sin(DegToRad(direction)) * (-1);
        public static double PointsDirection(int x1, int y1, int x2, int y2) => 180 - RadToDeg(Math.Atan2(y1 - y2, x1 - x2));
        public static double PointsDistance(int x1, int y1, int x2, int y2) => Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
    }

    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}