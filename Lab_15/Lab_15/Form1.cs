using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Lab_15
{
    public partial class Form1 : Form
    {
        public Graph graph;

        public int drag = -1;
        public int dragEdge = -1;
        public bool mouseDown = false;
        public int mouseDownX = 0;
        public int mouseDownY = 0;
        public bool mouseMoved = false;
        public int dx1 = 0;
        public int dy1 = 0;
        public int dx2 = 0;
        public int dy2 = 0;

        public bool act = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            pictureBox.AllowDrop = true;
            graph = new Graph();
        }

        private void Draw()
        {
            Bitmap buffer = new Bitmap(Width, Height);
            Graphics gfx = Graphics.FromImage(buffer);
            gfx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            gfx.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;

            SolidBrush br1 = new SolidBrush(Color.Black);
            SolidBrush br2 = new SolidBrush(Color.White);
            Pen pen1 = new Pen(Color.Black, 2);
            Pen pen2 = new Pen(Color.Black, 2);
            AdjustableArrowCap arrow = new AdjustableArrowCap(8, 8);
            Font font = new Font("Arial", 12, FontStyle.Bold);

            gfx.Clear(Color.White);
            pen2.Color = Color.Black;
            br2.Color = Color.Black;
            if (graph.Directed) pen2.CustomEndCap = arrow;
            foreach (Graph.Node n in graph.Nodes)
            {
                foreach (int eg in n.Edges)
                {
                    foreach (Graph.Node m in graph.Nodes)
                    {
                        if (m.id == eg)
                        {
                            double dir = Trig.PointsDirection(n.x, n.y, m.x, m.y);
                            double dist = Trig.PointsDistance(n.x, n.y, m.x, m.y);
                            gfx.DrawLine(pen2,
                                n.x + (int)Trig.dX(graph.NodeSize / 2, dir),
                                n.y + (int)Trig.dY(graph.NodeSize / 2, dir),
                                n.x + (int)Trig.dX(dist - (graph.NodeSize / 2), dir),
                                n.y + (int)Trig.dY(dist - (graph.NodeSize / 2), dir));
                        }
                    }
                }
            }
            if (dragEdge != -1)
            {
                pen2.Color = Color.Green;
                br2.Color = Color.Green;
                if ((Control.ModifierKeys & Keys.Shift) != 0)
                {
                    pen2.Color = Color.Red;
                    br2.Color = Color.Red;
                }
                double dir2 = Trig.PointsDirection(dx1, dy1, dx2, dy2);
                double dist2 = Trig.PointsDistance(dx1, dy1, dx2, dy2);
                gfx.DrawLine(pen2,
                    dx1 + (int)Trig.dX(graph.NodeSize / 2, dir2),
                    dy1 + (int)Trig.dY(graph.NodeSize / 2, dir2),
                    dx1 + (int)Trig.dX(dist2, dir2),
                    dy1 + (int)Trig.dY(dist2, dir2));
            }
            foreach (Graph.Node n in graph.Nodes)
            {
                br2.Color = Color.White;
                if (n.Colored) br2.Color = Color.Orange;
                gfx.FillEllipse(br2, new Rectangle(n.x - graph.NodeSize / 2, n.y - graph.NodeSize / 2, graph.NodeSize, graph.NodeSize));
                gfx.DrawEllipse(pen1, new Rectangle(n.x - graph.NodeSize / 2, n.y - graph.NodeSize / 2, graph.NodeSize, graph.NodeSize));
                gfx.DrawString(n.Name, font, br1, n.x - gfx.MeasureString(n.Name, font).ToSize().Width / 2, n.y - 9);
            }

            pictureBox.Image = buffer;
            br1.Dispose();
            br2.Dispose();
            pen1.Dispose();
            pen2.Dispose();
            arrow.Dispose();
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < graph.Nodes.Count; i++)
            {
                for (int j = 0; j < graph.Nodes.Count; j++)
                {
                    if (i != j)
                    {
                        double dist = Trig.PointsDistance(graph.Nodes[i].x, graph.Nodes[i].y, graph.Nodes[j].x, graph.Nodes[j].y);
                        const int margin = 5;
                        if (dist <= graph.NodeSize + margin)
                        {
                            var rand = new Random();
                            if (graph.Nodes[i].x == graph.Nodes[j].x)
                            {
                                if (rand.Next(2) == 1)
                                    graph.Nodes[i].x += 1;
                                else
                                    graph.Nodes[i].x -= 1;
                            }
                            if (graph.Nodes[i].y == graph.Nodes[j].y)
                            {
                                if (rand.Next(2) == 1)
                                    graph.Nodes[i].y += 1;
                                else
                                    graph.Nodes[i].y -= 1;
                            }

                            int deltaX = (int)Trig.dX(graph.NodeSize + margin - dist, Trig.PointsDirection(graph.Nodes[i].x, graph.Nodes[i].y, graph.Nodes[j].x, graph.Nodes[j].y));
                            if (deltaX < 1) deltaX = 1;
                            int deltaY = (int)Trig.dY(graph.NodeSize + margin - dist, Trig.PointsDirection(graph.Nodes[i].x, graph.Nodes[i].y, graph.Nodes[j].x, graph.Nodes[j].y));
                            if (deltaY < 1) deltaY = 1;

                            if (graph.Nodes[i].x < graph.Nodes[j].x)
                            {
                                graph.Nodes[i].x -= deltaX / 2;
                                graph.Nodes[j].x += deltaX / 2;
                            }                      
                            else                   
                            {
                                graph.Nodes[i].x += deltaX / 2;
                                graph.Nodes[j].x -= deltaX / 2;
                            }
                            if (graph.Nodes[i].y < graph.Nodes[j].y)
                            {
                                graph.Nodes[i].y -= deltaY / 2;
                                graph.Nodes[j].y += deltaY / 2;
                            }
                            else
                            {
                                graph.Nodes[i].y += deltaY / 2;
                                graph.Nodes[j].y -= deltaY / 2;
                            }
                        }
                    }
                }
                if (graph.Nodes[i].x - graph.NodeSize / 2 < 0) graph.Nodes[i].x = graph.NodeSize / 2;
                if (graph.Nodes[i].y - graph.NodeSize / 2 < 0) graph.Nodes[i].y = graph.NodeSize / 2;
                if (graph.Nodes[i].x + graph.NodeSize / 2 > pictureBox.Width) graph.Nodes[i].x = pictureBox.Width - graph.NodeSize / 2 - 1;
                if (graph.Nodes[i].y + graph.NodeSize / 2 > pictureBox.Height) graph.Nodes[i].y = pictureBox.Height - graph.NodeSize / 2 - 1;
            }

            Draw();
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                if (!mouseMoved && (Math.Abs(e.X - mouseDownX) + Math.Abs(e.Y - mouseDownY)) >= (drag != -1 || dragEdge != -1 ? 1 : 16)) mouseMoved = true;
                if (drag != -1)
                {
                    Graph.Node n = graph.NodeById[drag];
                    n.x = e.X;
                    n.y = e.Y;
                }
                if (dragEdge != -1)
                {
                    Graph.Node n = graph.NodeById[dragEdge];
                    dx1 = n.x;
                    dy1 = n.y;
                    dx2 = e.X;
                    dy2 = e.Y;
                }
            }
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (!mouseDown && !act)
            {
                drag = dragEdge = -1;
                if (e.Button == MouseButtons.Left)
                {
                    mouseDown = true;
                    mouseDownX = e.X;
                    mouseDownY = e.Y;
                    mouseMoved = false;

                    foreach (Graph.Node n in graph.Nodes)
                    {
                        if (Trig.PointsDistance(n.x, n.y, e.X, e.Y) < graph.NodeSize / 2)
                        {
                            drag = n.id;
                            break;
                        }
                    }
                }
                if (e.Button == MouseButtons.Right && !act)
                {
                    mouseDown = true;
                    mouseDownX = e.X;
                    mouseDownY = e.Y;
                    mouseMoved = false;

                    dx1 = 0; dy1 = 0;
                    dx2 = 0; dy2 = 0;
                    foreach (Graph.Node n in graph.Nodes)
                    {
                        if (Trig.PointsDistance(n.x, n.y, e.X, e.Y) < graph.NodeSize / 2)
                        {
                            dragEdge = n.id;
                            dx1 = n.x; dy1 = n.y;
                            dx2 = e.X; dy2 = e.Y;
                            mouseMoved = true;
                            break;
                        }
                    }
                }
            }
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (mouseDown && !act)
            {
                mouseDown = false;
                if (e.Button == MouseButtons.Left)
                {
                    if (!mouseMoved)
                    {
                        if ((Control.ModifierKeys & Keys.Shift) == 0)
                        {
                            graph.AddNode(e.X, e.Y);
                            foreach (int i in graph.NodeById.Keys) graph.NodeById[i].Colored = false;
                            label_algo.Text = "";
                        }
                        else
                        {
                            int deleteId = -1;
                            foreach (Graph.Node n in graph.Nodes)
                            {
                                if (Trig.PointsDistance(n.x, n.y, e.X, e.Y) < graph.NodeSize / 2)
                                {
                                    deleteId = n.id;
                                    foreach (int i in graph.NodeById.Keys) graph.NodeById[i].Colored = false;
                                    label_algo.Text = "";
                                    break;
                                }
                            }
                            if (deleteId != -1) graph.RemoveNode(deleteId);
                        }
                    }
                }
                if (e.Button == MouseButtons.Right)
                {
                    if (dragEdge != -1)
                    {
                        foreach (Graph.Node n in graph.Nodes)
                        {
                            if (Trig.PointsDistance(n.x, n.y, e.X, e.Y) < graph.NodeSize / 2)
                            {
                                if (n.id != dragEdge)
                                {
                                    Graph.Node m = graph.NodeById[dragEdge];
                                    if ((Control.ModifierKeys & Keys.Shift) == 0)
                                        graph.AddEdge(m.id, n.id);
                                    else
                                        graph.RemoveEdge(m.id, n.id);
                                    foreach (int i in graph.NodeById.Keys) graph.NodeById[i].Colored = false;
                                    label_algo.Text = "";
                                }
                            }
                        }
                    }
                }
                drag = dragEdge = -1;
                mouseMoved = false;
            }
        }

        private void button_load_Click(object sender, EventArgs e)
        {
            act = true;
            openFileDialog1.ShowDialog();
            act = false;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            act = true;
            if (graph.Nodes.Count > 0) saveFileDialog1.ShowDialog();
            act = false;
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try { graph.Load(openFileDialog1.FileName); }
            catch (Exception ex) { MessageBox.Show("Ошибка при открытии файла: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            checkBox_directedGraph.Checked = graph.Directed;
            label_algo.Text = "";
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try { graph.Save(saveFileDialog1.FileName); }
            catch (Exception ex) { MessageBox.Show("Ошибка при сохранении файла: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void checkBox_directedGraph_CheckedChanged(object sender, EventArgs e)
        {
            graph.Directed = checkBox_directedGraph.Checked;
            foreach (int i in graph.NodeById.Keys) graph.NodeById[i].Colored = false;
            label_algo.Text = "";
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            graph.Nodes.Clear();
            graph.NodeById.Clear();
            label_algo.Text = "";
        }

        private void button_algo_Click(object sender, EventArgs e)
        {
            if (!graph.Directed) { MessageBox.Show("Алгоритм нужно запускать на ориентированном графе.",
                "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            List<int> cycle = graph.ShortestCycleBFS();
            if (cycle.Count > 0)
            {
                foreach (int i in graph.NodeById.Keys) graph.NodeById[i].Colored = false;
                foreach (int i in cycle) graph.NodeById[i].Colored = true;
                string cycleString = String.Join(" 🠖 ", cycle);
                label_algo.Text = cycleString;
            }
            else
            {
                label_algo.Text = "В графе нет циклов";
            }
        }

        private void pictureBox_DragDrop(object sender, DragEventArgs e)
        {
            var drop = e.Data.GetData(DataFormats.FileDrop);
            if (drop != null)
            {
                var fileNames = drop as string[];
                if (fileNames.Length > 0 && fileNames[0].ToLower().EndsWith(".grf"))
                {
                    try { graph.Load(fileNames[0]); }
                    catch (Exception ex) { MessageBox.Show("Ошибка при открытии файла: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                    checkBox_directedGraph.Checked = graph.Directed;
                    label_algo.Text = "";
                }
            }
        }

        private void pictureBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
    }
}