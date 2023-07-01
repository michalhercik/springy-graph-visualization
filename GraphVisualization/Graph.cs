using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GraphVisualization
{
    class Graph
    {
        public List<Node> Nodes = new List<Node>();
        public Dictionary<int, Edge> Edges = new Dictionary<int, Edge>();

        public bool ParseInput(string file)
        {
            using (StreamReader sr = new StreamReader(file))
            {
                Regex headRegex = new Regex(@"v ([0-9]+)");
                Match m = headRegex.Match(sr.ReadLine());
                if (!m.Success) return false;
                int n = int.Parse(m.Groups[1].Value);
                Regex line = new Regex(@"l ([0-9]+) ([0-9]+)");
                Random rnd = new Random();
                while (n > 0)
                {
                    m = line.Match(sr.ReadLine());
                    if (m.Success)
                    {
                        int id1 = int.Parse(m.Groups[1].Value);
                        int id2 = int.Parse(m.Groups[2].Value);
                        if (id1 > Nodes.Count)
                            Nodes.Add(new Node(id1, rnd.Next(500), rnd.Next(500)));
                        if (id2 > Nodes.Count)
                            Nodes.Add(new Node(id2, rnd.Next(500), rnd.Next(500)));

                        AddUndEdge(Nodes[id1 - 1], Nodes[id2 - 1]);
                    }
                    --n;
                }
            }
            return true;
        }

        public void ResetColors(Graphics g)
        {
            foreach (Node node in Nodes)
                node.ResetColor();
            foreach (Edge edge in Edges.Values)
                edge.ResetColor();
            ShowGraph(g);
        }

        public void ShowEdges(Graphics g)
        {
            g.Clear(Color.FromArgb(30, 30, 30));
            foreach (Edge e in Edges.Values)
            {
                g.DrawLine(e.Pen,
                    (int)e.n1.X, (int)e.n1.Y,
                    (int)e.n2.X, (int)e.n2.Y
                    );
            }
        }

        public void ShowGraph(Graphics g)
        {
            ShowEdges(g);
            foreach (Node n in Nodes)
            {
                g.FillEllipse(n.Brush,
                    (int)n.X - n.Diameter / 2,
                    (int)n.Y - n.Diameter / 2,
                    n.Diameter, n.Diameter
                    );
            }
        }

        public void AddUndEdge(Node n1, Node n2)
        {
            int key = n1.Id > n2.Id ? (n1.Id << 16) | n2.Id : (n2.Id << 16) | n1.Id;
            if (Edges.ContainsKey(key)) return;
            n1.AddLink(n2);
            n2.AddLink(n1);
            Edges[key] = new Edge(n1, n2);
        }

        public void UpdateEdgesCosts()
        {
            foreach (Edge edge in Edges.Values)
            {
                edge.CalculateCost();
            }
        }

        public void RandomizeNodesPositions(int maxX, int maxY)
        {
            Random rnd = new Random();
            foreach (Node node in Nodes)
            {
                node.X = rnd.Next(node.Diameter / 2, maxX - node.Diameter / 2);
                node.Y = rnd.Next(node.Diameter / 2, maxY - node.Diameter / 2);
            }
            UpdateEdgesCosts();
        }

        public void PredictNodesPositions()
        {
            HashSet<Node> visited = new HashSet<Node>();
            Queue<Node> queue1 = new Queue<Node>();
            Queue<Node> queue2 = new Queue<Node>();
            int yPos = 0;
            int xPos = 0;
            int ComponentPosition = 40;
            int shift = 60;
            int layerSize = 0;
            for (int i = 0; i < Nodes.Count; ++i)
            {
                if (!visited.Contains(Nodes[i]))
                {
                    queue1.Enqueue(Nodes[i]);
                    visited.Add(Nodes[i]);
                    Nodes[i].X = ComponentPosition;
                    Nodes[i].Y = yPos;
                    yPos += shift;
                    while (queue1.Count > 0)
                    {
                        if (queue1.Count > layerSize)
                            layerSize = queue1.Count;
                        Node node = queue1.Dequeue();
                        foreach (Node n in node.Links)
                        {
                            if (!visited.Contains(n))
                            {
                                n.X = xPos + ComponentPosition;
                                n.Y = yPos;
                                xPos += shift;
                                queue2.Enqueue(n);
                                visited.Add(n);
                            }
                        }
                        if (queue1.Count == 0 && queue2.Count > 0)
                        {
                            Queue<Node> q = queue1;
                            queue1 = queue2;
                            queue2 = q;
                            yPos += shift;
                            xPos = 0;
                        }
                    }
                    ComponentPosition += layerSize*shift;
                    layerSize = 0;
                    xPos = 0;
                    yPos = 0;
                }
            }
            UpdateEdgesCosts();
        }

        public void CenterGraph(int width, int height)
        {
            if (Nodes.Count == 0) return;
            double[] rect = { Nodes[0].X, Nodes[0].X, Nodes[0].Y, Nodes[0].Y };
            foreach (Node node in Nodes)
            {
                if (node.X < rect[0]) rect[0] = node.X;
                if (node.X > rect[1]) rect[1] = node.X;
                if (node.Y < rect[2]) rect[2] = node.Y;
                if (node.Y > rect[3]) rect[3] = node.Y;
            }
            int deltaX = (int)(width - rect[0] - rect[1]) / 2;
            int deltaY = (int)(height - rect[2] - rect[3]) / 2;
            foreach (Node node in Nodes)
            {
                node.X += deltaX;
                node.Y += deltaY;
            }
        }

        public void RecolorEdges()
        {
            foreach (Edge edge in Edges.Values)
            {
                edge.ResetColor();
            }
        }
    }
}
