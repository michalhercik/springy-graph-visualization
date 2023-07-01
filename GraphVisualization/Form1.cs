using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphVisualization
{
    public partial class Form1 : Form
    {
        Graph graph = new Graph();
        public Form1()
        {
            InitializeComponent();
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            graph = new Graph();
            OpenFileDialog ofd = new OpenFileDialog(); 
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                graph.ParseInput(ofd.FileName);
                graph.PredictNodesPositions();
                graph.CenterGraph(canvas.Width, canvas.Height);
                using (Graphics g = canvas.CreateGraphics())
                    new Springy().Run(g, graph, canvas.Width, canvas.Height);
            }
            
        }

        private void componLabBtn_Click(object sender, EventArgs e)
        {
            using (Graphics g = canvas.CreateGraphics())
                new ComponentLabeling().Label(g, graph);
        }

        private void transBtn_Click(object sender, EventArgs e)
        {
            using (Graphics g = canvas.CreateGraphics())
                new TransitiveClosure().Run(g, graph);
        }

        private void springyBtn_Click(object sender, EventArgs e)
        {
            using (Graphics g = canvas.CreateGraphics())
                new Springy().Run(g, graph, canvas.Width, canvas.Height);
        }

        private void spanTreeBtn_Click(object sender, EventArgs e)
        {
            using (Graphics g = canvas.CreateGraphics())
                new MinSpanningtree().Find(g, graph);
        }

        private void rstColorsBtn_Click(object sender, EventArgs e)
        {
            using (Graphics g = canvas.CreateGraphics())
                graph.ResetColors(g);
        }

        private void predictBtn_Click(object sender, EventArgs e)
        {
            graph.PredictNodesPositions();
            graph.CenterGraph(canvas.Width, canvas.Height);
            using (Graphics g = canvas.CreateGraphics())
                graph.ShowGraph(g);
        }

        private void rndBtn_Click(object sender, EventArgs e)
        {
            graph.RandomizeNodesPositions(canvas.Width, canvas.Height);
            using (Graphics g = canvas.CreateGraphics())
                graph.ShowGraph(g);
        }
    }
}
