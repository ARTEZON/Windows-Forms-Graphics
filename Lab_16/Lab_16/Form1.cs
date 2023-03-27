using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ZedGraph;

namespace Lab_16
{
    public partial class Form1 : Form
    {
        GraphPane pane;
        double a, b;

        public Form1()
        {
            InitializeComponent();
            pane = zedGraphControl.GraphPane;
            pane.Title.Text = "График";
            pane.XAxis.Title.IsVisible = false;
            pane.YAxis.Title.IsVisible = false;
            pane.YAxis.MajorGrid.IsZeroLine = false;
            pane.XAxis.Cross = 0.0;
            pane.YAxis.Cross = 0.0;
        }

        public double f(double x, double a, double b)
        {
            double cube_root = Math.Sign(x) * Math.Pow(Math.Abs(x), 1.0 / 3);
            return a * cube_root + (b + x);
        }

        public void Draw()
        {
            pane.CurveList.Clear();
            pane.GraphObjList.Clear();
            PointPairList list = new PointPairList();

            double xMin = -3;
            double xMax = -1;
            double step = 0.1;
            const double eps = 0.0000000001;

            for (double x = xMin; x <= xMax + eps; x += step)
                list.Add(x, f(x, a, b));

            LineItem curve = pane.AddCurve("f(x)", list, Color.Blue, SymbolType.None);

            PointPair min = list[0], max = list[0];
            foreach (PointPair point in list)
            {
                if (point.Y < min.Y) min = point;
                if (point.Y > max.Y) max = point;
            }
            LineItem lineLeft = pane.AddCurve("min", new double[] { min.X, min.X },
                new double[] { 0, min.Y }, Color.Green, SymbolType.None);
            LineItem lineRight = pane.AddCurve("max", new double[] { max.X, max.X },
                new double[] { 0, max.Y }, Color.DarkOrange, SymbolType.None);
            LineItem lineTop = pane.AddCurve("", new double[] { 0, min.X },
                new double[] { min.Y, min.Y }, Color.Green, SymbolType.None);
            LineItem lineBottom = pane.AddCurve("", new double[] { 0, max.X },
                new double[] { max.Y, max.Y }, Color.DarkOrange, SymbolType.None);

            TextObj minText = new TextObj(min.Y.ToString("0.##########"), 0, min.Y);
            minText.FontSpec.FontColor = Color.DarkGreen;
            minText.FontSpec.Border = new Border(Color.DarkGreen, 1);
            pane.GraphObjList.Add(minText);
            TextObj maxText = new TextObj(max.Y.ToString("0.##########"), 0, max.Y);
            maxText.FontSpec.FontColor = Color.DarkOrange;
            maxText.FontSpec.Border = new Border(Color.DarkOrange, 1);
            pane.GraphObjList.Add(maxText);

            zedGraphControl.AxisChange();
            zedGraphControl.Invalidate();
        }

        private void button_draw_Click(object sender, EventArgs e)
        {
            if (textBox_A.TextLength > 0 && textBox_B.TextLength > 0 &&
                textBox_A.Text != "-" && textBox_B.Text != "-") Draw();
            else MessageBox.Show("Для построения графика заполните поля A и B.",
                "Пустое поле", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_A.Clear();
            textBox_B.Clear();
            pane.CurveList.Clear();
            pane.GraphObjList.Clear();
            zedGraphControl.Invalidate();
        }

        private void textBox_A_TextChanged(object sender, EventArgs e)
        {
            if (textBox_A.TextLength > 0)
            {
                try
                {
                    a = double.Parse(textBox_A.Text);
                    if (textBox_B.TextLength > 0) Draw();
                }
                catch (FormatException)
                {
                    if (textBox_A.Text != "-")
                    {
                        textBox_A.BackColor = Color.FromArgb(255, 127, 127);
                        MessageBox.Show("Вы ввели недопустимый символ.\n\nПожалуйста, введите корректные данные.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox_A.Clear();
                        textBox_A.BackColor = Color.White;
                    }
                }
            }
        }

        private void textBox_B_TextChanged(object sender, EventArgs e)
        {
            if (textBox_B.TextLength > 0)
            {
                try
                {
                    b = double.Parse(textBox_B.Text);
                    if (textBox_A.TextLength > 0) Draw();
                }
                catch (FormatException)
                {
                    if (textBox_B.Text != "-")
                    {
                        textBox_B.BackColor = Color.FromArgb(255, 127, 127);
                        MessageBox.Show("Вы ввели недопустимый символ.\n\nПожалуйста, введите корректные данные.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox_B.Clear();
                        textBox_B.BackColor = Color.White;
                    }
                }
            }
        }
    }
}