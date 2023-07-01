using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphVisualization
{
    class Node
    {
        public int Id { private set; get; }
        public double X, Y;
        public Brush Brush = Brushes.Green;
        public int Diameter = 25;
        public List<Node> Links { private set; get; } = new List<Node>();

        public Node(int id, double x, double y)
        {
            Id = id;
            X = x;
            Y = y;
        }

        public void AddLink(Node node)
        {
            Links.Add(node);
        }

        public void ResetColor()
        {
            Brush = Brushes.Green;
        }

        public void ChangePosition(Vector v)
        {
            X += v.X;
            Y += v.Y;
        }

        public override string ToString()
        {
            return $"{Id}: {X},{Y}";
        }
    }
}
