using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphVisualization
{
    class ColorNode
    {
        public int Height { private set; get; } = 1;
        public int Color;
        public ColorNode Parent { private set; get; } = null;

        public ColorNode(int color)
        {
            Color = color;
        }

        public ColorNode GetRoot()
        {
            ColorNode root = this;
            while (root.Parent != null)
                root = root.Parent;
            return root;
        }

        public void SetParent(ColorNode parent)
        {
            Parent = parent;
            if (parent.Height < Height + 1)
                parent.Height = Height + 1;
        }
    }
}
