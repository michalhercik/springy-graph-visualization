using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphVisualization
{
    class ComponentLabeling
    {
        public void Label(Graphics graphics, Graph graph)
        {
            HashSet<Node> visited = new HashSet<Node>();
            Stack<Node> stack = new Stack<Node>();
            Random rnd = new Random();
            Stopwatch sw = new Stopwatch();
            sw.Start();

            foreach (Node startNode in graph.Nodes)
            {
                if (visited.Contains(startNode))
                    continue;
                visited.Add(startNode);
                
                Color color = Color.FromArgb(rnd.Next(100,255), rnd.Next(100,255), rnd.Next(100,255));
                Brush brush = new SolidBrush(color);
                stack.Push(startNode);
                while (stack.Count > 0)
                {
                    if (sw.ElapsedMilliseconds > 300)
                    {
                        Node currentNode = stack.Pop();
                        currentNode.Brush = brush;
                        graph.ShowGraph(graphics);
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
        }
    }
}
