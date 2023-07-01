using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphVisualization
{
    class TransitiveClosure
    {
        public void Run(Graphics graphics, Graph graph)
        {
            graph.RecolorEdges();
            HashSet<Node> visited = new HashSet<Node>();
            HashSet<Node> component = new HashSet<Node>();
            Stack<Node> stack = new Stack<Node>();

            Stopwatch sw = new Stopwatch();
            sw.Start();

            foreach (Node startNode in graph.Nodes)
            {
                if (visited.Contains(startNode))
                    continue;
                visited.Add(startNode);
                component.Clear();
                component.Add(startNode);
                stack.Push(startNode);
                while (stack.Count > 0)
                {
                    if (sw.ElapsedMilliseconds > 300)
                    {
                        Node currentNode = stack.Pop();
                        foreach (Node n in component)
                        {
                            if (currentNode != n)
                                graph.AddUndEdge(currentNode, n);
                        }
                        component.Add(currentNode);
                        Brush brush = currentNode.Brush;
                        currentNode.Brush = Brushes.Red;
                        graph.ShowGraph(graphics);
                        currentNode.Brush = brush;
                        foreach (Node node in currentNode.Links)
                        {
                            if (!visited.Contains(node))
                            {
                                visited.Add(node);
                                stack.Push(node);
                            }
                        }
                        sw.Restart();
                    }
                }
            }
            graph.ShowGraph(graphics);
        }
    }
}
