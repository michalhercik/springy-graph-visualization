using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphVisualization
{
    class MinSpanningtree
    {
        int counter = 0;

        private ColorNode getColorNode(Node node, Dictionary<Node, ColorNode> colors)
        {
            bool exists = colors.ContainsKey(node);
            if (!exists)
            {
                colors[node] = new ColorNode(counter);
                ++counter;
            }
            return colors[node].GetRoot();
        }

        private bool TryAddEdge(Edge edge, Dictionary<Node, ColorNode> colors)
        {
            ColorNode n1 = getColorNode(edge.n1, colors);
            ColorNode n2 = getColorNode(edge.n2, colors);

            if (n1.Color == n2.Color)
            {
                edge.Pen.Color = Color.FromArgb(70, 70, 70);
                return false;
            }

            edge.Pen.Color = Color.Red;

            if (n1.Height > n2.Height)
            {
                n2.SetParent(n1);
            }
            else
            {
                n1.SetParent(n2);
            }
            
            return true;
        }

        public void Find(Graphics graphics, Graph graph)
        {
            Dictionary<Node, ColorNode> colors = new Dictionary<Node, ColorNode>();
            Stopwatch sw = new Stopwatch();
            int delay = 200;
            List<Edge> orderedEdges = graph.Edges.Values.OrderBy(e => e.Cost).ToList<Edge>();
            int i = 0;
            sw.Start();
            while (i < orderedEdges.Count)
            {
                if (sw.ElapsedMilliseconds > delay)
                {
                    TryAddEdge(orderedEdges[i], colors);
                    graph.ShowGraph(graphics);
                    sw.Restart();
                    ++i;
                }
            }
        }
    }
}
