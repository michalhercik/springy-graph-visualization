using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphVisualization
{
    class Springy
    {
        private void DirectForce(Node node, double x, double y)
        {
            double k = 0.02;
            Vector v = new Vector(x - node.X, y - node.Y);
            if (v.Distance > 100)
                node.ChangePosition(k * v);
        }

        private bool Repulse(Node node, double x, double y, int springLength, Dictionary<Node, Vector> acc)
        {
            double k = 0.01;
            Vector v = new Vector(node.X - x, node.Y - y);
            if (v.Distance < springLength && v.Distance != 0)
            {
                double p = springLength / v.Distance;
                Vector force = k * (1 - p) / 2 * v;
                Vector v1 = acc[node];
                v1.Add(-1 * force);
                return true;
            }
            return false;
        }
        private bool SpringForce(Edge spring, int springLength, Dictionary<Node, Vector> acc)
        {
            double k = 0.01;
            int delta = 5;
            Vector v = new Vector(spring.n1.X - spring.n2.X, spring.n1.Y - spring.n2.Y);
            if (v.Distance < springLength - delta
                || v.Distance > springLength + delta 
                && v.Distance != 0)
            {
                double p = springLength / v.Distance;
                Vector force = k * (1 - p) / 2 * v;
                acc[spring.n1].Add(-1 * force);
                acc[spring.n2].Add(force);
                return true;
            }
            return false;
        }

        public void Run(Graphics graphics, Graph graph, int width, int height)
        {
            graph.ShowEdges(graphics);
            Dictionary<Node, Vector> acc = new Dictionary<Node, Vector>();
            foreach (Node n in graph.Nodes)
            {
                acc[n] = new Vector(0, 0);
            }
            bool change = true;
            int iterationCounter = 0;
            int iterationMax = 100;
            int delay = 20;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            while (change && iterationCounter <= iterationMax)
            {
                if (sw.ElapsedMilliseconds > delay)
                {
                    ++iterationCounter;
                    change = false;
                    foreach (Edge e in graph.Edges.Values)
                    {
                        if (SpringForce(e, 50, acc))
                            change = true;
                    }
                    foreach (Node node in graph.Nodes)
                    {
                        acc[node].Mult(0.9);
                        DirectForce(node, width / 2, height / 2);
                        foreach (Node n in graph.Nodes)
                        {
                            if (n != node) 
                                Repulse(node, n.X, n.Y, 150, acc);
                        }
                        node.ChangePosition(acc[node]);
                    }
                    graph.ShowEdges(graphics);
                    sw.Restart();
                }
            }
            graph.CenterGraph(width, height);
            graph.UpdateEdgesCosts();
            graph.ShowGraph(graphics);
        }
    }
}

